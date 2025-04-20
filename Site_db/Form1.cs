using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Site_db
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string pripojovaciRetezec = @"Data Source=|DataDirectory|\MyDatabase.sqlite;Version=3;";
            string dotaz = "SELECT Id, Jmeno, Prijmeni FROM Osoby";

            try
            {
                using (SQLiteConnection pripojeni = new SQLiteConnection(pripojovaciRetezec))
                {
                    pripojeni.Open();

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(dotaz, pripojeni);
                    DataTable dataTabulka = new DataTable();
                    adapter.Fill(dataTabulka);

                    dataGridOsoby.DataSource = dataTabulka;
                    informaceLabel.Text = "Data načtena.";
                }
            }
            catch (Exception ex)
            {
                informaceLabel.Text = "Chyba při načítání dat: " + ex.Message;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string pripojovaciRetezec = @"Data Source=|DataDirectory|\MyDatabase.sqlite;Version=3;";
            string jmeno = jmenoTextBox.Text.Trim();
            string prijmeni = prijmeniTextBox.Text.Trim();
            string dotaz = "INSERT INTO Osoby (Jmeno, Prijmeni) VALUES (@Jmeno, @Prijmeni)";

            if (!string.IsNullOrEmpty(jmeno) && !string.IsNullOrEmpty(prijmeni))
            {
                try
                {
                    using (SQLiteConnection pripojeni = new SQLiteConnection(pripojovaciRetezec))
                    {
                        pripojeni.Open();

                        using (SQLiteCommand prikaz = new SQLiteCommand(dotaz, pripojeni))
                        {
                            prikaz.Parameters.AddWithValue("@Jmeno", jmeno);
                            prikaz.Parameters.AddWithValue("@Prijmeni", prijmeni);
                            prikaz.ExecuteNonQuery();

                            informaceLabel.Text = "Osoba přidána.";
                            jmenoTextBox.Clear();
                            prijmeniTextBox.Clear();
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    informaceLabel.Text = "Chyba při přidávání osoby: " + ex.Message;
                }
            }
            else
            {
                informaceLabel.Text = "Prosím, vyplňte jméno a příjmení.";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string pripojovaciRetezec = @"Data Source=|DataDirectory|\MyDatabase.sqlite;Version=3;";
            if (int.TryParse(textBoxDeleteId.Text.Trim(), out int idKeSmazani))
            {
                string dotaz = "DELETE FROM Osoby WHERE Id = @Id";

                try
                {
                    using (SQLiteConnection pripojeni = new SQLiteConnection(pripojovaciRetezec))
                    {
                        pripojeni.Open();

                        using (SQLiteCommand prikaz = new SQLiteCommand(dotaz, pripojeni))
                        {
                            prikaz.Parameters.AddWithValue("@Id", idKeSmazani);
                            int pocetOvlivnenychRadku = prikaz.ExecuteNonQuery();

                            if (pocetOvlivnenychRadku > 0)
                            {
                                informaceLabel.Text = "Osoba s ID " + idKeSmazani + " smazána.";
                                textBoxDeleteId.Clear();
                                LoadData();
                            }
                            else
                            {
                                informaceLabel.Text = "Osoba s ID " + idKeSmazani + " nebyla nalezena.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    informaceLabel.Text = "Chyba při mazání osoby: " + ex.Message;
                }
            }
            else
            {
                informaceLabel.Text = "Prosím, zadejte platné ID ke smazání.";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            string pripojovaciRetezec = @"Data Source=|DataDirectory|\MyDatabase.sqlite;Version=3;";
            string jmeno = jmenoTextBox.Text.Trim();
            string prijmeni = prijmeniTextBox.Text.Trim();

            if (int.TryParse(idTextBox.Text, out int idKUprave) && !string.IsNullOrEmpty(jmeno) && !string.IsNullOrEmpty(prijmeni))
            {
                string dotaz = "UPDATE Osoby SET Jmeno = @Jmeno, Prijmeni = @Prijmeni WHERE Id = @Id";

                try
                {
                    using (SQLiteConnection pripojeni = new SQLiteConnection(pripojovaciRetezec))
                    {
                        pripojeni.Open();

                        using (SQLiteCommand prikaz = new SQLiteCommand(dotaz, pripojeni))
                        {
                            prikaz.Parameters.AddWithValue("@Id", idKUprave);
                            prikaz.Parameters.AddWithValue("@Jmeno", jmeno);
                            prikaz.Parameters.AddWithValue("@Prijmeni", prijmeni);
                            int pocetOvlivnenychRadku = prikaz.ExecuteNonQuery();

                            if (pocetOvlivnenychRadku > 0)
                            {
                                informaceLabel.Text = "Osoba s ID " + idKUprave + " upravena.";
                                jmenoTextBox.Clear();
                                prijmeniTextBox.Clear();
                                idTextBox.Clear(); 
                                LoadData(); 
                            }
                            else
                            {
                                informaceLabel.Text = "Osobu s ID " + idKUprave + " se nepodařilo upravit.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    informaceLabel.Text = "Chyba při úpravě osoby: " + ex.Message;
                }
            }
            else
            {
                informaceLabel.Text = "Prosím, vyberte osobu k úpravě nebo zadejte platné jméno a příjmení.";
            }
        }

        private void dataGridOsoby_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow vybranyRadek = dataGridOsoby.Rows[e.RowIndex];
                idTextBox.Text = vybranyRadek.Cells["Id"].Value.ToString();
                jmenoTextBox.Text = vybranyRadek.Cells["Jmeno"].Value.ToString();
                prijmeniTextBox.Text = vybranyRadek.Cells["Prijmeni"].Value.ToString();
            }
        }

        private void VytvorSQLiteDatabazi()
        {
            string pripojovaciRetezec = @"Data Source=|DataDirectory|\MyDatabase.sqlite;Version=3;";
            using (SQLiteConnection pripojeni = new SQLiteConnection(pripojovaciRetezec))
            {
                pripojeni.Open();
                string prikazCreateTable = @"
                    CREATE TABLE IF NOT EXISTS Osoby (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Jmeno TEXT,
                        Prijmeni TEXT
                    );
                ";
                using (SQLiteCommand prikaz = new SQLiteCommand(prikazCreateTable, pripojeni))
                {
                    prikaz.ExecuteNonQuery();
                }
            }
        }
    }
}