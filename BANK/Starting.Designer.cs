namespace BANK
{
    partial class Starting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Starting));
            this.neww = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.services = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.retu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // neww
            // 
            this.neww.BackColor = System.Drawing.Color.Transparent;
            this.neww.Cursor = System.Windows.Forms.Cursors.Hand;
            this.neww.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.neww.FlatAppearance.BorderSize = 2;
            this.neww.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.neww.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neww.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neww.ForeColor = System.Drawing.Color.Black;
            this.neww.Location = new System.Drawing.Point(94, 243);
            this.neww.Name = "neww";
            this.neww.Size = new System.Drawing.Size(102, 40);
            this.neww.TabIndex = 1;
            this.neww.Text = "New";
            this.toolTip1.SetToolTip(this.neww, "Create new client\'s account");
            this.neww.UseVisualStyleBackColor = false;
            this.neww.Click += new System.EventHandler(this.neww_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderSize = 2;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Black;
            this.delete.Location = new System.Drawing.Point(94, 462);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(102, 40);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.toolTip1.SetToolTip(this.delete, "Delete current client\'s account using client\'s National ID");
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.edit.FlatAppearance.BorderSize = 2;
            this.edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.Black;
            this.edit.Location = new System.Drawing.Point(465, 243);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(102, 40);
            this.edit.TabIndex = 3;
            this.edit.Text = "Edit";
            this.toolTip1.SetToolTip(this.edit, "Edit current clients\'s account such as withdraw or deposit and others");
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // services
            // 
            this.services.BackColor = System.Drawing.Color.Transparent;
            this.services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.services.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.services.FlatAppearance.BorderSize = 2;
            this.services.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.services.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.services.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services.ForeColor = System.Drawing.Color.Black;
            this.services.Location = new System.Drawing.Point(465, 462);
            this.services.Name = "services";
            this.services.Size = new System.Drawing.Size(102, 40);
            this.services.TabIndex = 4;
            this.services.Text = "Loan";
            this.toolTip1.SetToolTip(this.services, "Other services in bank such currency converter");
            this.services.UseVisualStyleBackColor = false;
            this.services.Click += new System.EventHandler(this.services_Click);
            // 
            // retu
            // 
            this.retu.BackColor = System.Drawing.Color.Transparent;
            this.retu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.retu.FlatAppearance.BorderSize = 0;
            this.retu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.retu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retu.Image = global::BANK.Properties.Resources.undo_icon;
            this.retu.Location = new System.Drawing.Point(584, 567);
            this.retu.Name = "retu";
            this.retu.Size = new System.Drawing.Size(54, 47);
            this.retu.TabIndex = 59;
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
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(147, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 61;
            this.label1.Text = "Choose An Operation";
            // 
            // Starting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.services);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.neww);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Starting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Starting_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button neww;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button services;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}