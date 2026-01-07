namespace Hospital_Management_System
{
    partial class StaffPatientSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPatientSearch));
            this.logout_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logout_btn.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.logout_btn.Location = new System.Drawing.Point(6, 382);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(57, 24);
            this.logout_btn.TabIndex = 105;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.back_btn.Location = new System.Drawing.Point(352, 359);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 38);
            this.back_btn.TabIndex = 104;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 246);
            this.dataGridView1.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 36);
            this.label1.TabIndex = 102;
            this.label1.Text = "SEARCH RESULT:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StaffPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 416);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffPatientSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPatientSearch";
            this.Load += new System.EventHandler(this.StaffPatientSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}