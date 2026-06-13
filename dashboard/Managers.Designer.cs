
namespace dashboard
{
    partial class Managers
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
            this.Back_managers = new System.Windows.Forms.Button();
            this.btn_stuff = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back_managers
            // 
            this.Back_managers.Location = new System.Drawing.Point(26, 31);
            this.Back_managers.Name = "Back_managers";
            this.Back_managers.Size = new System.Drawing.Size(86, 38);
            this.Back_managers.TabIndex = 0;
            this.Back_managers.Text = "Back";
            this.Back_managers.UseVisualStyleBackColor = true;
            this.Back_managers.Click += new System.EventHandler(this.exit_managers_Click);
            // 
            // btn_stuff
            // 
            this.btn_stuff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_stuff.Location = new System.Drawing.Point(419, 187);
            this.btn_stuff.Name = "btn_stuff";
            this.btn_stuff.Size = new System.Drawing.Size(118, 61);
            this.btn_stuff.TabIndex = 1;
            this.btn_stuff.Text = "Stuff";
            this.btn_stuff.UseVisualStyleBackColor = false;
            this.btn_stuff.Click += new System.EventHandler(this.btn_stuff_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_manager.Location = new System.Drawing.Point(195, 180);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(112, 68);
            this.btn_manager.TabIndex = 2;
            this.btn_manager.Text = "Inventory";
            this.btn_manager.UseVisualStyleBackColor = false;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // Managers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_stuff);
            this.Controls.Add(this.Back_managers);
            this.Name = "Managers";
            this.Text = "Managers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_managers;
        private System.Windows.Forms.Button btn_stuff;
        private System.Windows.Forms.Button btn_manager;
    }
}