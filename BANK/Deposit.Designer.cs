namespace BANK
{
    partial class Deposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.depo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.info_groupbox = new System.Windows.Forms.GroupBox();
            this.bal_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.info_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // depo
            // 
            this.depo.BackColor = System.Drawing.Color.Transparent;
            this.depo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.depo.FlatAppearance.BorderSize = 2;
            this.depo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.depo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depo.ForeColor = System.Drawing.Color.Navy;
            this.depo.Location = new System.Drawing.Point(253, 569);
            this.depo.Name = "depo";
            this.depo.Size = new System.Drawing.Size(92, 39);
            this.depo.TabIndex = 5;
            this.depo.Text = "Deposit";
            this.toolTip1.SetToolTip(this.depo, "Deposit to client\'s balance the entered amount");
            this.depo.UseVisualStyleBackColor = false;
            this.depo.Click += new System.EventHandler(this.depo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 49);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "turn to previous window ");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info_groupbox
            // 
            this.info_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.info_groupbox.Controls.Add(this.bal_txt);
            this.info_groupbox.Controls.Add(this.label3);
            this.info_groupbox.Controls.Add(this.amount_txt);
            this.info_groupbox.Controls.Add(this.natid_txt);
            this.info_groupbox.Controls.Add(this.label2);
            this.info_groupbox.Controls.Add(this.label1);
            this.info_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.info_groupbox.Location = new System.Drawing.Point(61, 123);
            this.info_groupbox.Name = "info_groupbox";
            this.info_groupbox.Size = new System.Drawing.Size(538, 326);
            this.info_groupbox.TabIndex = 3;
            this.info_groupbox.TabStop = false;
            this.info_groupbox.Text = "Info.";
            // 
            // bal_txt
            // 
            this.bal_txt.Enabled = false;
            this.bal_txt.Location = new System.Drawing.Point(142, 213);
            this.bal_txt.Name = "bal_txt";
            this.bal_txt.Size = new System.Drawing.Size(359, 26);
            this.bal_txt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bal_txt, "Client\'s balance after deposit");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(142, 152);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(359, 26);
            this.amount_txt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.amount_txt, "Enter the amount of money you want to deposit , minimum is 100");
            this.amount_txt.TextChanged += new System.EventHandler(this.amount_txt_TextChanged);
            this.amount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(142, 88);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(359, 26);
            this.natid_txt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.natid_txt, "Enter client\'s national ID");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(54, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 42);
            this.label4.TabIndex = 58;
            this.label4.Text = "Deposit";
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
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.depo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Deposit_FormClosing);
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.info_groupbox.ResumeLayout(false);
            this.info_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox info_groupbox;
        private System.Windows.Forms.TextBox bal_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}