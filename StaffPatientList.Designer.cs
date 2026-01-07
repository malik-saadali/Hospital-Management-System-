namespace Hospital_Management_System
{
    partial class StaffPatientList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPatientList));
            this.label2 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(311, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 102;
            this.label2.Text = "Search by Firstname";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.edit_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.edit_btn.Location = new System.Drawing.Point(41, 482);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(130, 38);
            this.edit_btn.TabIndex = 101;
            this.edit_btn.Text = "Edit Patient";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.logout_btn.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.logout_btn.Location = new System.Drawing.Point(8, 6);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(57, 24);
            this.logout_btn.TabIndex = 100;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(148, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 36);
            this.label1.TabIndex = 99;
            this.label1.Text = "Patient list of the Hospital  ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Location = new System.Drawing.Point(237, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 20);
            this.textBox1.TabIndex = 98;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.search_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.search_btn.Location = new System.Drawing.Point(119, 428);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(88, 27);
            this.search_btn.TabIndex = 97;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 270);
            this.dataGridView1.TabIndex = 96;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.back_btn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.back_btn.Location = new System.Drawing.Point(578, 482);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 38);
            this.back_btn.TabIndex = 95;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // StaffPatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(688, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffPatientList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffPatientList";
            this.Load += new System.EventHandler(this.StaffPatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_btn;
    }
}