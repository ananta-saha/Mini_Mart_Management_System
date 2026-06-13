
namespace dashboard
{
    partial class DeleteFruits
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
            this.btn_back_fruits = new System.Windows.Forms.Button();
            this.btn_dlt_fruits = new System.Windows.Forms.Button();
            this.txt_dltItem_fruits = new System.Windows.Forms.TextBox();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back_fruits
            // 
            this.btn_back_fruits.Location = new System.Drawing.Point(238, 287);
            this.btn_back_fruits.Name = "btn_back_fruits";
            this.btn_back_fruits.Size = new System.Drawing.Size(75, 23);
            this.btn_back_fruits.TabIndex = 12;
            this.btn_back_fruits.Text = "Back";
            this.btn_back_fruits.UseVisualStyleBackColor = true;
            this.btn_back_fruits.Click += new System.EventHandler(this.btn_back_fruits_Click);
            // 
            // btn_dlt_fruits
            // 
            this.btn_dlt_fruits.Location = new System.Drawing.Point(431, 287);
            this.btn_dlt_fruits.Name = "btn_dlt_fruits";
            this.btn_dlt_fruits.Size = new System.Drawing.Size(75, 23);
            this.btn_dlt_fruits.TabIndex = 11;
            this.btn_dlt_fruits.Text = "Delete";
            this.btn_dlt_fruits.UseVisualStyleBackColor = true;
            this.btn_dlt_fruits.Click += new System.EventHandler(this.btn_dlt_fruits_Click);
            // 
            // txt_dltItem_fruits
            // 
            this.txt_dltItem_fruits.Location = new System.Drawing.Point(343, 135);
            this.txt_dltItem_fruits.Name = "txt_dltItem_fruits";
            this.txt_dltItem_fruits.Size = new System.Drawing.Size(163, 22);
            this.txt_dltItem_fruits.TabIndex = 10;
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(197, 135);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 9;
            this.Item_Number.Text = "Item_Number";
            // 
            // DeleteFruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_fruits);
            this.Controls.Add(this.btn_dlt_fruits);
            this.Controls.Add(this.txt_dltItem_fruits);
            this.Controls.Add(this.Item_Number);
            this.Name = "DeleteFruits";
            this.Text = "DeleteFruits";
            this.Load += new System.EventHandler(this.DeleteFruits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_fruits;
        private System.Windows.Forms.Button btn_dlt_fruits;
        private System.Windows.Forms.TextBox txt_dltItem_fruits;
        private System.Windows.Forms.Label Item_Number;
    }
}