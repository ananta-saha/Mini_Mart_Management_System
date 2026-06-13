
namespace dashboard
{
    partial class deletesnacks
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
            this.btn_dlt = new System.Windows.Forms.Button();
            this.txt_dltItem = new System.Windows.Forms.TextBox();
            this.Item_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(272, 304);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_dlt
            // 
            this.btn_dlt.Location = new System.Drawing.Point(465, 304);
            this.btn_dlt.Name = "btn_dlt";
            this.btn_dlt.Size = new System.Drawing.Size(75, 23);
            this.btn_dlt.TabIndex = 7;
            this.btn_dlt.Text = "Delete";
            this.btn_dlt.UseVisualStyleBackColor = true;
            this.btn_dlt.Click += new System.EventHandler(this.btn_dlt_Click);
            // 
            // txt_dltItem
            // 
            this.txt_dltItem.Location = new System.Drawing.Point(377, 152);
            this.txt_dltItem.Name = "txt_dltItem";
            this.txt_dltItem.Size = new System.Drawing.Size(163, 22);
            this.txt_dltItem.TabIndex = 6;
            // 
            // Item_Number
            // 
            this.Item_Number.AutoSize = true;
            this.Item_Number.Location = new System.Drawing.Point(231, 152);
            this.Item_Number.Name = "Item_Number";
            this.Item_Number.Size = new System.Drawing.Size(92, 17);
            this.Item_Number.TabIndex = 5;
            this.Item_Number.Text = "Item_Number";
            this.Item_Number.Click += new System.EventHandler(this.Item_Number_Click);
            // 
            // deletesnacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_dlt);
            this.Controls.Add(this.txt_dltItem);
            this.Controls.Add(this.Item_Number);
            this.Name = "deletesnacks";
            this.Text = "deletesnacks";
            this.Load += new System.EventHandler(this.deletesnacks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_dlt;
        private System.Windows.Forms.TextBox txt_dltItem;
        private System.Windows.Forms.Label Item_Number;
    }
}