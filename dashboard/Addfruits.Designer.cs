
namespace dashboard
{
    partial class Addfruits
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
            this.Btn_add_fruits = new System.Windows.Forms.Button();
            this.btn_back_fruits = new System.Windows.Forms.Button();
            this.txt_price_fruits = new System.Windows.Forms.TextBox();
            this.txt_quantity_fruits = new System.Windows.Forms.TextBox();
            this.txt_Name_fruits = new System.Windows.Forms.TextBox();
            this.txt_Number_fruits = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Item_Name = new System.Windows.Forms.Label();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_add_fruits
            // 
            this.Btn_add_fruits.Location = new System.Drawing.Point(445, 342);
            this.Btn_add_fruits.Name = "Btn_add_fruits";
            this.Btn_add_fruits.Size = new System.Drawing.Size(74, 36);
            this.Btn_add_fruits.TabIndex = 20;
            this.Btn_add_fruits.Text = "ADD";
            this.Btn_add_fruits.UseVisualStyleBackColor = true;
            this.Btn_add_fruits.Click += new System.EventHandler(this.Btn_add_fruits_Click);
            // 
            // btn_back_fruits
            // 
            this.btn_back_fruits.Location = new System.Drawing.Point(295, 342);
            this.btn_back_fruits.Name = "btn_back_fruits";
            this.btn_back_fruits.Size = new System.Drawing.Size(74, 36);
            this.btn_back_fruits.TabIndex = 19;
            this.btn_back_fruits.Text = "Back";
            this.btn_back_fruits.UseVisualStyleBackColor = true;
            this.btn_back_fruits.Click += new System.EventHandler(this.btn_back_fruits_Click);
            // 
            // txt_price_fruits
            // 
            this.txt_price_fruits.Location = new System.Drawing.Point(295, 254);
            this.txt_price_fruits.Name = "txt_price_fruits";
            this.txt_price_fruits.Size = new System.Drawing.Size(224, 22);
            this.txt_price_fruits.TabIndex = 18;
            // 
            // txt_quantity_fruits
            // 
            this.txt_quantity_fruits.Location = new System.Drawing.Point(295, 192);
            this.txt_quantity_fruits.Name = "txt_quantity_fruits";
            this.txt_quantity_fruits.Size = new System.Drawing.Size(224, 22);
            this.txt_quantity_fruits.TabIndex = 17;
            // 
            // txt_Name_fruits
            // 
            this.txt_Name_fruits.Location = new System.Drawing.Point(295, 135);
            this.txt_Name_fruits.Name = "txt_Name_fruits";
            this.txt_Name_fruits.Size = new System.Drawing.Size(224, 22);
            this.txt_Name_fruits.TabIndex = 16;
            // 
            // txt_Number_fruits
            // 
            this.txt_Number_fruits.Location = new System.Drawing.Point(295, 80);
            this.txt_Number_fruits.Name = "txt_Number_fruits";
            this.txt_Number_fruits.Size = new System.Drawing.Size(224, 22);
            this.txt_Number_fruits.TabIndex = 15;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(175, 244);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 14;
            this.Price.Text = "Price";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(175, 192);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 13;
            this.Quantity.Text = "Quantity";
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(175, 135);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 12;
            this.Item_Name.Text = "Item_Name";
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(175, 80);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 11;
            this.Item_Number.Text = "Item_Number";
            // 
            // Addfruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_add_fruits);
            this.Controls.Add(this.btn_back_fruits);
            this.Controls.Add(this.txt_price_fruits);
            this.Controls.Add(this.txt_quantity_fruits);
            this.Controls.Add(this.txt_Name_fruits);
            this.Controls.Add(this.txt_Number_fruits);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.Item_Number);
            this.Name = "Addfruits";
            this.Text = "Addfruits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_add_fruits;
        private System.Windows.Forms.Button btn_back_fruits;
        private System.Windows.Forms.TextBox txt_price_fruits;
        private System.Windows.Forms.TextBox txt_quantity_fruits;
        private System.Windows.Forms.TextBox txt_Name_fruits;
        private System.Windows.Forms.TextBox txt_Number_fruits;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.Label Item_Number;
    }
}