namespace BANK
{
    partial class GetLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetLoan));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.get = new System.Windows.Forms.Button();
            this.retu = new System.Windows.Forms.Button();
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.branch_combo = new System.Windows.Forms.ComboBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.info_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(41, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 42);
            this.label5.TabIndex = 61;
            this.label5.Text = "Get Loan";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // get
            // 
            this.get.BackColor = System.Drawing.Color.Transparent;
            this.get.Cursor = System.Windows.Forms.Cursors.Hand;
            this.get.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.get.FlatAppearance.BorderSize = 2;
            this.get.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.get.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get.ForeColor = System.Drawing.Color.Navy;
            this.get.Location = new System.Drawing.Point(260, 568);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(100, 39);
            this.get.TabIndex = 59;
            this.get.Text = "Get";
            this.get.UseVisualStyleBackColor = false;
            this.get.Click += new System.EventHandler(this.get_Click);
            // 
            // retu
            // 
            this.retu.BackColor = System.Drawing.Color.Transparent;
            this.retu.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.retu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retu.FlatAppearance.BorderSize = 0;
            this.retu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retu.Location = new System.Drawing.Point(587, 562);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(51, 52);
            this.retu.TabIndex = 58;
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // info_groupbox
            // 
            this.info_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.info_groupbox.Controls.Add(this.branch_combo);
            this.info_groupbox.Controls.Add(this.date_picker);
            this.info_groupbox.Controls.Add(this.type_combo);
            this.info_groupbox.Controls.Add(this.label4);
            this.info_groupbox.Controls.Add(this.label6);
            this.info_groupbox.Controls.Add(this.amount_txt);
            this.info_groupbox.Controls.Add(this.label3);
            this.info_groupbox.Controls.Add(this.cid_txt);
            this.info_groupbox.Controls.Add(this.label2);
            this.info_groupbox.Controls.Add(this.label1);
            this.info_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.info_groupbox.Location = new System.Drawing.Point(48, 153);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(557, 323);
            this.info_groupbox.TabIndex = 57;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "Loan Info.";
            // 
            // branch_combo
            // 
            this.branch_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.branch_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.branch_combo.FormattingEnabled = true;
            this.branch_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.branch_combo.Location = new System.Drawing.Point(143, 247);
            this.branch_combo.Name = "branch_combo";
            this.branch_combo.Size = new System.Drawing.Size(390, 28);
            this.branch_combo.TabIndex = 34;
            this.branch_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // date_picker
            // 
            this.date_picker.CalendarForeColor = System.Drawing.Color.Black;
            this.date_picker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.date_picker.CustomFormat = "yyyy-MM-dd";
            this.date_picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker.Location = new System.Drawing.Point(143, 203);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(390, 26);
            this.date_picker.TabIndex = 33;
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // type_combo
            // 
            this.type_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.type_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "Mortgage Loan",
            "Auto Loan",
            "Durable Good Loan",
            "Personal Loan",
            "Tourism Loan",
            "Hajj and Umrah Loan",
            "Education Loan"});
            this.type_combo.Location = new System.Drawing.Point(143, 114);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(390, 28);
            this.type_combo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(23, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Branch No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date : ";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(143, 158);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(390, 26);
            this.amount_txt.TabIndex = 5;
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount : ";
            // 
            // cid_txt
            // 
            this.cid_txt.Location = new System.Drawing.Point(143, 72);
            this.cid_txt.Name = "cid_txt";
            this.cid_txt.Size = new System.Drawing.Size(390, 26);
            this.cid_txt.TabIndex = 2;
            this.cid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID : ";
            // 
            // GetLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.info_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetLoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetLoan_FormClosing);
            this.Load += new System.EventHandler(this.GetLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cid_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.ComboBox branch_combo;
    }
}