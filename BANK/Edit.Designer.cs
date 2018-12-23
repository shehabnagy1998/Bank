namespace BANK
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.transfare = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deposit
            // 
            this.deposit.BackColor = System.Drawing.Color.Transparent;
            this.deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deposit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deposit.FlatAppearance.BorderSize = 2;
            this.deposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deposit.ForeColor = System.Drawing.Color.Black;
            this.deposit.Location = new System.Drawing.Point(103, 276);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(104, 40);
            this.deposit.TabIndex = 0;
            this.deposit.Text = "Deposit";
            this.toolTip1.SetToolTip(this.deposit, "To deposit to current account");
            this.deposit.UseVisualStyleBackColor = false;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.Color.Transparent;
            this.withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.withdraw.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.withdraw.FlatAppearance.BorderSize = 2;
            this.withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdraw.ForeColor = System.Drawing.Color.Black;
            this.withdraw.Location = new System.Drawing.Point(448, 276);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(104, 40);
            this.withdraw.TabIndex = 1;
            this.withdraw.Text = "Withdraw";
            this.toolTip1.SetToolTip(this.withdraw, "To withdraw from account");
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.check.FlatAppearance.BorderSize = 2;
            this.check.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check.ForeColor = System.Drawing.Color.Black;
            this.check.Location = new System.Drawing.Point(103, 486);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(104, 40);
            this.check.TabIndex = 2;
            this.check.Text = "Check";
            this.toolTip1.SetToolTip(this.check, "Check current account balance");
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // transfare
            // 
            this.transfare.BackColor = System.Drawing.Color.Transparent;
            this.transfare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transfare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.transfare.FlatAppearance.BorderSize = 2;
            this.transfare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.transfare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transfare.ForeColor = System.Drawing.Color.Black;
            this.transfare.Location = new System.Drawing.Point(448, 486);
            this.transfare.Name = "transfare";
            this.transfare.Size = new System.Drawing.Size(104, 40);
            this.transfare.TabIndex = 3;
            this.transfare.Text = "Transfare";
            this.toolTip1.SetToolTip(this.transfare, "Transfare amount of money from one account to another");
            this.transfare.UseVisualStyleBackColor = false;
            this.transfare.Click += new System.EventHandler(this.transfare_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::BANK.Properties.Resources.undo_icon;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.Location = new System.Drawing.Point(587, 567);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 47);
            this.button5.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button5, "Return to the previous window");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(137, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose An Operation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BANK.Properties.Resources.bank_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(558, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.transfare);
            this.Controls.Add(this.check);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.deposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Edit_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button transfare;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}