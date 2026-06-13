
namespace dashboard
{
    partial class StaffInvent
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
            this.btn_Backstuff = new System.Windows.Forms.Button();
            this.btnFruitsStuff = new System.Windows.Forms.Button();
            this.btnStuffSnacks = new System.Windows.Forms.Button();
            this.btnStuffHrocery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Backstuff
            // 
            this.btn_Backstuff.Location = new System.Drawing.Point(26, 29);
            this.btn_Backstuff.Name = "btn_Backstuff";
            this.btn_Backstuff.Size = new System.Drawing.Size(75, 23);
            this.btn_Backstuff.TabIndex = 0;
            this.btn_Backstuff.Text = "Back";
            this.btn_Backstuff.UseVisualStyleBackColor = true;
            this.btn_Backstuff.Click += new System.EventHandler(this.btn_Backstuff_Click);
            // 
            // btnFruitsStuff
            // 
            this.btnFruitsStuff.Location = new System.Drawing.Point(539, 185);
            this.btnFruitsStuff.Name = "btnFruitsStuff";
            this.btnFruitsStuff.Size = new System.Drawing.Size(121, 59);
            this.btnFruitsStuff.TabIndex = 1;
            this.btnFruitsStuff.Text = "Fruits";
            this.btnFruitsStuff.UseVisualStyleBackColor = true;
            this.btnFruitsStuff.Click += new System.EventHandler(this.btnFruitsStuff_Click);
            // 
            // btnStuffSnacks
            // 
            this.btnStuffSnacks.Location = new System.Drawing.Point(324, 185);
            this.btnStuffSnacks.Name = "btnStuffSnacks";
            this.btnStuffSnacks.Size = new System.Drawing.Size(123, 59);
            this.btnStuffSnacks.TabIndex = 2;
            this.btnStuffSnacks.Text = "Snacks";
            this.btnStuffSnacks.UseVisualStyleBackColor = true;
            this.btnStuffSnacks.Click += new System.EventHandler(this.btnStuffSnacks_Click);
            // 
            // btnStuffHrocery
            // 
            this.btnStuffHrocery.Location = new System.Drawing.Point(134, 185);
            this.btnStuffHrocery.Name = "btnStuffHrocery";
            this.btnStuffHrocery.Size = new System.Drawing.Size(106, 59);
            this.btnStuffHrocery.TabIndex = 3;
            this.btnStuffHrocery.Text = "Grocery";
            this.btnStuffHrocery.UseVisualStyleBackColor = true;
            this.btnStuffHrocery.Click += new System.EventHandler(this.btnStuffHrocery_Click);
            // 
            // StaffInvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStuffHrocery);
            this.Controls.Add(this.btnStuffSnacks);
            this.Controls.Add(this.btnFruitsStuff);
            this.Controls.Add(this.btn_Backstuff);
            this.Name = "StaffInvent";
            this.Text = "StaffInvent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Backstuff;
        private System.Windows.Forms.Button btnFruitsStuff;
        private System.Windows.Forms.Button btnStuffSnacks;
        private System.Windows.Forms.Button btnStuffHrocery;
    }
}