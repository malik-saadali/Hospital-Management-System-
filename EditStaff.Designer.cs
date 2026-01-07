namespace Hospital_Management_System
{
    partial class EditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStaff));
            this.back_btn = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.back_btn.Location = new System.Drawing.Point(97, 230);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 27);
            this.back_btn.TabIndex = 34;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(136, 188);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(149, 20);
            this.txtbox.TabIndex = 33;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edit_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.edit_btn.Location = new System.Drawing.Point(239, 230);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(88, 27);
            this.edit_btn.TabIndex = 32;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "ENTER USERNAME OF STAFF YOU WOULD LIKE TO EDIT";
            // 
            // EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(409, 347);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditStaff";
            this.Load += new System.EventHandler(this.EditStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Label label1;
    }
}