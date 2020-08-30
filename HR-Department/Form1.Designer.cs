namespace HR_Department
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.компаніяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCompanyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepartmentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.співробітникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEmploymentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelEmploymentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditEmploymentItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Captions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmployeesList = new System.Windows.Forms.ListBox();
            this.DepartmentsList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExperField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BirthField = new System.Windows.Forms.DateTimePicker();
            this.SalaryField = new System.Windows.Forms.TextBox();
            this.MoneyField = new System.Windows.Forms.Label();
            this.PosField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SpecField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компаніяToolStripMenuItem,
            this.DepartmentItem,
            this.співробітникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // компаніяToolStripMenuItem
            // 
            this.компаніяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCompanyItem});
            this.компаніяToolStripMenuItem.Name = "компаніяToolStripMenuItem";
            this.компаніяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.компаніяToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.компаніяToolStripMenuItem.Text = "Компанія";
            // 
            // EditCompanyItem
            // 
            this.EditCompanyItem.Name = "EditCompanyItem";
            this.EditCompanyItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditCompanyItem.Size = new System.Drawing.Size(159, 22);
            this.EditCompanyItem.Text = "Змінити";
            // 
            // DepartmentItem
            // 
            this.DepartmentItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDepartmentItem,
            this.DelDepartmentItem,
            this.EditDepartmentItem});
            this.DepartmentItem.Name = "DepartmentItem";
            this.DepartmentItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DepartmentItem.Size = new System.Drawing.Size(98, 20);
            this.DepartmentItem.Text = "Департаменти";
            // 
            // AddDepartmentItem
            // 
            this.AddDepartmentItem.Name = "AddDepartmentItem";
            this.AddDepartmentItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AddDepartmentItem.Size = new System.Drawing.Size(166, 22);
            this.AddDepartmentItem.Text = "Додати";
            this.AddDepartmentItem.Click += new System.EventHandler(this.AddDepartmentItem_Click);
            // 
            // DelDepartmentItem
            // 
            this.DelDepartmentItem.Name = "DelDepartmentItem";
            this.DelDepartmentItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.DelDepartmentItem.Size = new System.Drawing.Size(166, 22);
            this.DelDepartmentItem.Text = "Видалити";
            this.DelDepartmentItem.Click += new System.EventHandler(this.DelDepartmentItem_Click);
            // 
            // EditDepartmentItem
            // 
            this.EditDepartmentItem.Name = "EditDepartmentItem";
            this.EditDepartmentItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EditDepartmentItem.Size = new System.Drawing.Size(166, 22);
            this.EditDepartmentItem.Text = "Змінити";
            this.EditDepartmentItem.Click += new System.EventHandler(this.EditDepartmentItem_Click);
            // 
            // співробітникиToolStripMenuItem
            // 
            this.співробітникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEmploymentItem,
            this.DelEmploymentItem,
            this.EditEmploymentItem});
            this.співробітникиToolStripMenuItem.Name = "співробітникиToolStripMenuItem";
            this.співробітникиToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.співробітникиToolStripMenuItem.Text = "Співробітники";
            // 
            // AddEmploymentItem
            // 
            this.AddEmploymentItem.Name = "AddEmploymentItem";
            this.AddEmploymentItem.Size = new System.Drawing.Size(126, 22);
            this.AddEmploymentItem.Text = "Додати";
            // 
            // DelEmploymentItem
            // 
            this.DelEmploymentItem.Name = "DelEmploymentItem";
            this.DelEmploymentItem.Size = new System.Drawing.Size(126, 22);
            this.DelEmploymentItem.Text = "Видалити";
            // 
            // EditEmploymentItem
            // 
            this.EditEmploymentItem.Name = "EditEmploymentItem";
            this.EditEmploymentItem.Size = new System.Drawing.Size(126, 22);
            this.EditEmploymentItem.Text = "Змінити";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Captions);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 104);
            this.panel1.TabIndex = 2;
            // 
            // Captions
            // 
            this.Captions.AutoSize = true;
            this.Captions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Captions.ForeColor = System.Drawing.Color.DarkCyan;
            this.Captions.Location = new System.Drawing.Point(299, 38);
            this.Captions.Name = "Captions";
            this.Captions.Size = new System.Drawing.Size(373, 29);
            this.Captions.TabIndex = 1;
            this.Captions.Text = "Віділ кадрів компанії \"Business\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HR_Department.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeesList);
            this.groupBox1.Controls.Add(this.DepartmentsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 560);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Департаменти";
            // 
            // EmployeesList
            // 
            this.EmployeesList.FormattingEnabled = true;
            this.EmployeesList.ItemHeight = 16;
            this.EmployeesList.Location = new System.Drawing.Point(13, 52);
            this.EmployeesList.Name = "EmployeesList";
            this.EmployeesList.Size = new System.Drawing.Size(219, 500);
            this.EmployeesList.TabIndex = 1;
            this.EmployeesList.SelectedIndexChanged += new System.EventHandler(this.EmployeesList_SelectedIndexChanged);
            // 
            // DepartmentsList
            // 
            this.DepartmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentsList.FormattingEnabled = true;
            this.DepartmentsList.Location = new System.Drawing.Point(6, 21);
            this.DepartmentsList.Name = "DepartmentsList";
            this.DepartmentsList.Size = new System.Drawing.Size(226, 24);
            this.DepartmentsList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExperField);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BirthField);
            this.groupBox2.Controls.Add(this.SalaryField);
            this.groupBox2.Controls.Add(this.MoneyField);
            this.groupBox2.Controls.Add(this.PosField);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SpecField);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PhoneField);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EmailField);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NameField);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(609, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 560);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персональна Інформація";
            // 
            // ExperField
            // 
            this.ExperField.Location = new System.Drawing.Point(10, 442);
            this.ExperField.Name = "ExperField";
            this.ExperField.ReadOnly = true;
            this.ExperField.Size = new System.Drawing.Size(240, 22);
            this.ExperField.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(7, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Стаж";
            // 
            // BirthField
            // 
            this.BirthField.Location = new System.Drawing.Point(10, 93);
            this.BirthField.Name = "BirthField";
            this.BirthField.Size = new System.Drawing.Size(240, 22);
            this.BirthField.TabIndex = 14;
            // 
            // SalaryField
            // 
            this.SalaryField.Location = new System.Drawing.Point(10, 382);
            this.SalaryField.Name = "SalaryField";
            this.SalaryField.ReadOnly = true;
            this.SalaryField.Size = new System.Drawing.Size(240, 22);
            this.SalaryField.TabIndex = 13;
            // 
            // MoneyField
            // 
            this.MoneyField.AutoSize = true;
            this.MoneyField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyField.ForeColor = System.Drawing.Color.DarkBlue;
            this.MoneyField.Location = new System.Drawing.Point(7, 362);
            this.MoneyField.Name = "MoneyField";
            this.MoneyField.Size = new System.Drawing.Size(56, 16);
            this.MoneyField.TabIndex = 12;
            this.MoneyField.Text = "Платня";
            // 
            // PosField
            // 
            this.PosField.Location = new System.Drawing.Point(6, 321);
            this.PosField.Name = "PosField";
            this.PosField.ReadOnly = true;
            this.PosField.Size = new System.Drawing.Size(240, 22);
            this.PosField.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(7, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Посада";
            // 
            // SpecField
            // 
            this.SpecField.Location = new System.Drawing.Point(6, 264);
            this.SpecField.Name = "SpecField";
            this.SpecField.ReadOnly = true;
            this.SpecField.Size = new System.Drawing.Size(240, 22);
            this.SpecField.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(7, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cпеціальність";
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(10, 201);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.ReadOnly = true;
            this.PhoneField.Size = new System.Drawing.Size(240, 22);
            this.PhoneField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(7, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата народження";
            // 
            // EmailField
            // 
            this.EmailField.Location = new System.Drawing.Point(10, 148);
            this.EmailField.Name = "EmailField";
            this.EmailField.ReadOnly = true;
            this.EmailField.Size = new System.Drawing.Size(240, 22);
            this.EmailField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(10, 41);
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(240, 22);
            this.NameField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Призвіще,Ім\'я";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PhotoBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(232, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 560);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото співробітника";
            // 
            // PhotoBox
            // 
            this.PhotoBox.Image = global::HR_Department.Properties.Resources.Logo1;
            this.PhotoBox.Location = new System.Drawing.Point(6, 17);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(364, 531);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 688);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cистема керування віділом кадрів компанії";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem компаніяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditCompanyItem;
        private System.Windows.Forms.ToolStripMenuItem DepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem DelDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem EditDepartmentItem;
        private System.Windows.Forms.ToolStripMenuItem співробітникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddEmploymentItem;
        private System.Windows.Forms.ToolStripMenuItem DelEmploymentItem;
        private System.Windows.Forms.ToolStripMenuItem EditEmploymentItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Captions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DepartmentsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox EmployeesList;
        private System.Windows.Forms.TextBox ExperField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker BirthField;
        private System.Windows.Forms.TextBox SalaryField;
        private System.Windows.Forms.Label MoneyField;
        private System.Windows.Forms.TextBox PosField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SpecField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PhotoBox;
    }
}

