namespace Workforce_
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLQuery1DataSet1 = new Workforce_.SQLQuery1DataSet1();
            this.salary_employeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salary_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_clearBtn = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new Workforce_.SQLQuery1DataSet1TableAdapters.employeesTableAdapter();
            this.salary_position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "employees";
            this.employeesBindingSource.DataSource = this.sQLQuery1DataSet1;
            // 
            // sQLQuery1DataSet1
            // 
            this.sQLQuery1DataSet1.DataSetName = "SQLQuery1DataSet1";
            this.sQLQuery1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salary_employeeID
            // 
            this.salary_employeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_employeeID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_employeeID.Location = new System.Drawing.Point(36, 163);
            this.salary_employeeID.Name = "salary_employeeID";
            this.salary_employeeID.Size = new System.Drawing.Size(301, 30);
            this.salary_employeeID.TabIndex = 1;
            this.salary_employeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(31, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // salary_name
            // 
            this.salary_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_name.Location = new System.Drawing.Point(36, 257);
            this.salary_name.Name = "salary_name";
            this.salary_name.Size = new System.Drawing.Size(301, 30);
            this.salary_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(33, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(31, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position:";
            // 
            // salary_salary
            // 
            this.salary_salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_salary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_salary.Location = new System.Drawing.Point(36, 470);
            this.salary_salary.Name = "salary_salary";
            this.salary_salary.Size = new System.Drawing.Size(301, 30);
            this.salary_salary.TabIndex = 7;
            this.salary_salary.TextChanged += new System.EventHandler(this.salary_salary_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(31, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.salary_updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_updateBtn.ForeColor = System.Drawing.Color.White;
            this.salary_updateBtn.Location = new System.Drawing.Point(504, 377);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(301, 62);
            this.salary_updateBtn.TabIndex = 16;
            this.salary_updateBtn.Text = "UPDATE";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_clearBtn
            // 
            this.salary_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.salary_clearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_clearBtn.ForeColor = System.Drawing.Color.White;
            this.salary_clearBtn.Location = new System.Drawing.Point(504, 456);
            this.salary_clearBtn.Name = "salary_clearBtn";
            this.salary_clearBtn.Size = new System.Drawing.Size(301, 62);
            this.salary_clearBtn.TabIndex = 17;
            this.salary_clearBtn.Text = "CLEAR";
            this.salary_clearBtn.UseVisualStyleBackColor = false;
            this.salary_clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // salary_position
            // 
            this.salary_position.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_position.FormattingEnabled = true;
            this.salary_position.Items.AddRange(new object[] {
            "Back-end developer",
            "Cloud/software architect",
            "Cloud/software developer",
            "Cloud/software applications engineer",
            "Cloud system administrator",
            "Cloud system engineer",
            "DevOps engineer",
            "Front-end developer",
            "Full-stack developer",
            "Java developer",
            "Platform engineer",
            "Release manager",
            "Reliability engineer",
            "Software engineer",
            "Software quality assurance analyst",
            "UI (user interface) designer",
            "UX (user experience) designer",
            "Web developer",
            "Computer systems manager",
            "Network architect",
            "Systems analyst",
            "IT coordinator",
            "Network administrator",
            "Network engineer",
            "Service desk analyst",
            "System administrator (also known as sysadmin)",
            "Wireless network engineer",
            "Database administrator",
            "Database analyst",
            "Data quality manager",
            "Database report writer",
            "SQL database administrator",
            "Big data engineer/architect",
            "Business intelligence specialist/analyst",
            "Business systems analyst",
            "Data analyst",
            "Data analytics developer",
            "Data modeling analyst",
            "Data scientist",
            "Data warehouse manager",
            "Data warehouse programming specialist",
            "Intelligence specialist",
            "Back-end developer",
            "Cloud/software architect",
            "Cloud/software developer",
            "Cloud/software applications engineer",
            "Cloud system administrator",
            "Cloud system engineer",
            "DevOps engineer",
            "Front-end developer",
            "Full-stack developer",
            "Java developer",
            "Platform engineer",
            "Release manager",
            "Reliability engineer",
            "Software engineer",
            "Software quality assurance analyst",
            "UI (user interface) designer",
            "UX (user experience) designer",
            "Web developer",
            "Application security administrator",
            "Artificial intelligence security specialist",
            "Cloud security specialist",
            "Cybersecurity hardware engineer",
            "Cyberintelligence specialist",
            "Cryptographer",
            "Data privacy officer",
            "Digital forensics analyst",
            "IT security engineer",
            "Information assurance analyst",
            "Security systems administrator",
            "Help desk support specialist",
            "IT support specialist",
            "Customer service representative",
            "Technical product manager",
            "Product manager",
            "Project manager",
            "Program manager",
            "Portfolio manager",
            "Back-end Developer",
            "Database engineer"});
            this.salary_position.Location = new System.Drawing.Point(36, 361);
            this.salary_position.Name = "salary_position";
            this.salary_position.Size = new System.Drawing.Size(301, 31);
            this.salary_position.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(4)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(30, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "ENTER THE DETAILS OF THE EMPLOYEE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Workforce_.Properties.Resources.Rupee;
            this.pictureBox1.Location = new System.Drawing.Point(664, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 142);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salary_position);
            this.Controls.Add(this.salary_clearBtn);
            this.Controls.Add(this.salary_salary);
            this.Controls.Add(this.salary_updateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salary_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salary_employeeID);
            this.Controls.Add(this.label1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(830, 553);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLQuery1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox salary_employeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salary_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salary_clearBtn;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private SQLQuery1DataSet1 sQLQuery1DataSet1;
        private SQLQuery1DataSet1TableAdapters.employeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ComboBox salary_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
