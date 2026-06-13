
namespace dashboard
{
    partial class UpdateFruits
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
            this.btn_Update_fruits = new System.Windows.Forms.Button();
            this.txt_updatePrice_fruits = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txt_updateQn_fruits = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txt_updateName_fruits = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.txt_updateNumber_fruits = new System.Windows.Forms.TextBox();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back_fruits
            // 
            this.btn_back_fruits.Location = new System.Drawing.Point(329, 344);
            this.btn_back_fruits.Name = "btn_back_fruits";
            this.btn_back_fruits.Size = new System.Drawing.Size(75, 23);
            this.btn_back_fruits.TabIndex = 39;
            this.btn_back_fruits.Text = "Back";
            this.btn_back_fruits.UseVisualStyleBackColor = true;
            this.btn_back_fruits.Click += new System.EventHandler(this.btn_back_fruits_Click);
            // 
            // btn_Update_fruits
            // 
            this.btn_Update_fruits.Location = new System.Drawing.Point(470, 344);
            this.btn_Update_fruits.Name = "btn_Update_fruits";
            this.btn_Update_fruits.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_fruits.TabIndex = 38;
            this.btn_Update_fruits.Text = "Update";
            this.btn_Update_fruits.UseVisualStyleBackColor = true;
            this.btn_Update_fruits.Click += new System.EventHandler(this.btn_Update_fruits_Click);
            // 
            // txt_updatePrice_fruits
            // 
            this.txt_updatePrice_fruits.Location = new System.Drawing.Point(329, 263);
            this.txt_updatePrice_fruits.Name = "txt_updatePrice_fruits";
            this.txt_updatePrice_fruits.Size = new System.Drawing.Size(255, 22);
            this.txt_updatePrice_fruits.TabIndex = 37;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(216, 266);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 36;
            this.Price.Text = "Price";
            // 
            // txt_updateQn_fruits
            // 
            this.txt_updateQn_fruits.Location = new System.Drawing.Point(329, 193);
            this.txt_updateQn_fruits.Name = "txt_updateQn_fruits";
            this.txt_updateQn_fruits.Size = new System.Drawing.Size(255, 22);
            this.txt_updateQn_fruits.TabIndex = 35;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(216, 193);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 34;
            this.Quantity.Text = "Quantity";
            // 
            // txt_updateName_fruits
            // 
            this.txt_updateName_fruits.Location = new System.Drawing.Point(329, 137);
            this.txt_updateName_fruits.Name = "txt_updateName_fruits";
            this.txt_updateName_fruits.Size = new System.Drawing.Size(255, 22);
            this.txt_updateName_fruits.TabIndex = 33;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(216, 137);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 32;
            this.Item_Name.Text = "Item_Name";
            // 
            // txt_updateNumber_fruits
            // 
            this.txt_updateNumber_fruits.Location = new System.Drawing.Point(329, 83);
            this.txt_updateNumber_fruits.Name = "txt_updateNumber_fruits";
            this.txt_updateNumber_fruits.Size = new System.Drawing.Size(255, 22);
            this.txt_updateNumber_fruits.TabIndex = 31;
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(216, 83);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 30;
            this.Item_Number.Text = "Item_Number";
            // 
            // UpdateFruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_fruits);
            this.Controls.Add(this.btn_Update_fruits);
            this.Controls.Add(this.txt_updatePrice_fruits);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txt_updateQn_fruits);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_updateName_fruits);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.txt_updateNumber_fruits);
            this.Controls.Add(this.Item_Number);
            this.Name = "UpdateFruits";
            this.Text = "UpdateFruits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_fruits;
        private System.Windows.Forms.Button btn_Update_fruits;
        private System.Windows.Forms.TextBox txt_updatePrice_fruits;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txt_updateQn_fruits;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txt_updateName_fruits;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.TextBox txt_updateNumber_fruits;
        private System.Windows.Forms.Label Item_Number;
    }
}