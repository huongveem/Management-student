namespace WinForm_StudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.rdtFemale = new System.Windows.Forms.RadioButton();
            this.rdtMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lv_Student = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpBirthDay);
            this.panel1.Controls.Add(this.rdtFemale);
            this.panel1.Controls.Add(this.rdtMale);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMathScore);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtStudentCode);
            this.panel1.Controls.Add(this.txtStudentName);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 132);
            this.panel1.TabIndex = 0;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtpBirthDay.Location = new System.Drawing.Point(282, 21);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(151, 19);
            this.dtpBirthDay.TabIndex = 15;
            // 
            // rdtFemale
            // 
            this.rdtFemale.AutoSize = true;
            this.rdtFemale.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtFemale.Location = new System.Drawing.Point(332, 61);
            this.rdtFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdtFemale.Name = "rdtFemale";
            this.rdtFemale.Size = new System.Drawing.Size(58, 19);
            this.rdtFemale.TabIndex = 14;
            this.rdtFemale.TabStop = true;
            this.rdtFemale.Text = "Female";
            this.rdtFemale.UseVisualStyleBackColor = true;
            // 
            // rdtMale
            // 
            this.rdtMale.AutoSize = true;
            this.rdtMale.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtMale.Location = new System.Drawing.Point(282, 61);
            this.rdtMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdtMale.Name = "rdtMale";
            this.rdtMale.Size = new System.Drawing.Size(46, 19);
            this.rdtMale.TabIndex = 13;
            this.rdtMale.TabStop = true;
            this.rdtMale.Text = "Male";
            this.rdtMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(279, 44);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(40, 15);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Math Score";
            // 
            // txtMathScore
            // 
            this.txtMathScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMathScore.Location = new System.Drawing.Point(5, 61);
            this.txtMathScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(66, 19);
            this.txtMathScore.TabIndex = 10;
            this.txtMathScore.TextChanged += new System.EventHandler(this.txtMathScore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "BirthDay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Student Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "StudentName";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(128, 21);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(113, 19);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtStudentCode.Location = new System.Drawing.Point(5, 99);
            this.txtStudentCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(111, 19);
            this.txtStudentCode.TabIndex = 1;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtStudentName.Location = new System.Drawing.Point(5, 21);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(111, 19);
            this.txtStudentName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By StudentName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(339, 155);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(148, 19);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.Controls.Add(this.Lv_Student);
            this.panel2.Location = new System.Drawing.Point(9, 177);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 306);
            this.panel2.TabIndex = 1;
            // 
            // Lv_Student
            // 
            this.Lv_Student.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lv_Student.HideSelection = false;
            this.Lv_Student.Location = new System.Drawing.Point(-1, 0);
            this.Lv_Student.Margin = new System.Windows.Forms.Padding(2);
            this.Lv_Student.Name = "Lv_Student";
            this.Lv_Student.Size = new System.Drawing.Size(481, 307);
            this.Lv_Student.TabIndex = 0;
            this.Lv_Student.UseCompatibleStateImageBehavior = false;
            this.Lv_Student.SelectedIndexChanged += new System.EventHandler(this.Lv_Student_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(69, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(129, 142);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(498, 495);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdtFemale;
        private System.Windows.Forms.RadioButton rdtMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.ListView Lv_Student;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
    }
}

