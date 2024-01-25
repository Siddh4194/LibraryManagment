namespace Libraryproject
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label staff_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label designationLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label16;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Libraryproject.libraryDataSet();
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.staff_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.staffTableAdapter = new Libraryproject.libraryDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new Libraryproject.libraryDataSetTableAdapters.TableAdapterManager();
            this.modal_effect = new System.Windows.Forms.Timer(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            staff_IDLabel = new System.Windows.Forms.Label();
            staff_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            staff_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            staff_IDLabel.Location = new System.Drawing.Point(69, 69);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(47, 11);
            staff_IDLabel.TabIndex = 8;
            staff_IDLabel.Text = "staff ID:";
            // 
            // staff_nameLabel
            // 
            staff_nameLabel.AutoSize = true;
            staff_nameLabel.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            staff_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            staff_nameLabel.Location = new System.Drawing.Point(57, 100);
            staff_nameLabel.Name = "staff_nameLabel";
            staff_nameLabel.Size = new System.Drawing.Size(63, 11);
            staff_nameLabel.TabIndex = 10;
            staff_nameLabel.Text = "staff name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            passwordLabel.Location = new System.Drawing.Point(61, 135);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(59, 11);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            designationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            designationLabel.Location = new System.Drawing.Point(50, 197);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(71, 11);
            designationLabel.TabIndex = 14;
            designationLabel.Text = "Designation:";
            designationLabel.Click += new System.EventHandler(this.designationLabel_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label8.Location = new System.Drawing.Point(13, 164);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(107, 11);
            label8.TabIndex = 16;
            label8.Text = "Conform password:";
            label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ForeColor = System.Drawing.Color.Crimson;
            label16.Location = new System.Drawing.Point(67, 29);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(142, 21);
            label16.TabIndex = 22;
            label16.Text = "Insert Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.guna2TileButton1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(304, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 316);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_2);
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.BorderRadius = 10;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.Maroon;
            this.guna2TileButton1.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2TileButton1.Location = new System.Drawing.Point(92, 156);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(118, 34);
            this.guna2TileButton1.TabIndex = 15;
            this.guna2TileButton1.Text = "Verify";
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 11);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resend";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(118, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(134, 14);
            this.textBox3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 11);
            this.label5.TabIndex = 6;
            this.label5.Text = "Access Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(116, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 11);
            this.label6.TabIndex = 4;
            this.label6.Text = "Verification";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(117, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "__________________________";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(118, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.guna2TileButton3);
            this.panel3.Controls.Add(label16);
            this.panel3.Controls.Add(label8);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(staff_IDLabel);
            this.panel3.Controls.Add(this.staff_IDTextBox);
            this.panel3.Controls.Add(staff_nameLabel);
            this.panel3.Controls.Add(this.staff_nameTextBox);
            this.panel3.Controls.Add(passwordLabel);
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(designationLabel);
            this.panel3.Controls.Add(this.designationTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(293, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 330);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton3.BorderRadius = 10;
            this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton3.FillColor = System.Drawing.Color.Maroon;
            this.guna2TileButton3.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2TileButton3.Location = new System.Drawing.Point(81, 250);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.Size = new System.Drawing.Size(118, 34);
            this.guna2TileButton3.TabIndex = 23;
            this.guna2TileButton3.Text = "LogIn";
            this.guna2TileButton3.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "password", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox4.Location = new System.Drawing.Point(124, 157);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 14);
            this.textBox4.TabIndex = 17;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.staff_IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "staff_ID", true));
            this.staff_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_IDTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.staff_IDTextBox.Location = new System.Drawing.Point(124, 59);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(130, 14);
            this.staff_IDTextBox.TabIndex = 9;
            // 
            // staff_nameTextBox
            // 
            this.staff_nameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.staff_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staff_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "staff_name", true));
            this.staff_nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_nameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.staff_nameTextBox.Location = new System.Drawing.Point(123, 92);
            this.staff_nameTextBox.Name = "staff_nameTextBox";
            this.staff_nameTextBox.Size = new System.Drawing.Size(131, 14);
            this.staff_nameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordTextBox.Location = new System.Drawing.Point(123, 125);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(131, 14);
            this.passwordTextBox.TabIndex = 13;
            // 
            // designationTextBox
            // 
            this.designationTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.designationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Designation", true));
            this.designationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.designationTextBox.Location = new System.Drawing.Point(123, 188);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(131, 14);
            this.designationTextBox.TabIndex = 15;
            this.designationTextBox.TextChanged += new System.EventHandler(this.designationTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(122, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "__________________________";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(120, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "__________________________";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(120, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "__________________________";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(119, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "__________________________";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(122, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "__________________________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.guna2TileButton2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(289, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 316);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderRadius = 10;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.Maroon;
            this.guna2TileButton2.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2TileButton2.Location = new System.Drawing.Point(68, 244);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(118, 34);
            this.guna2TileButton2.TabIndex = 16;
            this.guna2TileButton2.Text = "LogIn";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Libraryproject.Properties.Resources.user__6_;
            this.pictureBox2.Location = new System.Drawing.Point(108, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(103, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sign in";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(108, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(133, 14);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 11);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(43, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 11);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(108, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 14);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(106, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "__________________________";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cooper Black", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(106, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "__________________________";
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.availablebookTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BorrowerTableAdapter = null;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.newbookTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.studentdataTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Libraryproject.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // modal_effect
            // 
            this.modal_effect.Enabled = true;
            this.modal_effect.Interval = 1;
            this.modal_effect.Tick += new System.EventHandler(this.modal_effect_Tick);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Libraryproject.Properties.Resources.image__2_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(85, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(564, 368);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Opacity = 0D;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Enter += new System.EventHandler(this.button1_Click_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private libraryDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox staff_IDTextBox;
        private System.Windows.Forms.TextBox staff_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private System.Windows.Forms.Timer modal_effect;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}