
namespace dashboard
{
    partial class stationery
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
            this.bt_back_stationery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_back_stationery
            // 
            this.bt_back_stationery.ForeColor = System.Drawing.Color.Red;
            this.bt_back_stationery.Location = new System.Drawing.Point(13, 13);
            this.bt_back_stationery.Name = "bt_back_stationery";
            this.bt_back_stationery.Size = new System.Drawing.Size(42, 22);
            this.bt_back_stationery.TabIndex = 0;
            this.bt_back_stationery.Text = "<----";
            this.bt_back_stationery.UseVisualStyleBackColor = true;
            this.bt_back_stationery.Click += new System.EventHandler(this.bt_back_stationery_Click);
            // 
            // stationery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_back_stationery);
            this.Name = "stationery";
            this.Text = "stationery";
            this.Load += new System.EventHandler(this.stationery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_back_stationery;
    }
}