namespace dashboard
{
    partial class First
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.welcome = new System.Windows.Forms.Label();
            this.staffbutton = new System.Windows.Forms.Button();
            this.adminbutton = new System.Windows.Forms.Button();
            this.firstpicturebox = new System.Windows.Forms.PictureBox();
            this.firstlowpicturebox = new System.Windows.Forms.PictureBox();
            this.managerbutton = new System.Windows.Forms.Button();
            this.exitfirstbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstlowpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("Californian FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(403, 44);
            this.welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(1001, 68);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "\" THE ONE STOP MARKETING FOR YOUR DAILY GROCERIES\"";
            // 
            // staffbutton
            // 
            this.staffbutton.BackColor = System.Drawing.Color.Crimson;
            this.staffbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffbutton.ForeColor = System.Drawing.Color.Transparent;
            this.staffbutton.Location = new System.Drawing.Point(85, 578);
            this.staffbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffbutton.Name = "staffbutton";
            this.staffbutton.Size = new System.Drawing.Size(360, 106);
            this.staffbutton.TabIndex = 1;
            this.staffbutton.Text = "STAFF \r\nLOG IN";
            this.staffbutton.UseVisualStyleBackColor = false;
            this.staffbutton.Click += new System.EventHandler(this.staffsign_Click);
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adminbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.adminbutton.ForeColor = System.Drawing.Color.Transparent;
            this.adminbutton.Location = new System.Drawing.Point(1098, 578);
            this.adminbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(360, 106);
            this.adminbutton.TabIndex = 2;
            this.adminbutton.Text = "ADMIN \r\nLOG IN";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminsignin_Click);
            // 
            // firstpicturebox
            // 
            this.firstpicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstpicturebox.BackgroundImage")));
            this.firstpicturebox.Location = new System.Drawing.Point(-5, 13);
            this.firstpicturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstpicturebox.Name = "firstpicturebox";
            this.firstpicturebox.Size = new System.Drawing.Size(1562, 557);
            this.firstpicturebox.TabIndex = 3;
            this.firstpicturebox.TabStop = false;
            // 
            // firstlowpicturebox
            // 
            this.firstlowpicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstlowpicturebox.BackgroundImage")));
            this.firstlowpicturebox.Location = new System.Drawing.Point(-5, 692);
            this.firstlowpicturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstlowpicturebox.Name = "firstlowpicturebox";
            this.firstlowpicturebox.Size = new System.Drawing.Size(2059, 121);
            this.firstlowpicturebox.TabIndex = 4;
            this.firstlowpicturebox.TabStop = false;
            // 
            // managerbutton
            // 
            this.managerbutton.BackColor = System.Drawing.Color.SandyBrown;
            this.managerbutton.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.managerbutton.ForeColor = System.Drawing.Color.White;
            this.managerbutton.Location = new System.Drawing.Point(592, 578);
            this.managerbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managerbutton.Name = "managerbutton";
            this.managerbutton.Size = new System.Drawing.Size(360, 106);
            this.managerbutton.TabIndex = 5;
            this.managerbutton.Text = "MANAGER \r\nLOG IN";
            this.managerbutton.UseVisualStyleBackColor = false;
            this.managerbutton.Click += new System.EventHandler(this.managerbutton_Click);
            // 
            // exitfirstbutton
            // 
            this.exitfirstbutton.BackColor = System.Drawing.Color.Red;
            this.exitfirstbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitfirstbutton.ForeColor = System.Drawing.Color.White;
            this.exitfirstbutton.Location = new System.Drawing.Point(35, 31);
            this.exitfirstbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitfirstbutton.Name = "exitfirstbutton";
            this.exitfirstbutton.Size = new System.Drawing.Size(131, 46);
            this.exitfirstbutton.TabIndex = 6;
            this.exitfirstbutton.Text = "EXIT";
            this.exitfirstbutton.UseVisualStyleBackColor = false;
            this.exitfirstbutton.Click += new System.EventHandler(this.exitfirstbutton_Click);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1917, 814);
            this.Controls.Add(this.exitfirstbutton);
            this.Controls.Add(this.managerbutton);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.firstlowpicturebox);
            this.Controls.Add(this.firstpicturebox);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.staffbutton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "First";
            this.Text = "MINI MART";
            this.Load += new System.EventHandler(this.First_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstlowpicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button staffbutton;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.PictureBox firstpicturebox;
        private System.Windows.Forms.PictureBox firstlowpicturebox;
        private System.Windows.Forms.Button managerbutton;
        private System.Windows.Forms.Button exitfirstbutton;
    }
}

