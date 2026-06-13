
namespace dashboard
{
    partial class Dashboard
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
            this.bt_Grochery = new System.Windows.Forms.Button();
            this.bt_snacks = new System.Windows.Forms.Button();
            this.bt_fruits = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.bt_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Grochery
            // 
            this.bt_Grochery.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_Grochery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Grochery.Location = new System.Drawing.Point(181, 250);
            this.bt_Grochery.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Grochery.Name = "bt_Grochery";
            this.bt_Grochery.Size = new System.Drawing.Size(121, 39);
            this.bt_Grochery.TabIndex = 0;
            this.bt_Grochery.Text = "Grochery";
            this.bt_Grochery.UseVisualStyleBackColor = false;
            this.bt_Grochery.Click += new System.EventHandler(this.bt_grochery);
            // 
            // bt_snacks
            // 
            this.bt_snacks.BackColor = System.Drawing.SystemColors.Highlight;
            this.bt_snacks.Location = new System.Drawing.Point(444, 312);
            this.bt_snacks.Margin = new System.Windows.Forms.Padding(4);
            this.bt_snacks.Name = "bt_snacks";
            this.bt_snacks.Size = new System.Drawing.Size(129, 39);
            this.bt_snacks.TabIndex = 1;
            this.bt_snacks.Text = "Snacks";
            this.bt_snacks.UseVisualStyleBackColor = false;
            this.bt_snacks.Click += new System.EventHandler(this.bt_snacks_Click);
            // 
            // bt_fruits
            // 
            this.bt_fruits.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bt_fruits.Location = new System.Drawing.Point(764, 356);
            this.bt_fruits.Margin = new System.Windows.Forms.Padding(4);
            this.bt_fruits.Name = "bt_fruits";
            this.bt_fruits.Size = new System.Drawing.Size(119, 39);
            this.bt_fruits.TabIndex = 3;
            this.bt_fruits.Text = "Fruits";
            this.bt_fruits.UseVisualStyleBackColor = false;
            this.bt_fruits.Click += new System.EventHandler(this.bt_fruits_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(750, 199);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 126);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(181, 89);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(133, 126);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(444, 163);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(133, 126);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_back.Location = new System.Drawing.Point(16, 15);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(76, 27);
            this.bt_back.TabIndex = 13;
            this.bt_back.Text = "<---";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 506);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bt_fruits);
            this.Controls.Add(this.bt_snacks);
            this.Controls.Add(this.bt_Grochery);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Grochery;
        private System.Windows.Forms.Button bt_snacks;
        private System.Windows.Forms.Button bt_fruits;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button bt_back;
    }
}

