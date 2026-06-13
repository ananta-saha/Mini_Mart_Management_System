
namespace dashboard
{
    partial class UpdateSnacks
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
            this.btn_back_snacks = new System.Windows.Forms.Button();
            this.btn_Update_snacks = new System.Windows.Forms.Button();
            this.txt_updatePrice_snakcs = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.txt_updateQn_snakcs = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.txt_updateName_snacks = new System.Windows.Forms.TextBox();
            this.Item_Name = new System.Windows.Forms.Label();
            this.txt_updateNumber_snacks = new System.Windows.Forms.TextBox();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back_snacks
            // 
            this.btn_back_snacks.Location = new System.Drawing.Point(329, 344);
            this.btn_back_snacks.Name = "btn_back_snacks";
            this.btn_back_snacks.Size = new System.Drawing.Size(75, 23);
            this.btn_back_snacks.TabIndex = 29;
            this.btn_back_snacks.Text = "Back";
            this.btn_back_snacks.UseVisualStyleBackColor = true;
            this.btn_back_snacks.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Update_snacks
            // 
            this.btn_Update_snacks.Location = new System.Drawing.Point(470, 344);
            this.btn_Update_snacks.Name = "btn_Update_snacks";
            this.btn_Update_snacks.Size = new System.Drawing.Size(75, 23);
            this.btn_Update_snacks.TabIndex = 28;
            this.btn_Update_snacks.Text = "Update";
            this.btn_Update_snacks.UseVisualStyleBackColor = true;
            this.btn_Update_snacks.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_updatePrice_snakcs
            // 
            this.txt_updatePrice_snakcs.Location = new System.Drawing.Point(329, 263);
            this.txt_updatePrice_snakcs.Name = "txt_updatePrice_snakcs";
            this.txt_updatePrice_snakcs.Size = new System.Drawing.Size(255, 22);
            this.txt_updatePrice_snakcs.TabIndex = 27;
            this.txt_updatePrice_snakcs.TextChanged += new System.EventHandler(this.txt_updatePrice_TextChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(216, 266);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(40, 17);
            this.Price.TabIndex = 26;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // txt_updateQn_snakcs
            // 
            this.txt_updateQn_snakcs.Location = new System.Drawing.Point(329, 193);
            this.txt_updateQn_snakcs.Name = "txt_updateQn_snakcs";
            this.txt_updateQn_snakcs.Size = new System.Drawing.Size(255, 22);
            this.txt_updateQn_snakcs.TabIndex = 25;
            this.txt_updateQn_snakcs.TextChanged += new System.EventHandler(this.txt_updateQn_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(216, 193);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(61, 17);
            this.Quantity.TabIndex = 24;
            this.Quantity.Text = "Quantity";
            this.Quantity.Click += new System.EventHandler(this.Quantity_Click);
            // 
            // txt_updateName_snacks
            // 
            this.txt_updateName_snacks.Location = new System.Drawing.Point(329, 137);
            this.txt_updateName_snacks.Name = "txt_updateName_snacks";
            this.txt_updateName_snacks.Size = new System.Drawing.Size(255, 22);
            this.txt_updateName_snacks.TabIndex = 23;
            this.txt_updateName_snacks.TextChanged += new System.EventHandler(this.txt_updateName_TextChanged);
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSize = true;
            this.Item_Name.Location = new System.Drawing.Point(216, 137);
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Size = new System.Drawing.Size(79, 17);
            this.Item_Name.TabIndex = 22;
            this.Item_Name.Text = "Item_Name";
            this.Item_Name.Click += new System.EventHandler(this.Item_Name_Click);
            // 
            // txt_updateNumber_snacks
            // 
            this.txt_updateNumber_snacks.Location = new System.Drawing.Point(329, 83);
            this.txt_updateNumber_snacks.Name = "txt_updateNumber_snacks";
            this.txt_updateNumber_snacks.Size = new System.Drawing.Size(255, 22);
            this.txt_updateNumber_snacks.TabIndex = 21;
            this.txt_updateNumber_snacks.TextChanged += new System.EventHandler(this.txt_updateNumber_TextChanged);
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(216, 83);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 20;
            this.Item_Number.Text = "Item_Number";
            this.Item_Number.Click += new System.EventHandler(this.Item_Number_Click);
            // 
            // UpdateSnacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_snacks);
            this.Controls.Add(this.btn_Update_snacks);
            this.Controls.Add(this.txt_updatePrice_snakcs);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txt_updateQn_snakcs);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.txt_updateName_snacks);
            this.Controls.Add(this.Item_Name);
            this.Controls.Add(this.txt_updateNumber_snacks);
            this.Controls.Add(this.Item_Number);
            this.Name = "UpdateSnacks";
            this.Text = "UpdateSnacks";
            this.Load += new System.EventHandler(this.UpdateSnacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back_snacks;
        private System.Windows.Forms.Button btn_Update_snacks;
        private System.Windows.Forms.TextBox txt_updatePrice_snakcs;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox txt_updateQn_snakcs;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox txt_updateName_snacks;
        private System.Windows.Forms.Label Item_Name;
        private System.Windows.Forms.TextBox txt_updateNumber_snacks;
        private System.Windows.Forms.Label Item_Number;
    }
}