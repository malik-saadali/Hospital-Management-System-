namespace Hospital_Management_System
{
    partial class StaffSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSearch));
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
            this.logout_btn.Location = new System.Drawing.Point(7, 386);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(57, 24);
            this.logout_btn.TabIndex = 101;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.back_btn.Location = new System.Drawing.Point(343, 362);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 38);
            this.back_btn.TabIndex = 100;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 246);
            this.dataGridView1.TabIndex = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 98;
            this.label1.Text = "SEARCH RESULT:";
            // 
            // StaffSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 424);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffSearch";
            this.Load += new System.EventHandler(this.StaffSearch_Load);
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