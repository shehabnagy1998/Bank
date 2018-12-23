namespace BANK
{
    partial class Transfering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfering));
            this.from_groupbox = new System.Windows.Forms.GroupBox();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.to_groupbox = new System.Windows.Forms.GroupBox();
            this.natid2_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transfer = new System.Windows.Forms.Button();
            this.retur = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cli1_txt = new System.Windows.Forms.TextBox();
            this.cli2_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.from_groupbox.SuspendLayout();
            this.to_groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // from_groupbox
            // 
            this.from_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.from_groupbox.Controls.Add(this.amount_txt);
            this.from_groupbox.Controls.Add(this.natid_txt);
            this.from_groupbox.Controls.Add(this.label2);
            this.from_groupbox.Controls.Add(this.label1);
            this.from_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_groupbox.ForeColor = System.Drawing.Color.Blue;
            this.from_groupbox.Location = new System.Drawing.Point(39, 110);
            this.from_groupbox.Name = "from_groupbox";
            this.from_groupbox.Size = new System.Drawing.Size(569, 150);
            this.from_groupbox.TabIndex = 0;
            this.from_groupbox.TabStop = false;
            this.from_groupbox.Text = "Tranfer from";
            this.from_groupbox.Enter += new System.EventHandler(this.from_groupbox_Enter);
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(135, 88);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(398, 26);
            this.amount_txt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.amount_txt, "Enter the amount you want to transfer");
            this.amount_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.amount_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberonly);
            // 
            // natid_txt
            // 
            this.natid_txt.Location = new System.Drawing.Point(135, 56);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(398, 26);
            this.natid_txt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.natid_txt, "Enter the national ID of client\'s account to transfer money from");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberonly);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "National ID : ";
            // 
            // to_groupbox
            // 
            this.to_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.to_groupbox.Controls.Add(this.natid2_txt);
            this.to_groupbox.Controls.Add(this.label3);
            this.to_groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_groupbox.ForeColor = System.Drawing.Color.Blue;
            this.to_groupbox.Location = new System.Drawing.Point(39, 275);
            this.to_groupbox.Name = "to_groupbox";
            this.to_groupbox.Size = new System.Drawing.Size(569, 116);
            this.to_groupbox.TabIndex = 1;
            this.to_groupbox.TabStop = false;
            this.to_groupbox.Text = "Transfer to";
            // 
            // natid2_txt
            // 
            this.natid2_txt.Location = new System.Drawing.Point(135, 56);
            this.natid2_txt.Name = "natid2_txt";
            this.natid2_txt.Size = new System.Drawing.Size(398, 26);
            this.natid2_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.natid2_txt, "Enter the national ID of client\'s account you want to transfer to");
            this.natid2_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid2_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberonly);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "National ID : ";
            // 
            // transfer
            // 
            this.transfer.BackColor = System.Drawing.Color.Transparent;
            this.transfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transfer.FlatAppearance.BorderSize = 2;
            this.transfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.transfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfer.ForeColor = System.Drawing.Color.Navy;
            this.transfer.Location = new System.Drawing.Point(261, 571);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(100, 38);
            this.transfer.TabIndex = 2;
            this.transfer.Text = "Transfer";
            this.toolTip1.SetToolTip(this.transfer, "Transfare the money");
            this.transfer.UseVisualStyleBackColor = false;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // retur
            // 
            this.retur.BackColor = System.Drawing.Color.Transparent;
            this.retur.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.retur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retur.FlatAppearance.BorderSize = 0;
            this.retur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retur.Location = new System.Drawing.Point(586, 567);
            this.retur.Name = "retur";
            this.retur.Size = new System.Drawing.Size(52, 47);
            this.retur.TabIndex = 3;
            this.toolTip1.SetToolTip(this.retur, "Return to the previous window");
            this.retur.UseVisualStyleBackColor = false;
            this.retur.Click += new System.EventHandler(this.button2_Click);
            // 
            // cli1_txt
            // 
            this.cli1_txt.Enabled = false;
            this.cli1_txt.Location = new System.Drawing.Point(135, 36);
            this.cli1_txt.Name = "cli1_txt";
            this.cli1_txt.Size = new System.Drawing.Size(398, 26);
            this.cli1_txt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cli1_txt, "balance of client that tranfered from his/her account");
            // 
            // cli2_txt
            // 
            this.cli2_txt.Enabled = false;
            this.cli2_txt.Location = new System.Drawing.Point(135, 68);
            this.cli2_txt.Name = "cli2_txt";
            this.cli2_txt.Size = new System.Drawing.Size(398, 26);
            this.cli2_txt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cli2_txt, "balance of client that tranfered to his/her account");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cli2_txt);
            this.groupBox1.Controls.Add(this.cli1_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(39, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info after tranfering";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "cli_2 bal :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "cli_1 bal : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 42);
            this.label6.TabIndex = 56;
            this.label6.Text = "New Client ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            // Transfering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.retur);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.to_groupbox);
            this.Controls.Add(this.from_groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Transfering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfaring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transfaring_FormClosing);
            this.from_groupbox.ResumeLayout(false);
            this.from_groupbox.PerformLayout();
            this.to_groupbox.ResumeLayout(false);
            this.to_groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox from_groupbox;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox to_groupbox;
        private System.Windows.Forms.TextBox natid2_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Button retur;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cli2_txt;
        private System.Windows.Forms.TextBox cli1_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}