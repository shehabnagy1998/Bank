namespace BANK
{
    partial class Supervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supervisor));
            this.label1 = new System.Windows.Forms.Label();
            this.retu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.create = new System.Windows.Forms.Button();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.emoid_txt = new System.Windows.Forms.TextBox();
            this.last_txt = new System.Windows.Forms.TextBox();
            this.first_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.gender_txt = new System.Windows.Forms.TextBox();
            this.mgr_txt = new System.Windows.Forms.TextBox();
            this.branch_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.information_group = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.information_group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 61;
            this.label1.Text = "Management";
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
            this.retu.TabIndex = 58;
            this.toolTip1.SetToolTip(this.retu, "To return to the previous window");
            this.retu.UseVisualStyleBackColor = false;
            this.retu.Click += new System.EventHandler(this.retu_Click);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.create.FlatAppearance.BorderSize = 2;
            this.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Navy;
            this.create.Location = new System.Drawing.Point(247, 125);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(91, 36);
            this.create.TabIndex = 57;
            this.create.Text = "Show";
            this.toolTip1.SetToolTip(this.create, "Create the new account of the client");
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // number_txt
            // 
            this.number_txt.Enabled = false;
            this.number_txt.Location = new System.Drawing.Point(145, 85);
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(407, 26);
            this.number_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.number_txt, "Enter client\'s last name");
            // 
            // emoid_txt
            // 
            this.emoid_txt.Location = new System.Drawing.Point(145, 53);
            this.emoid_txt.Name = "emoid_txt";
            this.emoid_txt.Size = new System.Drawing.Size(407, 26);
            this.emoid_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.emoid_txt, "Enter client\'s first name");
            this.emoid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numbersonly);
            // 
            // last_txt
            // 
            this.last_txt.Enabled = false;
            this.last_txt.Location = new System.Drawing.Point(145, 73);
            this.last_txt.Name = "last_txt";
            this.last_txt.Size = new System.Drawing.Size(407, 26);
            this.last_txt.TabIndex = 1;
            this.toolTip1.SetToolTip(this.last_txt, "Enter client\'s last name");
            // 
            // first_txt
            // 
            this.first_txt.Enabled = false;
            this.first_txt.Location = new System.Drawing.Point(145, 41);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(407, 26);
            this.first_txt.TabIndex = 0;
            this.toolTip1.SetToolTip(this.first_txt, "Enter client\'s first name");
            // 
            // address_txt
            // 
            this.address_txt.Enabled = false;
            this.address_txt.Location = new System.Drawing.Point(145, 137);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(407, 26);
            this.address_txt.TabIndex = 15;
            this.toolTip1.SetToolTip(this.address_txt, "Enter client\'s last name");
            // 
            // gender_txt
            // 
            this.gender_txt.Enabled = false;
            this.gender_txt.Location = new System.Drawing.Point(145, 105);
            this.gender_txt.Name = "gender_txt";
            this.gender_txt.Size = new System.Drawing.Size(407, 26);
            this.gender_txt.TabIndex = 14;
            this.toolTip1.SetToolTip(this.gender_txt, "Enter client\'s first name");
            // 
            // mgr_txt
            // 
            this.mgr_txt.Enabled = false;
            this.mgr_txt.Location = new System.Drawing.Point(145, 201);
            this.mgr_txt.Name = "mgr_txt";
            this.mgr_txt.Size = new System.Drawing.Size(407, 26);
            this.mgr_txt.TabIndex = 19;
            this.toolTip1.SetToolTip(this.mgr_txt, "Enter client\'s last name");
            // 
            // branch_txt
            // 
            this.branch_txt.Enabled = false;
            this.branch_txt.Location = new System.Drawing.Point(145, 169);
            this.branch_txt.Name = "branch_txt";
            this.branch_txt.Size = new System.Drawing.Size(407, 26);
            this.branch_txt.TabIndex = 18;
            this.toolTip1.SetToolTip(this.branch_txt, "Enter client\'s first name");
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(8, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Employee ID : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(8, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "No. of Emps. : ";
            // 
            // information_group
            // 
            this.information_group.BackColor = System.Drawing.Color.Transparent;
            this.information_group.Controls.Add(this.label16);
            this.information_group.Controls.Add(this.label18);
            this.information_group.Controls.Add(this.number_txt);
            this.information_group.Controls.Add(this.emoid_txt);
            this.information_group.Controls.Add(this.create);
            this.information_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_group.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.information_group.Location = new System.Drawing.Point(42, 98);
            this.information_group.Name = "information_group";
            this.information_group.Size = new System.Drawing.Size(578, 182);
            this.information_group.TabIndex = 56;
            this.information_group.TabStop = false;
            this.information_group.Text = "Enter Emp ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mgr_txt);
            this.groupBox1.Controls.Add(this.branch_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.address_txt);
            this.groupBox1.Controls.Add(this.gender_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.last_txt);
            this.groupBox1.Controls.Add(this.first_txt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(42, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 243);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emp Info.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Branch No.  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Manger id : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Emp Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last name : ";
            // 
            // Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANK.Properties.Resources.downloadfile_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.information_group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Supervisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supervisor_FormClosing);
            this.Load += new System.EventHandler(this.Supervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.information_group.ResumeLayout(false);
            this.information_group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button retu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox emoid_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox information_group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mgr_txt;
        private System.Windows.Forms.TextBox branch_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox gender_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox last_txt;
        private System.Windows.Forms.TextBox first_txt;
    }
}