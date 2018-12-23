namespace BANK
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bal_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.retu = new System.Windows.Forms.Button();
            this.withd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.info_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // info_groupbox
            // 
            this.info_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.info_groupbox.Controls.Add(this.label4);
            this.info_groupbox.Controls.Add(this.bal_txt);
            this.info_groupbox.Controls.Add(this.label3);
            this.info_groupbox.Controls.Add(this.amount_txt);
            this.info_groupbox.Controls.Add(this.natid_txt);
            this.info_groupbox.Controls.Add(this.label2);
            this.info_groupbox.Controls.Add(this.label1);
            this.info_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.info_groupbox.Location = new System.Drawing.Point(37, 172);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(567, 309);
            this.info_groupbox.TabIndex = 0;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "Info.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(93, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "P.S: The balance must be over 100 to withdraw";
            // 
            // bal_txt
            // 
            this.bal_txt.Enabled = false;
            this.bal_txt.Location = new System.Drawing.Point(140, 144);
            this.bal_txt.Name = "bal_txt";
            this.bal_txt.Size = new System.Drawing.Size(367, 26);
            this.bal_txt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bal_txt, "Client\'s balance after withdraw");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance : ";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(140, 112);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(367, 26);
            this.amount_txt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.amount_txt, "Enter the amount of money you want to withdraw , minimum is 100");
            this.amount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(140, 80);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(367, 26);
            this.natid_txt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.natid_txt, "Enter client\'s national ID");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.retu.Location = new System.Drawing.Point(587, 562);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(51, 52);
            this.retu.TabIndex = 1;
            this.toolTip1.SetToolTip(this.retu, "Return to previous window ");
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // withd
            // 
            this.withd.BackColor = System.Drawing.Color.Transparent;
            this.withd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.withd.FlatAppearance.BorderSize = 2;
            this.withd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.withd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withd.ForeColor = System.Drawing.Color.Navy;
            this.withd.Location = new System.Drawing.Point(264, 568);
            this.withd.Name = "withd";
            this.withd.Size = new System.Drawing.Size(110, 39);
            this.withd.TabIndex = 2;
            this.withd.Text = "Withdraw";
            this.toolTip1.SetToolTip(this.withd, "Withdraw from client\'s balance the entered amount");
            this.withd.UseVisualStyleBackColor = false;
            this.withd.Click += new System.EventHandler(this.withd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(30, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 42);
            this.label5.TabIndex = 56;
            this.label5.Text = "Withdraw";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.withd);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.info_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Withdraw_FormClosing);
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.Button withd;
        private System.Windows.Forms.TextBox bal_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}