
namespace dashboard
{
    partial class personal_care
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
            this.bt_back_personalCare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_back_personalCare
            // 
            this.bt_back_personalCare.ForeColor = System.Drawing.Color.Red;
            this.bt_back_personalCare.Location = new System.Drawing.Point(13, 13);
            this.bt_back_personalCare.Name = "bt_back_personalCare";
            this.bt_back_personalCare.Size = new System.Drawing.Size(45, 23);
            this.bt_back_personalCare.TabIndex = 0;
            this.bt_back_personalCare.Text = "<----";
            this.bt_back_personalCare.UseVisualStyleBackColor = true;
            this.bt_back_personalCare.Click += new System.EventHandler(this.bt_back_personalCare_Click);
            // 
            // personal_care
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_back_personalCare);
            this.Name = "personal_care";
            this.Text = "personal_care";
            this.Load += new System.EventHandler(this.personal_care_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back_personalCare;
    }
}