namespace BANK
{
    partial class viewLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewLoan));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.get = new System.Windows.Forms.Button();
            this.retu = new System.Windows.Forms.Button();
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.branch_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.loans_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cid_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.info_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 42);
            this.label5.TabIndex = 66;
            this.label5.Text = "View Loans";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 65;
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
            this.get.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.get.ForeColor = System.Drawing.Color.Navy;
            this.get.Location = new System.Drawing.Point(267, 249);
            this.get.Name = "get";
            this.get.Size = new System.Drawing.Size(100, 39);
            this.get.TabIndex = 64;
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
            this.retu.TabIndex = 63;
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // info_groupbox
            // 
            this.info_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.info_groupbox.Controls.Add(this.date_txt);
            this.info_groupbox.Controls.Add(this.branch_txt);
            this.info_groupbox.Controls.Add(this.type_txt);
            this.info_groupbox.Controls.Add(this.loans_combo);
            this.info_groupbox.Controls.Add(this.label4);
            this.info_groupbox.Controls.Add(this.label6);
            this.info_groupbox.Controls.Add(this.amount_txt);
            this.info_groupbox.Controls.Add(this.label3);
            this.info_groupbox.Controls.Add(this.label2);
            this.info_groupbox.Controls.Add(this.label1);
            this.info_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.info_groupbox.Location = new System.Drawing.Point(50, 315);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(549, 211);
            this.info_groupbox.TabIndex = 62;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "Loan Info.";
            // 
            // date_txt
            // 
            this.date_txt.Enabled = false;
            this.date_txt.Location = new System.Drawing.Point(131, 129);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(395, 26);
            this.date_txt.TabIndex = 37;
            // 
            // branch_txt
            // 
            this.branch_txt.Enabled = false;
            this.branch_txt.Location = new System.Drawing.Point(131, 161);
            this.branch_txt.Name = "branch_txt";
            this.branch_txt.Size = new System.Drawing.Size(395, 26);
            this.branch_txt.TabIndex = 36;
            // 
            // type_txt
            // 
            this.type_txt.Enabled = false;
            this.type_txt.Location = new System.Drawing.Point(131, 65);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(395, 26);
            this.type_txt.TabIndex = 35;
            // 
            // loans_combo
            // 
            this.loans_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.loans_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.loans_combo.Enabled = false;
            this.loans_combo.FormattingEnabled = true;
            this.loans_combo.Location = new System.Drawing.Point(131, 31);
            this.loans_combo.Name = "loans_combo";
            this.loans_combo.Size = new System.Drawing.Size(395, 28);
            this.loans_combo.TabIndex = 32;
            this.loans_combo.SelectedIndexChanged += new System.EventHandler(this.loans_combo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Branch No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date : ";
            // 
            // amount_txt
            // 
            this.amount_txt.Enabled = false;
            this.amount_txt.Location = new System.Drawing.Point(131, 97);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(395, 26);
            this.amount_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loans : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cid_txt);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(50, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 80);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Info.";
            // 
            // cid_txt
            // 
            this.cid_txt.Location = new System.Drawing.Point(131, 31);
            this.cid_txt.Name = "cid_txt";
            this.cid_txt.Size = new System.Drawing.Size(395, 26);
            this.cid_txt.TabIndex = 2;
            this.cid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberonly);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "National ID : ";
            // 
            // viewLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.get);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.info_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "viewLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewLoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.viewLoan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button get;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.ComboBox loans_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cid_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.TextBox branch_txt;
        private System.Windows.Forms.TextBox type_txt;
    }
}