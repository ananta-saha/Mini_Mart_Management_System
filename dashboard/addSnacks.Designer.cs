
namespace dashboard
{
    partial class addSnacks
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
            this.Item_Number = new System.Windows.Forms.Label();
            this.Item_Name = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.Btn_add_snacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(137, 77);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 0;
            this.Item_Number.Text = "Item_Number";
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(137, 132);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 1;
            this.Item_Name.Text = "Item_Name";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(137, 189);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 2;
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(137, 241);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(257, 77);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(224, 22);
            this.txt_Number.TabIndex = 4;
            this.txt_Number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(257, 132);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(224, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(257, 189);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(224, 22);
            this.txt_quantity.TabIndex = 6;
            this.txt_quantity.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(257, 251);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(224, 22);
            this.txt_price.TabIndex = 7;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(257, 339);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 36);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Btn_add_snacks
            // 
            this.Btn_add_snacks.Location = new System.Drawing.Point(407, 339);
            this.Btn_add_snacks.Name = "Btn_add_snacks";
            this.Btn_add_snacks.Size = new System.Drawing.Size(74, 36);
            this.Btn_add_snacks.TabIndex = 10;
            this.Btn_add_snacks.Text = "ADD";
            this.Btn_add_snacks.UseVisualStyleBackColor = true;
            this.Btn_add_snacks.Click += new System.EventHandler(this.Btn_add_snacks_Click);
            // 
            // addSnacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_add_snacks);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.Item_Number);
            this.Name = "addSnacks";
            this.Text = "addSnacks";
            this.Load += new System.EventHandler(this.addSnacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Item_Number;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button Btn_add_snacks;
    }
}