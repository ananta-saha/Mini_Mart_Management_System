namespace dashboard
{
    partial class StaffLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogIn));
            this.staffname = new System.Windows.Forms.Label();
            this.staffid = new System.Windows.Forms.Label();
            this.staffpass = new System.Windows.Forms.Label();
            this.staffnametextbox = new System.Windows.Forms.TextBox();
            this.staffidtextbox = new System.Windows.Forms.TextBox();
            this.staffpasstextbox = new System.Windows.Forms.TextBox();
            this.staffpicturebox = new System.Windows.Forms.PictureBox();
            this.gofirststaff = new System.Windows.Forms.Button();
            this.staffnext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staffpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // staffname
            // 
            this.staffname.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.staffname.Location = new System.Drawing.Point(329, 91);
            this.staffname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffname.Name = "staffname";
            this.staffname.Size = new System.Drawing.Size(243, 49);
            this.staffname.TabIndex = 1;
            this.staffname.Text = "Staff Name:";
            // 
            // staffid
            // 
            this.staffid.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.staffid.Location = new System.Drawing.Point(388, 239);
            this.staffid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffid.Name = "staffid";
            this.staffid.Size = new System.Drawing.Size(184, 49);
            this.staffid.TabIndex = 2;
            this.staffid.Text = "Staff ID:";
            // 
            // staffpass
            // 
            this.staffpass.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold);
            this.staffpass.Location = new System.Drawing.Point(361, 383);
            this.staffpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.staffpass.Name = "staffpass";
            this.staffpass.Size = new System.Drawing.Size(211, 49);
            this.staffpass.TabIndex = 3;
            this.staffpass.Text = "Password:";
            // 
            // staffnametextbox
            // 
            this.staffnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.staffnametextbox.Location = new System.Drawing.Point(593, 80);
            this.staffnametextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffnametextbox.Name = "staffnametextbox";
            this.staffnametextbox.Size = new System.Drawing.Size(532, 74);
            this.staffnametextbox.TabIndex = 4;
            // 
            // staffidtextbox
            // 
            this.staffidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.staffidtextbox.Location = new System.Drawing.Point(593, 228);
            this.staffidtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffidtextbox.Name = "staffidtextbox";
            this.staffidtextbox.Size = new System.Drawing.Size(532, 74);
            this.staffidtextbox.TabIndex = 5;
            this.staffidtextbox.TextChanged += new System.EventHandler(this.staffidtextbox_TextChanged);
            // 
            // staffpasstextbox
            // 
            this.staffpasstextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.staffpasstextbox.Location = new System.Drawing.Point(593, 371);
            this.staffpasstextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffpasstextbox.Name = "staffpasstextbox";
            this.staffpasstextbox.Size = new System.Drawing.Size(532, 74);
            this.staffpasstextbox.TabIndex = 6;
            this.staffpasstextbox.TextChanged += new System.EventHandler(this.staffpasstextbox_TextChanged);
            // 
            // staffpicturebox
            // 
            this.staffpicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffpicturebox.BackgroundImage")));
            this.staffpicturebox.ErrorImage = null;
            this.staffpicturebox.InitialImage = null;
            this.staffpicturebox.Location = new System.Drawing.Point(-21, 466);
            this.staffpicturebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffpicturebox.Name = "staffpicturebox";
            this.staffpicturebox.Size = new System.Drawing.Size(2031, 202);
            this.staffpicturebox.TabIndex = 10;
            this.staffpicturebox.TabStop = false;
            // 
            // gofirststaff
            // 
            this.gofirststaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gofirststaff.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold);
            this.gofirststaff.ForeColor = System.Drawing.Color.White;
            this.gofirststaff.Location = new System.Drawing.Point(33, 676);
            this.gofirststaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gofirststaff.Name = "gofirststaff";
            this.gofirststaff.Size = new System.Drawing.Size(239, 74);
            this.gofirststaff.TabIndex = 11;
            this.gofirststaff.Text = "Go Back";
            this.gofirststaff.UseVisualStyleBackColor = false;
            this.gofirststaff.Click += new System.EventHandler(this.gofirststaff_Click);
            // 
            // staffnext
            // 
            this.staffnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.staffnext.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnext.ForeColor = System.Drawing.Color.Transparent;
            this.staffnext.Location = new System.Drawing.Point(1165, 690);
            this.staffnext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.staffnext.Name = "staffnext";
            this.staffnext.Size = new System.Drawing.Size(239, 74);
            this.staffnext.TabIndex = 12;
            this.staffnext.Text = "Next";
            this.staffnext.UseVisualStyleBackColor = false;
            this.staffnext.Click += new System.EventHandler(this.staffnext_Click);
            // 
            // StaffLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 777);
            this.Controls.Add(this.staffnext);
            this.Controls.Add(this.gofirststaff);
            this.Controls.Add(this.staffpicturebox);
            this.Controls.Add(this.staffpasstextbox);
            this.Controls.Add(this.staffidtextbox);
            this.Controls.Add(this.staffnametextbox);
            this.Controls.Add(this.staffpass);
            this.Controls.Add(this.staffid);
            this.Controls.Add(this.staffname);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffLogIn";
            this.Text = "StaffLogIn";
            this.Load += new System.EventHandler(this.StaffLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffname;
        private System.Windows.Forms.Label staffid;
        private System.Windows.Forms.Label staffpass;
        private System.Windows.Forms.TextBox staffnametextbox;
        private System.Windows.Forms.TextBox staffidtextbox;
        private System.Windows.Forms.TextBox staffpasstextbox;
        private System.Windows.Forms.PictureBox staffpicturebox;
        private System.Windows.Forms.Button gofirststaff;
        private System.Windows.Forms.Button staffnext;
    }
}