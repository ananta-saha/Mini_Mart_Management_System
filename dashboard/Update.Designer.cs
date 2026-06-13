
namespace dashboard
{
    partial class Update
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_updatePrice = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txt_updateQn = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txt_updateName = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.txt_updateNumber = new System.Windows.Forms.TextBox();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(329, 344);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(470, 344);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_updatePrice
            // 
            this.txt_updatePrice.Location = new System.Drawing.Point(329, 263);
            this.txt_updatePrice.Name = "txt_updatePrice";
            this.txt_updatePrice.Size = new System.Drawing.Size(255, 22);
            this.txt_updatePrice.TabIndex = 17;
            this.txt_updatePrice.TextChanged += new System.EventHandler(this.txt_updatePrice_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(216, 266);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 16;
            this.Price.Text = "Price";
            // 
            // txt_updateQn
            // 
            this.txt_updateQn.Location = new System.Drawing.Point(329, 193);
            this.txt_updateQn.Name = "txt_updateQn";
            this.txt_updateQn.Size = new System.Drawing.Size(255, 22);
            this.txt_updateQn.TabIndex = 15;
            this.txt_updateQn.TextChanged += new System.EventHandler(this.txt_updateQn_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(216, 193);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 14;
            this.Quantity.Text = "Quantity";
            // 
            // txt_updateName
            // 
            this.txt_updateName.Location = new System.Drawing.Point(329, 137);
            this.txt_updateName.Name = "txt_updateName";
            this.txt_updateName.Size = new System.Drawing.Size(255, 22);
            this.txt_updateName.TabIndex = 13;
            this.txt_updateName.TextChanged += new System.EventHandler(this.txt_updateName_TextChanged);
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(216, 137);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 12;
            this.Item_Name.Text = "Item_Name";
            // 
            // txt_updateNumber
            // 
            this.txt_updateNumber.Location = new System.Drawing.Point(329, 83);
            this.txt_updateNumber.Name = "txt_updateNumber";
            this.txt_updateNumber.Size = new System.Drawing.Size(255, 22);
            this.txt_updateNumber.TabIndex = 11;
            this.txt_updateNumber.TextChanged += new System.EventHandler(this.txt_updateNumber_TextChanged);
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(216, 83);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 10;
            this.Item_Number.Text = "Item_Number";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_updatePrice);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txt_updateQn);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_updateName);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.txt_updateNumber);
            this.Controls.Add(this.Item_Number);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_updatePrice;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txt_updateQn;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txt_updateName;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.TextBox txt_updateNumber;
        private System.Windows.Forms.Label Item_Number;
    }
}