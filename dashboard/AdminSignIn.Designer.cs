namespace dashboard
{
    partial class AdminSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignIn));
            this.adminname = new System.Windows.Forms.Label();
            this.adminid = new System.Windows.Forms.Label();
            this.adminpass = new System.Windows.Forms.Label();
            this.adminnametextbox = new System.Windows.Forms.TextBox();
            this.adminidtextbox = new System.Windows.Forms.TextBox();
            this.adminpasstextbox = new System.Windows.Forms.TextBox();
            this.gofirst = new System.Windows.Forms.Button();
            this.adminnext = new System.Windows.Forms.Button();
            this.adminpicturebox = new System.Windows.Forms.PictureBox();
            this.nextadmindash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.adminpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // adminname
            // 
            this.adminname.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminname.Location = new System.Drawing.Point(172, 113);
            this.adminname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(277, 49);
            this.adminname.TabIndex = 0;
            this.adminname.Text = "Admin Name:";
            // 
            // adminid
            // 
            this.adminid.AutoSize = true;
            this.adminid.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.adminid.Location = new System.Drawing.Point(247, 247);
            this.adminid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminid.Name = "adminid";
            this.adminid.Size = new System.Drawing.Size(192, 45);
            this.adminid.TabIndex = 1;
            this.adminid.Text = "Admin ID:";
            // 
            // adminpass
            // 
            this.adminpass.AutoSize = true;
            this.adminpass.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.adminpass.Location = new System.Drawing.Point(245, 377);
            this.adminpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adminpass.Name = "adminpass";
            this.adminpass.Size = new System.Drawing.Size(194, 45);
            this.adminpass.TabIndex = 2;
            this.adminpass.Text = "Password:";
            // 
            // adminnametextbox
            // 
            this.adminnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnametextbox.Location = new System.Drawing.Point(472, 102);
            this.adminnametextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminnametextbox.Name = "adminnametextbox";
            this.adminnametextbox.Size = new System.Drawing.Size(532, 74);
            this.adminnametextbox.TabIndex = 3;
            this.adminnametextbox.TextChanged += new System.EventHandler(this.adminnametextbox_TextChanged);
            // 
            // adminidtextbox
            // 
            this.adminidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.adminidtextbox.Location = new System.Drawing.Point(472, 231);
            this.adminidtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminidtextbox.Name = "adminidtextbox";
            this.adminidtextbox.Size = new System.Drawing.Size(532, 74);
            this.adminidtextbox.TabIndex = 4;
            this.adminidtextbox.TextChanged += new System.EventHandler(this.adminidtextbox_TextChanged);
            // 
            // adminpasstextbox
            // 
            this.adminpasstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.adminpasstextbox.Location = new System.Drawing.Point(472, 362);
            this.adminpasstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminpasstextbox.Name = "adminpasstextbox";
            this.adminpasstextbox.Size = new System.Drawing.Size(532, 74);
            this.adminpasstextbox.TabIndex = 5;
            this.adminpasstextbox.TextChanged += new System.EventHandler(this.adminpasstextbox_TextChanged);
            // 
            // gofirst
            // 
            this.gofirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gofirst.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gofirst.ForeColor = System.Drawing.Color.Transparent;
            this.gofirst.Location = new System.Drawing.Point(71, 675);
            this.gofirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gofirst.Name = "gofirst";
            this.gofirst.Size = new System.Drawing.Size(239, 74);
            this.gofirst.TabIndex = 6;
            this.gofirst.Text = "Go Back";
            this.gofirst.UseVisualStyleBackColor = false;
            this.gofirst.Click += new System.EventHandler(this.gofirst_Click);
            // 
            // adminnext
            // 
            this.adminnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.adminnext.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnext.ForeColor = System.Drawing.Color.Transparent;
            this.adminnext.Location = new System.Drawing.Point(1653, 657);
            this.adminnext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminnext.Name = "adminnext";
            this.adminnext.Size = new System.Drawing.Size(239, 74);
            this.adminnext.TabIndex = 7;
            this.adminnext.Text = "Next";
            this.adminnext.UseVisualStyleBackColor = false;
            // 
            // adminpicturebox
            // 
            this.adminpicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("adminpicturebox.BackgroundImage")));
            this.adminpicturebox.ErrorImage = null;
            this.adminpicturebox.InitialImage = null;
            this.adminpicturebox.Location = new System.Drawing.Point(-24, 458);
            this.adminpicturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminpicturebox.Name = "adminpicturebox";
            this.adminpicturebox.Size = new System.Drawing.Size(2031, 209);
            this.adminpicturebox.TabIndex = 8;
            this.adminpicturebox.TabStop = false;
            // 
            // nextadmindash
            // 
            this.nextadmindash.BackColor = System.Drawing.Color.Blue;
            this.nextadmindash.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextadmindash.ForeColor = System.Drawing.Color.Transparent;
            this.nextadmindash.Location = new System.Drawing.Point(1084, 675);
            this.nextadmindash.Margin = new System.Windows.Forms.Padding(4);
            this.nextadmindash.Name = "nextadmindash";
            this.nextadmindash.Size = new System.Drawing.Size(239, 74);
            this.nextadmindash.TabIndex = 9;
            this.nextadmindash.Text = "Next";
            this.nextadmindash.UseVisualStyleBackColor = false;
            this.nextadmindash.Click += new System.EventHandler(this.nextadmindash_Click);
            // 
            // AdminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 790);
            this.Controls.Add(this.nextadmindash);
            this.Controls.Add(this.adminpicturebox);
            this.Controls.Add(this.adminnext);
            this.Controls.Add(this.gofirst);
            this.Controls.Add(this.adminpasstextbox);
            this.Controls.Add(this.adminidtextbox);
            this.Controls.Add(this.adminnametextbox);
            this.Controls.Add(this.adminpass);
            this.Controls.Add(this.adminid);
            this.Controls.Add(this.adminname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSignIn";
            this.Text = "AdminSignIn";
            this.Load += new System.EventHandler(this.AdminSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminname;
        private System.Windows.Forms.Label adminid;
        private System.Windows.Forms.Label adminpass;
        private System.Windows.Forms.TextBox adminnametextbox;
        private System.Windows.Forms.TextBox adminidtextbox;
        private System.Windows.Forms.TextBox adminpasstextbox;
        private System.Windows.Forms.Button gofirst;
        private System.Windows.Forms.Button adminnext;
        private System.Windows.Forms.PictureBox adminpicturebox;
        private System.Windows.Forms.Button nextadmindash;
    }
}