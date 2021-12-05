
namespace TCamaleonApp.Views
{
    partial class EmployeeSearcher
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
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            this.txt_employeeS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modify = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.rbtn_fired = new System.Windows.Forms.RadioButton();
            this.rbtn_vac = new System.Windows.Forms.RadioButton();
            this.rbtn_working = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_job = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_categories = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_name4 = new System.Windows.Forms.TextBox();
            this.txt_name3 = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_job = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_employees
            // 
            this.dgv_employees.AllowUserToResizeColumns = false;
            this.dgv_employees.AllowUserToResizeRows = false;
            this.dgv_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_employees.Location = new System.Drawing.Point(0, 0);
            this.dgv_employees.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.ReadOnly = true;
            this.dgv_employees.RowHeadersWidth = 51;
            this.dgv_employees.Size = new System.Drawing.Size(977, 626);
            this.dgv_employees.TabIndex = 0;
            this.dgv_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_employees_CellContentClick);
            this.dgv_employees.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_employees_RowHeaderMouseClick);
            // 
            // txt_employeeS
            // 
            this.txt_employeeS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_employeeS.Location = new System.Drawing.Point(61, 57);
            this.txt_employeeS.Margin = new System.Windows.Forms.Padding(4);
            this.txt_employeeS.Name = "txt_employeeS";
            this.txt_employeeS.Size = new System.Drawing.Size(239, 22);
            this.txt_employeeS.TabIndex = 1;
            this.txt_employeeS.TextChanged += new System.EventHandler(this.txt_employeeS_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduzca dato a buscar:";
            // 
            // btn_modify
            // 
            this.btn_modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_modify.Enabled = false;
            this.btn_modify.Location = new System.Drawing.Point(12, 26);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(173, 46);
            this.btn_modify.TabIndex = 3;
            this.btn_modify.Text = "Modificar información";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.modify_option);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(21, 694);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nuevo empleado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(719, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(565, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtro de búsqueda";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cargo:";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_save.Enabled = false;
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(184, 694);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(135, 46);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Guardar empleado";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.cb_job);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.rbtn_fired);
            this.panel1.Controls.Add(this.rbtn_vac);
            this.panel1.Controls.Add(this.rbtn_working);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cmb_job);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmb_categories);
            this.panel1.Controls.Add(this.txt_Address);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.txt_mail);
            this.panel1.Controls.Add(this.txt_name4);
            this.panel1.Controls.Add(this.txt_name3);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_name2);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.panel1.Location = new System.Drawing.Point(977, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 804);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 601);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Estado:";
            // 
            // rbtn_fired
            // 
            this.rbtn_fired.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_fired.AutoSize = true;
            this.rbtn_fired.Enabled = false;
            this.rbtn_fired.ForeColor = System.Drawing.Color.Black;
            this.rbtn_fired.Location = new System.Drawing.Point(347, 644);
            this.rbtn_fired.Name = "rbtn_fired";
            this.rbtn_fired.Size = new System.Drawing.Size(97, 21);
            this.rbtn_fired.TabIndex = 55;
            this.rbtn_fired.TabStop = true;
            this.rbtn_fired.Text = "Despedido";
            this.rbtn_fired.UseVisualStyleBackColor = true;
            // 
            // rbtn_vac
            // 
            this.rbtn_vac.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_vac.AutoSize = true;
            this.rbtn_vac.Enabled = false;
            this.rbtn_vac.ForeColor = System.Drawing.Color.Black;
            this.rbtn_vac.Location = new System.Drawing.Point(182, 644);
            this.rbtn_vac.Name = "rbtn_vac";
            this.rbtn_vac.Size = new System.Drawing.Size(102, 21);
            this.rbtn_vac.TabIndex = 54;
            this.rbtn_vac.TabStop = true;
            this.rbtn_vac.Text = "Vacaciones";
            this.rbtn_vac.UseVisualStyleBackColor = true;
            // 
            // rbtn_working
            // 
            this.rbtn_working.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_working.AutoSize = true;
            this.rbtn_working.Enabled = false;
            this.rbtn_working.ForeColor = System.Drawing.Color.Black;
            this.rbtn_working.Location = new System.Drawing.Point(24, 644);
            this.rbtn_working.Name = "rbtn_working";
            this.rbtn_working.Size = new System.Drawing.Size(98, 21);
            this.rbtn_working.TabIndex = 53;
            this.rbtn_working.TabStop = true;
            this.rbtn_working.Text = "Laborando";
            this.rbtn_working.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.Location = new System.Drawing.Point(348, 694);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 46);
            this.btn_cancel.TabIndex = 52;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(265, 525);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Puesto:";
            // 
            // cmb_job
            // 
            this.cmb_job.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_job.Enabled = false;
            this.cmb_job.FormattingEnabled = true;
            this.cmb_job.Location = new System.Drawing.Point(266, 553);
            this.cmb_job.Name = "cmb_job";
            this.cmb_job.Size = new System.Drawing.Size(185, 24);
            this.cmb_job.TabIndex = 50;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(267, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Teléfono";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(210, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Cédula:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(23, 525);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 17);
            this.label11.TabIndex = 46;
            this.label11.Text = "Categoría de puesto:";
            // 
            // cmb_categories
            // 
            this.cmb_categories.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categories.Enabled = false;
            this.cmb_categories.FormattingEnabled = true;
            this.cmb_categories.Location = new System.Drawing.Point(23, 553);
            this.cmb_categories.Name = "cmb_categories";
            this.cmb_categories.Size = new System.Drawing.Size(173, 24);
            this.cmb_categories.TabIndex = 45;
            this.cmb_categories.SelectedIndexChanged += new System.EventHandler(this.cmb_categories_SelectedIndexChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_Address.Enabled = false;
            this.txt_Address.Location = new System.Drawing.Point(23, 363);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(422, 115);
            this.txt_Address.TabIndex = 44;
            this.txt_Address.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(20, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(20, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(264, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Segundo apellido:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(265, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Primer apellido:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Segundo nombre:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Primer nombre:";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_phone.Enabled = false;
            this.txt_phone.Location = new System.Drawing.Point(270, 308);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(172, 22);
            this.txt_phone.TabIndex = 36;
            // 
            // txt_mail
            // 
            this.txt_mail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_mail.Enabled = false;
            this.txt_mail.Location = new System.Drawing.Point(23, 308);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(184, 22);
            this.txt_mail.TabIndex = 35;
            // 
            // txt_name4
            // 
            this.txt_name4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name4.Enabled = false;
            this.txt_name4.Location = new System.Drawing.Point(269, 241);
            this.txt_name4.Name = "txt_name4";
            this.txt_name4.Size = new System.Drawing.Size(174, 22);
            this.txt_name4.TabIndex = 34;
            // 
            // txt_name3
            // 
            this.txt_name3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name3.Enabled = false;
            this.txt_name3.Location = new System.Drawing.Point(270, 184);
            this.txt_name3.Name = "txt_name3";
            this.txt_name3.Size = new System.Drawing.Size(174, 22);
            this.txt_name3.TabIndex = 33;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(126, 92);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(240, 22);
            this.txt_id.TabIndex = 32;
            // 
            // txt_name2
            // 
            this.txt_name2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name2.Enabled = false;
            this.txt_name2.Location = new System.Drawing.Point(19, 240);
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(187, 22);
            this.txt_name2.TabIndex = 31;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(20, 184);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(187, 22);
            this.txt_name.TabIndex = 30;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(413, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 17);
            this.label15.TabIndex = 53;
            this.label15.Text = "Cat:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(416, 55);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(116, 24);
            this.comboBox5.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.btn_modify);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 720);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 84);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.txt_employeeS);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(977, 94);
            this.panel3.TabIndex = 55;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_employees);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 626);
            this.panel4.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCamaleonApp.Properties.Resources.Cleaning;
            this.pictureBox1.Location = new System.Drawing.Point(718, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // cb_job
            // 
            this.cb_job.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cb_job.AutoSize = true;
            this.cb_job.BackColor = System.Drawing.Color.Transparent;
            this.cb_job.ForeColor = System.Drawing.Color.Black;
            this.cb_job.Location = new System.Drawing.Point(24, 490);
            this.cb_job.Name = "cb_job";
            this.cb_job.Size = new System.Drawing.Size(134, 21);
            this.cb_job.TabIndex = 57;
            this.cb_job.Text = "Modificar puesto";
            this.cb_job.UseVisualStyleBackColor = false;
            this.cb_job.CheckedChanged += new System.EventHandler(this.cb_job_CheckedChanged);
            // 
            // EmployeeSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1444, 804);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeSearcher";
            this.Text = "EmployeeSearcher";
            this.Load += new System.EventHandler(this.EmployeeSearcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_employees;
        private System.Windows.Forms.TextBox txt_employeeS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_job;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_categories;
        private System.Windows.Forms.RichTextBox txt_Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_name4;
        private System.Windows.Forms.TextBox txt_name3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbtn_fired;
        private System.Windows.Forms.RadioButton rbtn_vac;
        private System.Windows.Forms.RadioButton rbtn_working;
        private System.Windows.Forms.CheckBox cb_job;
    }
}