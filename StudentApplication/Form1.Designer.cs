namespace StudentApplication
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EntryID = new System.Windows.Forms.TextBox();
            this.EntryFirstName = new System.Windows.Forms.TextBox();
            this.EntryLastName = new System.Windows.Forms.TextBox();
            this.EntryBirthNumber = new System.Windows.Forms.TextBox();
            this.EntryAge = new System.Windows.Forms.NumericUpDown();
            this.EntryGrade = new System.Windows.Forms.NumericUpDown();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.UpdateStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EntrySearchTerm = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryGrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Orange;
            this.ConnectButton.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(27, 28);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(163, 55);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect to database";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.Color.Aqua;
            this.DisconnectButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(345, 28);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(158, 56);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Disconnect from database";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 353);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1026, 276);
            this.dgvStudents.TabIndex = 2;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade";
            // 
            // EntryID
            // 
            this.EntryID.Location = new System.Drawing.Point(142, 100);
            this.EntryID.Name = "EntryID";
            this.EntryID.Size = new System.Drawing.Size(100, 20);
            this.EntryID.TabIndex = 9;
            // 
            // EntryFirstName
            // 
            this.EntryFirstName.Location = new System.Drawing.Point(142, 140);
            this.EntryFirstName.Name = "EntryFirstName";
            this.EntryFirstName.Size = new System.Drawing.Size(100, 20);
            this.EntryFirstName.TabIndex = 10;
            // 
            // EntryLastName
            // 
            this.EntryLastName.Location = new System.Drawing.Point(142, 180);
            this.EntryLastName.Name = "EntryLastName";
            this.EntryLastName.Size = new System.Drawing.Size(100, 20);
            this.EntryLastName.TabIndex = 11;
            // 
            // EntryBirthNumber
            // 
            this.EntryBirthNumber.Location = new System.Drawing.Point(142, 221);
            this.EntryBirthNumber.Name = "EntryBirthNumber";
            this.EntryBirthNumber.Size = new System.Drawing.Size(100, 20);
            this.EntryBirthNumber.TabIndex = 12;
            // 
            // EntryAge
            // 
            this.EntryAge.Location = new System.Drawing.Point(142, 260);
            this.EntryAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EntryAge.Name = "EntryAge";
            this.EntryAge.Size = new System.Drawing.Size(120, 20);
            this.EntryAge.TabIndex = 13;
            this.EntryAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EntryGrade
            // 
            this.EntryGrade.Location = new System.Drawing.Point(142, 300);
            this.EntryGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EntryGrade.Name = "EntryGrade";
            this.EntryGrade.Size = new System.Drawing.Size(120, 20);
            this.EntryGrade.TabIndex = 14;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(345, 130);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(125, 23);
            this.AddStudentButton.TabIndex = 15;
            this.AddStudentButton.Text = "Add student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // UpdateStudentButton
            // 
            this.UpdateStudentButton.Location = new System.Drawing.Point(345, 188);
            this.UpdateStudentButton.Name = "UpdateStudentButton";
            this.UpdateStudentButton.Size = new System.Drawing.Size(125, 23);
            this.UpdateStudentButton.TabIndex = 16;
            this.UpdateStudentButton.Text = "Update student info";
            this.UpdateStudentButton.UseVisualStyleBackColor = true;
            this.UpdateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(345, 242);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(125, 23);
            this.DeleteStudentButton.TabIndex = 17;
            this.DeleteStudentButton.Text = "Delete student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.EntrySearchTerm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FilterComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(561, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 192);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Filter";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(89, 21);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 21);
            this.FilterComboBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search term";
            // 
            // EntrySearchTerm
            // 
            this.EntrySearchTerm.Location = new System.Drawing.Point(89, 72);
            this.EntrySearchTerm.Name = "EntrySearchTerm";
            this.EntrySearchTerm.Size = new System.Drawing.Size(121, 20);
            this.EntrySearchTerm.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(75, 128);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 653);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.UpdateStudentButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.EntryGrade);
            this.Controls.Add(this.EntryAge);
            this.Controls.Add(this.EntryBirthNumber);
            this.Controls.Add(this.EntryLastName);
            this.Controls.Add(this.EntryFirstName);
            this.Controls.Add(this.EntryID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryGrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EntryID;
        private System.Windows.Forms.TextBox EntryFirstName;
        private System.Windows.Forms.TextBox EntryLastName;
        private System.Windows.Forms.TextBox EntryBirthNumber;
        private System.Windows.Forms.NumericUpDown EntryAge;
        private System.Windows.Forms.NumericUpDown EntryGrade;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button UpdateStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox EntrySearchTerm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label label7;
    }
}

