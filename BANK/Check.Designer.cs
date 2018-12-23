namespace BANK
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.natid_groupbox = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bal_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.last_txt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.first_txt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.check_1 = new System.Windows.Forms.Button();
            this.retu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.natid_groupbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // natid_groupbox
            // 
            this.natid_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.natid_groupbox.Controls.Add(this.label20);
            this.natid_groupbox.Controls.Add(this.natid_txt);
            this.natid_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natid_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.natid_groupbox.Location = new System.Drawing.Point(47, 171);
            this.natid_groupbox.Name = "natid_groupbox";
            this.natid_groupbox.Size = new System.Drawing.Size(553, 111);
            this.natid_groupbox.TabIndex = 0;
            this.natid_groupbox.TabStop = false;
            this.natid_groupbox.Text = "client\'s ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(15, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "National ID : ";
            // 
            // natid_txt
            // 
            this.natid_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natid_txt.Location = new System.Drawing.Point(135, 52);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(386, 26);
            this.natid_txt.TabIndex = 30;
            this.toolTip1.SetToolTip(this.natid_txt, "Client\'s national ID which is 14 digit number");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.bal_txt);
            this.groupBox2.Controls.Add(this.phone_txt);
            this.groupBox2.Controls.Add(this.last_txt);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.first_txt);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(47, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "client\'s Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "First Name : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(15, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 20);
            this.label18.TabIndex = 34;
            this.label18.Text = "Last Name : ";
            // 
            // bal_txt
            // 
            this.bal_txt.Enabled = false;
            this.bal_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bal_txt.Location = new System.Drawing.Point(135, 122);
            this.bal_txt.Name = "bal_txt";
            this.bal_txt.Size = new System.Drawing.Size(385, 26);
            this.bal_txt.TabIndex = 32;
            this.toolTip1.SetToolTip(this.bal_txt, "client\'s balance ");
            // 
            // phone_txt
            // 
            this.phone_txt.Enabled = false;
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(136, 154);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(385, 26);
            this.phone_txt.TabIndex = 31;
            this.toolTip1.SetToolTip(this.phone_txt, "client\'s phone number");
            this.phone_txt.TextChanged += new System.EventHandler(this.phone_txt_TextChanged);
            this.phone_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.phone_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // last_txt
            // 
            this.last_txt.Enabled = false;
            this.last_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_txt.Location = new System.Drawing.Point(135, 90);
            this.last_txt.Name = "last_txt";
            this.last_txt.Size = new System.Drawing.Size(385, 26);
            this.last_txt.TabIndex = 29;
            this.toolTip1.SetToolTip(this.last_txt, "client\'s last name");
            this.last_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(15, 157);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 20);
            this.label22.TabIndex = 36;
            this.label22.Text = "Phone : ";
            // 
            // first_txt
            // 
            this.first_txt.Enabled = false;
            this.first_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_txt.Location = new System.Drawing.Point(134, 58);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(386, 26);
            this.first_txt.TabIndex = 28;
            this.toolTip1.SetToolTip(this.first_txt, "Client\'s first name");
            this.first_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(15, 125);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 20);
            this.label23.TabIndex = 37;
            this.label23.Text = "Balance : ";
            // 
            // check_1
            // 
            this.check_1.BackColor = System.Drawing.Color.Transparent;
            this.check_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.check_1.FlatAppearance.BorderSize = 2;
            this.check_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.check_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_1.ForeColor = System.Drawing.Color.Navy;
            this.check_1.Location = new System.Drawing.Point(271, 568);
            this.check_1.Name = "check_1";
            this.check_1.Size = new System.Drawing.Size(85, 40);
            this.check_1.TabIndex = 2;
            this.check_1.Text = "Check";
            this.toolTip1.SetToolTip(this.check_1, "Check national ID and show information of the client");
            this.check_1.UseVisualStyleBackColor = false;
            this.check_1.Click += new System.EventHandler(this.check_1_Click);
            // 
            // retu
            // 
            this.retu.BackColor = System.Drawing.Color.Transparent;
            this.retu.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.retu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retu.FlatAppearance.BorderSize = 0;
            this.retu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retu.Location = new System.Drawing.Point(590, 565);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(48, 49);
            this.retu.TabIndex = 3;
            this.toolTip1.SetToolTip(this.retu, "Return to the previous window");
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 58;
            this.label1.Text = "Check Client ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.check_1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.natid_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Check_FormClosing);
            this.Load += new System.EventHandler(this.Check_Load);
            this.natid_groupbox.ResumeLayout(false);
            this.natid_groupbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox natid_groupbox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bal_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox last_txt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox first_txt;
        private System.Windows.Forms.Button check_1;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}