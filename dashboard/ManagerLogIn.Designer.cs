namespace dashboard
{
    partial class ManagerLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerLogIn));
            this.managername = new System.Windows.Forms.Label();
            this.managerid = new System.Windows.Forms.Label();
            this.managerpass = new System.Windows.Forms.Label();
            this.managernametextbox = new System.Windows.Forms.TextBox();
            this.manageridtextbox = new System.Windows.Forms.TextBox();
            this.managerpasstextbox = new System.Windows.Forms.TextBox();
            this.gofirstmanager = new System.Windows.Forms.Button();
            this.managernext = new System.Windows.Forms.Button();
            this.managerpicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.managerpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // managername
            // 
            this.managername.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.managername.Location = new System.Drawing.Point(224, 101);
            this.managername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managername.Name = "managername";
            this.managername.Size = new System.Drawing.Size(317, 49);
            this.managername.TabIndex = 0;
            this.managername.Text = "Manager Name:";
            this.managername.Click += new System.EventHandler(this.managername_Click);
            // 
            // managerid
            // 
            this.managerid.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.managerid.Location = new System.Drawing.Point(287, 249);
            this.managerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerid.Name = "managerid";
            this.managerid.Size = new System.Drawing.Size(255, 49);
            this.managerid.TabIndex = 1;
            this.managerid.Text = "Manager ID:";
            // 
            // managerpass
            // 
            this.managerpass.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.managerpass.Location = new System.Drawing.Point(331, 390);
            this.managerpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.managerpass.Name = "managerpass";
            this.managerpass.Size = new System.Drawing.Size(211, 49);
            this.managerpass.TabIndex = 2;
            this.managerpass.Text = "Password:";
            // 
            // managernametextbox
            // 
            this.managernametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.managernametextbox.Location = new System.Drawing.Point(569, 86);
            this.managernametextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managernametextbox.Name = "managernametextbox";
            this.managernametextbox.Size = new System.Drawing.Size(532, 74);
            this.managernametextbox.TabIndex = 3;
            this.managernametextbox.TextChanged += new System.EventHandler(this.managernametextbox_TextChanged);
            // 
            // manageridtextbox
            // 
            this.manageridtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.manageridtextbox.Location = new System.Drawing.Point(569, 234);
            this.manageridtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageridtextbox.Name = "manageridtextbox";
            this.manageridtextbox.Size = new System.Drawing.Size(532, 74);
            this.manageridtextbox.TabIndex = 4;
            this.manageridtextbox.TextChanged += new System.EventHandler(this.manageridtextbox_TextChanged);
            // 
            // managerpasstextbox
            // 
            this.managerpasstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.managerpasstextbox.Location = new System.Drawing.Point(569, 377);
            this.managerpasstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managerpasstextbox.Name = "managerpasstextbox";
            this.managerpasstextbox.Size = new System.Drawing.Size(532, 74);
            this.managerpasstextbox.TabIndex = 5;
            this.managerpasstextbox.TextChanged += new System.EventHandler(this.managerpasstextbox_TextChanged);
            // 
            // gofirstmanager
            // 
            this.gofirstmanager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gofirstmanager.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.gofirstmanager.ForeColor = System.Drawing.Color.White;
            this.gofirstmanager.Location = new System.Drawing.Point(49, 676);
            this.gofirstmanager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gofirstmanager.Name = "gofirstmanager";
            this.gofirstmanager.Size = new System.Drawing.Size(239, 74);
            this.gofirstmanager.TabIndex = 6;
            this.gofirstmanager.Text = "Go Back";
            this.gofirstmanager.UseVisualStyleBackColor = false;
            this.gofirstmanager.Click += new System.EventHandler(this.gofirstmanager_Click);
            // 
            // managernext
            // 
            this.managernext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.managernext.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managernext.ForeColor = System.Drawing.Color.Transparent;
            this.managernext.Location = new System.Drawing.Point(1234, 676);
            this.managernext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managernext.Name = "managernext";
            this.managernext.Size = new System.Drawing.Size(239, 74);
            this.managernext.TabIndex = 8;
            this.managernext.Text = "Next";
            this.managernext.UseVisualStyleBackColor = false;
            this.managernext.Click += new System.EventHandler(this.managernext_Click);
            // 
            // managerpicturebox
            // 
            this.managerpicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("managerpicturebox.BackgroundImage")));
            this.managerpicturebox.ErrorImage = null;
            this.managerpicturebox.InitialImage = null;
            this.managerpicturebox.Location = new System.Drawing.Point(-48, 459);
            this.managerpicturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.managerpicturebox.Name = "managerpicturebox";
            this.managerpicturebox.Size = new System.Drawing.Size(2031, 196);
            this.managerpicturebox.TabIndex = 9;
            this.managerpicturebox.TabStop = false;
            // 
            // ManagerLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 775);
            this.Controls.Add(this.managerpicturebox);
            this.Controls.Add(this.managernext);
            this.Controls.Add(this.gofirstmanager);
            this.Controls.Add(this.managerpasstextbox);
            this.Controls.Add(this.manageridtextbox);
            this.Controls.Add(this.managernametextbox);
            this.Controls.Add(this.managerpass);
            this.Controls.Add(this.managerid);
            this.Controls.Add(this.managername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerLogIn";
            this.Text = "ManagerLogIn";
            ((System.ComponentModel.ISupportInitialize)(this.managerpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label managername;
        private System.Windows.Forms.Label managerid;
        private System.Windows.Forms.Label managerpass;
        private System.Windows.Forms.TextBox managernametextbox;
        private System.Windows.Forms.TextBox manageridtextbox;
        private System.Windows.Forms.TextBox managerpasstextbox;
        private System.Windows.Forms.Button gofirstmanager;
        private System.Windows.Forms.Button managernext;
        private System.Windows.Forms.PictureBox managerpicturebox;
    }
}