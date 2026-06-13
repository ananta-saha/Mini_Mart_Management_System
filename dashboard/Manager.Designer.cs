
namespace Manager
{
    partial class Manager
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
            this.Inventory_list = new System.Windows.Forms.Button();
            this.Stuff_List = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inventory_list
            // 
            this.Inventory_list.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inventory_list.Location = new System.Drawing.Point(212, 220);
            this.Inventory_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inventory_list.Name = "Inventory_list";
            this.Inventory_list.Size = new System.Drawing.Size(187, 74);
            this.Inventory_list.TabIndex = 0;
            this.Inventory_list.Text = "Inventory List";
            this.Inventory_list.UseVisualStyleBackColor = false;
            this.Inventory_list.Click += new System.EventHandler(this.Inventory_list_Click);
            // 
            // Stuff_List
            // 
            this.Stuff_List.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Stuff_List.Location = new System.Drawing.Point(572, 220);
            this.Stuff_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stuff_List.Name = "Stuff_List";
            this.Stuff_List.Size = new System.Drawing.Size(187, 74);
            this.Stuff_List.TabIndex = 1;
            this.Stuff_List.Text = "Stuff List";
            this.Stuff_List.UseVisualStyleBackColor = false;
            this.Stuff_List.Click += new System.EventHandler(this.Stuff_List_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(17, 16);
            this.bt_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(100, 28);
            this.bt_back.TabIndex = 2;
            this.bt_back.Text = "back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Inventory_list);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.Stuff_List);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manager";
            this.Text = "Maneger";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inventory_list;
        private System.Windows.Forms.Button Stuff_List;
        private System.Windows.Forms.Button bt_back;
    }
}

