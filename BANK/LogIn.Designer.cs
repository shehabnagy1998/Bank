namespace BANK
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.log = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.log, "log");
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.log.ForeColor = System.Drawing.Color.Navy;
            this.log.Name = "log";
            this.toolTip1.SetToolTip(this.log, resources.GetString("log.ToolTip"));
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Name = "time";
            // 
            // user_txt
            // 
            resources.ApplyResources(this.user_txt, "user_txt");
            this.user_txt.Name = "user_txt";
            this.toolTip1.SetToolTip(this.user_txt, resources.GetString("user_txt.ToolTip"));
            this.user_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_txt_KeyDown);
            // 
            // pass_txt
            // 
            resources.ApplyResources(this.pass_txt, "pass_txt");
            this.pass_txt.Name = "pass_txt";
            this.toolTip1.SetToolTip(this.pass_txt, resources.GetString("pass_txt.ToolTip"));
            this.pass_txt.UseSystemPasswordChar = true;
            this.pass_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pass_txt_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Name = "date";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // LOGIN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.log);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label label1;
    }
}