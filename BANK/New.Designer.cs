namespace BANK
{
    partial class NEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NEW));
            this.first_txt = new System.Windows.Forms.TextBox();
            this.last_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.bal_txt = new System.Windows.Forms.TextBox();
            this.job_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.country_txt = new System.Windows.Forms.TextBox();
            this.monthly_txt = new System.Windows.Forms.TextBox();
            this.information_group = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.DOB_picker = new System.Windows.Forms.DateTimePicker();
            this.MALE = new System.Windows.Forms.RadioButton();
            this.FEMALE = new System.Windows.Forms.RadioButton();
            this.social_combo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.retu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.information_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // first_txt
            // 
            this.first_txt.Location = new System.Drawing.Point(176, 32);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(377, 26);
            this.first_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.first_txt, "Enter client\'s first name");
            this.first_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // last_txt
            // 
            this.last_txt.Location = new System.Drawing.Point(176, 64);
            this.last_txt.Name = "last_txt";
            this.last_txt.Size = new System.Drawing.Size(377, 26);
            this.last_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.last_txt, "Enter client\'s last name");
            this.last_txt.TextChanged += new System.EventHandler(this.last_txt_TextChanged);
            this.last_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(176, 96);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(377, 26);
            this.natid_txt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.natid_txt, "Enter client\'s national ID in the right format which consist of 14 digit");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(176, 225);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(377, 26);
            this.phone_txt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.phone_txt, "Enter client\'s phone number");
            this.phone_txt.TextChanged += new System.EventHandler(this.phone_txt_TextChanged);
            this.phone_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // bal_txt
            // 
            this.bal_txt.Location = new System.Drawing.Point(176, 387);
            this.bal_txt.Name = "bal_txt";
            this.bal_txt.Size = new System.Drawing.Size(377, 26);
            this.bal_txt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bal_txt, "Enter client\'s beginig balance to create new account and the minimum value is 100" +
        "0");
            this.bal_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.bal_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // job_txt
            // 
            this.job_txt.Location = new System.Drawing.Point(176, 323);
            this.job_txt.Name = "job_txt";
            this.job_txt.Size = new System.Drawing.Size(377, 26);
            this.job_txt.TabIndex = 6;
            this.toolTip1.SetToolTip(this.job_txt, "Enter client\'s current job");
            this.job_txt.TextChanged += new System.EventHandler(this.job_txt_TextChanged);
            this.job_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(176, 257);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(377, 26);
            this.address_txt.TabIndex = 7;
            this.toolTip1.SetToolTip(this.address_txt, "Enter client\'s address");
            this.address_txt.TextChanged += new System.EventHandler(this.address_txt_TextChanged);
            this.address_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // country_txt
            // 
            this.country_txt.AutoCompleteCustomSource.AddRange(new string[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (see Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.country_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.country_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.country_txt.Location = new System.Drawing.Point(176, 193);
            this.country_txt.Name = "country_txt";
            this.country_txt.Size = new System.Drawing.Size(377, 26);
            this.country_txt.TabIndex = 8;
            this.toolTip1.SetToolTip(this.country_txt, "Enter client\'s original country");
            this.country_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // monthly_txt
            // 
            this.monthly_txt.Location = new System.Drawing.Point(176, 355);
            this.monthly_txt.Name = "monthly_txt";
            this.monthly_txt.Size = new System.Drawing.Size(377, 26);
            this.monthly_txt.TabIndex = 9;
            this.toolTip1.SetToolTip(this.monthly_txt, "Enter client\'s monthly payment and the minimum value is 1500");
            this.monthly_txt.TextChanged += new System.EventHandler(this.monthly_txt_TextChanged);
            this.monthly_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.monthly_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // information_group
            // 
            this.information_group.BackColor = System.Drawing.Color.Transparent;
            this.information_group.Controls.Add(this.monthly_txt);
            this.information_group.Controls.Add(this.label28);
            this.information_group.Controls.Add(this.label19);
            this.information_group.Controls.Add(this.DOB_picker);
            this.information_group.Controls.Add(this.MALE);
            this.information_group.Controls.Add(this.FEMALE);
            this.information_group.Controls.Add(this.country_txt);
            this.information_group.Controls.Add(this.label26);
            this.information_group.Controls.Add(this.social_combo);
            this.information_group.Controls.Add(this.label15);
            this.information_group.Controls.Add(this.label16);
            this.information_group.Controls.Add(this.label18);
            this.information_group.Controls.Add(this.address_txt);
            this.information_group.Controls.Add(this.job_txt);
            this.information_group.Controls.Add(this.bal_txt);
            this.information_group.Controls.Add(this.phone_txt);
            this.information_group.Controls.Add(this.natid_txt);
            this.information_group.Controls.Add(this.label20);
            this.information_group.Controls.Add(this.last_txt);
            this.information_group.Controls.Add(this.label22);
            this.information_group.Controls.Add(this.label23);
            this.information_group.Controls.Add(this.first_txt);
            this.information_group.Controls.Add(this.label24);
            this.information_group.Controls.Add(this.label25);
            this.information_group.Controls.Add(this.label27);
            this.information_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.information_group.Location = new System.Drawing.Point(24, 108);
            this.information_group.Name = "information_group";
            this.information_group.Size = new System.Drawing.Size(592, 449);
            this.information_group.TabIndex = 32;
            this.information_group.TabStop = false;
            this.information_group.Text = "Client Info.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(7, 358);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(155, 20);
            this.label28.TabIndex = 21;
            this.label28.Text = "Monthly Payment :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(8, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "Gender";
            // 
            // DOB_picker
            // 
            this.DOB_picker.CalendarForeColor = System.Drawing.Color.Black;
            this.DOB_picker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.DOB_picker.CustomFormat = "yyyy-MM-dd";
            this.DOB_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB_picker.Location = new System.Drawing.Point(176, 128);
            this.DOB_picker.Name = "DOB_picker";
            this.DOB_picker.Size = new System.Drawing.Size(377, 26);
            this.DOB_picker.TabIndex = 31;
            this.toolTip1.SetToolTip(this.DOB_picker, "Enter client\'s birthday");
            this.DOB_picker.ValueChanged += new System.EventHandler(this.DOB_picker_ValueChanged);
            this.DOB_picker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // MALE
            // 
            this.MALE.AutoSize = true;
            this.MALE.BackColor = System.Drawing.Color.Transparent;
            this.MALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MALE.ForeColor = System.Drawing.Color.Black;
            this.MALE.Location = new System.Drawing.Point(214, 163);
            this.MALE.Name = "MALE";
            this.MALE.Size = new System.Drawing.Size(65, 24);
            this.MALE.TabIndex = 41;
            this.MALE.TabStop = true;
            this.MALE.Text = "Male";
            this.MALE.UseVisualStyleBackColor = false;
            // 
            // FEMALE
            // 
            this.FEMALE.AutoSize = true;
            this.FEMALE.BackColor = System.Drawing.Color.Transparent;
            this.FEMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FEMALE.ForeColor = System.Drawing.Color.Black;
            this.FEMALE.Location = new System.Drawing.Point(428, 163);
            this.FEMALE.Name = "FEMALE";
            this.FEMALE.Size = new System.Drawing.Size(86, 24);
            this.FEMALE.TabIndex = 42;
            this.FEMALE.TabStop = true;
            this.FEMALE.Text = "Female";
            this.FEMALE.UseVisualStyleBackColor = false;
            // 
            // social_combo
            // 
            this.social_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.social_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.social_combo.FormattingEnabled = true;
            this.social_combo.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Widowed"});
            this.social_combo.Location = new System.Drawing.Point(176, 289);
            this.social_combo.Name = "social_combo";
            this.social_combo.Size = new System.Drawing.Size(377, 28);
            this.social_combo.TabIndex = 30;
            this.toolTip1.SetToolTip(this.social_combo, "Enter client\'s current civil status");
            this.social_combo.Click += new System.EventHandler(this.dropdownclick);
            this.social_combo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dropdownspace);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(8, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Address : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "First Name : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "Last Name : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(6, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "National ID : ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(8, 228);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Phone :";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(8, 390);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 20);
            this.label23.TabIndex = 17;
            this.label23.Text = "Open. Balance :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(6, 326);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 20);
            this.label24.TabIndex = 18;
            this.label24.Text = "client\'s Job :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(8, 133);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 20);
            this.label25.TabIndex = 23;
            this.label25.Text = "Birth Date : ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(6, 196);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 20);
            this.label26.TabIndex = 20;
            this.label26.Text = "Country : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(7, 292);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 20);
            this.label27.TabIndex = 22;
            this.label27.Text = "Status : ";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.create.FlatAppearance.BorderSize = 2;
            this.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Navy;
            this.create.Location = new System.Drawing.Point(270, 572);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(91, 36);
            this.create.TabIndex = 33;
            this.create.Text = "Create";
            this.toolTip1.SetToolTip(this.create, "Create the new account of the client");
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // retu
            // 
            this.retu.BackColor = System.Drawing.Color.Transparent;
            this.retu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retu.FlatAppearance.BorderSize = 0;
            this.retu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retu.Image = global::BANK.Properties.Resources.undo_icon;
            this.retu.Location = new System.Drawing.Point(584, 567);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(54, 47);
            this.retu.TabIndex = 36;
            this.toolTip1.SetToolTip(this.retu, "To return to the previous window");
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(-90, 640);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 150);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Info.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 55;
            this.label1.Text = "New Client ";
            // 
            // NEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.information_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NEW_FormClosing);
            this.Load += new System.EventHandler(this.NEW_Load_1);
            this.information_group.ResumeLayout(false);
            this.information_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_txt;
        private System.Windows.Forms.TextBox last_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox bal_txt;
        private System.Windows.Forms.TextBox job_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox country_txt;
        private System.Windows.Forms.TextBox monthly_txt;
        private System.Windows.Forms.GroupBox information_group;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.DateTimePicker DOB_picker;
        private System.Windows.Forms.ComboBox social_combo;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton MALE;
        private System.Windows.Forms.RadioButton FEMALE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

