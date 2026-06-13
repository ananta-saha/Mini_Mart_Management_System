
namespace dashboard
{
    partial class Delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.Item_Number = new System.Windows.Forms.Label();
            this.txt_dltItem = new System.Windows.Forms.TextBox();
            this.btn_dlt_snacks = new System.Windows.Forms.Button();
            this.btn_back_snacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(84, 109);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 1;
            this.Item_Number.Text = "Item_Number";
            // 
            // txt_dltItem
            // 
            this.txt_dltItem.Location = new System.Drawing.Point(189, 109);
            this.txt_dltItem.Name = "txt_dltItem";
            this.txt_dltItem.Size = new System.Drawing.Size(163, 22);
            this.txt_dltItem.TabIndex = 2;
            // 
            // btn_dlt_snacks
            // 
            this.btn_dlt_snacks.Location = new System.Drawing.Point(361, 290);
            this.btn_dlt_snacks.Name = "btn_dlt_snacks";
            this.btn_dlt_snacks.Size = new System.Drawing.Size(75, 23);
            this.btn_dlt_snacks.TabIndex = 3;
            this.btn_dlt_snacks.Text = "Delete";
            this.btn_dlt_snacks.UseVisualStyleBackColor = true;
            this.btn_dlt_snacks.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // btn_back_snacks
            // 
            this.btn_back_snacks.Location = new System.Drawing.Point(212, 290);
            this.btn_back_snacks.Name = "btn_back_snacks";
            this.btn_back_snacks.Size = new System.Drawing.Size(75, 23);
            this.btn_back_snacks.TabIndex = 4;
            this.btn_back_snacks.Text = "Back";
            this.btn_back_snacks.UseVisualStyleBackColor = true;
            this.btn_back_snacks.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back_snacks);
            this.Controls.Add(this.btn_dlt_snacks);
            this.Controls.Add(this.txt_dltItem);
            this.Controls.Add(this.Item_Number);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Item_Number;
        private System.Windows.Forms.TextBox txt_dltItem;
        private System.Windows.Forms.Button btn_dlt_snacks;
        private System.Windows.Forms.Button btn_back_snacks;
    }
}