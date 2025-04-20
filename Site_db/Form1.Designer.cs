namespace Site_db
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridOsoby = new System.Windows.Forms.DataGridView();
            this.informaceLabel = new System.Windows.Forms.Label();
            this.smazatButton = new System.Windows.Forms.Button();
            this.pridatButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prijmeniTextBox = new System.Windows.Forms.TextBox();
            this.jmenoTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOsoby)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOsoby
            // 
            this.dataGridOsoby.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOsoby.Location = new System.Drawing.Point(73, 279);
            this.dataGridOsoby.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridOsoby.Name = "dataGridOsoby";
            this.dataGridOsoby.RowHeadersWidth = 72;
            this.dataGridOsoby.RowTemplate.Height = 31;
            this.dataGridOsoby.Size = new System.Drawing.Size(962, 410);
            this.dataGridOsoby.TabIndex = 21;
            this.dataGridOsoby.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOsoby_CellClick);
            // 
            // informaceLabel
            // 
            this.informaceLabel.AutoSize = true;
            this.informaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informaceLabel.Location = new System.Drawing.Point(69, 243);
            this.informaceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.informaceLabel.Name = "informaceLabel";
            this.informaceLabel.Size = new System.Drawing.Size(81, 20);
            this.informaceLabel.TabIndex = 19;
            this.informaceLabel.Text = "Informace";
            // 
            // smazatButton
            // 
            this.smazatButton.Location = new System.Drawing.Point(284, 169);
            this.smazatButton.Margin = new System.Windows.Forms.Padding(2);
            this.smazatButton.Name = "smazatButton";
            this.smazatButton.Size = new System.Drawing.Size(80, 32);
            this.smazatButton.TabIndex = 16;
            this.smazatButton.Text = "Smazat";
            this.smazatButton.UseVisualStyleBackColor = true;
            this.smazatButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pridatButton
            // 
            this.pridatButton.Location = new System.Drawing.Point(188, 169);
            this.pridatButton.Margin = new System.Windows.Forms.Padding(2);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.Size = new System.Drawing.Size(80, 32);
            this.pridatButton.TabIndex = 15;
            this.pridatButton.Text = "Přidat";
            this.pridatButton.UseVisualStyleBackColor = true;
            this.pridatButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Příjmení:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jméno:";
            // 
            // prijmeniTextBox
            // 
            this.prijmeniTextBox.Location = new System.Drawing.Point(188, 110);
            this.prijmeniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.prijmeniTextBox.Name = "prijmeniTextBox";
            this.prijmeniTextBox.Size = new System.Drawing.Size(174, 20);
            this.prijmeniTextBox.TabIndex = 12;
            // 
            // jmenoTextBox
            // 
            this.jmenoTextBox.Location = new System.Drawing.Point(188, 77);
            this.jmenoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.jmenoTextBox.Name = "jmenoTextBox";
            this.jmenoTextBox.Size = new System.Drawing.Size(174, 20);
            this.jmenoTextBox.TabIndex = 11;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(382, 169);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(80, 32);
            this.editButton.TabIndex = 22;
            this.editButton.Text = "Upravit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(188, 40);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(174, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "ID:";
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(499, 77);
            this.textBoxDeleteId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(174, 20);
            this.textBoxDeleteId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID ke zmazání:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.dataGridOsoby);
            this.Controls.Add(this.informaceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDeleteId);
            this.Controls.Add(this.smazatButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijmeniTextBox);
            this.Controls.Add(this.jmenoTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOsoby)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOsoby;
        private System.Windows.Forms.Label informaceLabel;
        private System.Windows.Forms.Button smazatButton;
        private System.Windows.Forms.Button pridatButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prijmeniTextBox;
        private System.Windows.Forms.TextBox jmenoTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.Label label3;
    }
}

