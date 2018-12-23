namespace BANK
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.label2 = new System.Windows.Forms.Label();
            this.natid_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete2 = new System.Windows.Forms.Button();
            this.retu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "National ID : ";
            // 
            // natid_txt
            // 
            this.natid_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.natid_txt.Location = new System.Drawing.Point(144, 85);
            this.natid_txt.Name = "natid_txt";
            this.natid_txt.Size = new System.Drawing.Size(340, 26);
            this.natid_txt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.natid_txt, "Enter client\'s national ID which is 14 digit");
            this.natid_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberonly);
            this.natid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.natid_txt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(62, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client ID";
            // 
            // delete2
            // 
            this.delete2.BackColor = System.Drawing.Color.Transparent;
            this.delete2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete2.FlatAppearance.BorderSize = 2;
            this.delete2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.delete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete2.ForeColor = System.Drawing.Color.Navy;
            this.delete2.Location = new System.Drawing.Point(275, 567);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(88, 41);
            this.delete2.TabIndex = 4;
            this.delete2.Text = "Delete";
            this.toolTip1.SetToolTip(this.delete2, "Delete client\'s account");
            this.delete2.UseVisualStyleBackColor = false;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // retu
            // 
            this.retu.BackColor = System.Drawing.Color.Transparent;
            this.retu.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.retu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retu.FlatAppearance.BorderSize = 0;
            this.retu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retu.ForeColor = System.Drawing.Color.Navy;
            this.retu.Location = new System.Drawing.Point(591, 567);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(47, 47);
            this.retu.TabIndex = 37;
            this.toolTip1.SetToolTip(this.retu, "To return to the previous window");
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(55, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 42);
            this.label1.TabIndex = 56;
            this.label1.Text = "Delete Client ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Delete_FormClosing);
            this.Load += new System.EventHandler(this.Delete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox natid_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}