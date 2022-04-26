namespace DropEstimeter
{
    partial class Form2
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
            this.Close_APP = new System.Windows.Forms.Button();
            this.HOME = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drop1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_Sql = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Optimize_Et = new System.Windows.Forms.Button();
            this.SqlClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_APP
            // 
            this.Close_APP.BackColor = System.Drawing.Color.Red;
            this.Close_APP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_APP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_APP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_APP.Location = new System.Drawing.Point(12, 444);
            this.Close_APP.Name = "Close_APP";
            this.Close_APP.Size = new System.Drawing.Size(223, 36);
            this.Close_APP.TabIndex = 7;
            this.Close_APP.Text = "Close App";
            this.Close_APP.UseVisualStyleBackColor = false;
            this.Close_APP.Click += new System.EventHandler(this.Close_APP_Click);
            // 
            // HOME
            // 
            this.HOME.BackColor = System.Drawing.Color.Red;
            this.HOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HOME.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HOME.Location = new System.Drawing.Point(750, 444);
            this.HOME.Name = "HOME";
            this.HOME.Size = new System.Drawing.Size(306, 36);
            this.HOME.TabIndex = 23;
            this.HOME.Text = "HOME";
            this.HOME.UseVisualStyleBackColor = false;
            this.HOME.Click += new System.EventHandler(this.HOME_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Drop1,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 395);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "OyuncuId";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "OyuncuHit";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TotalDamage";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Wep0";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Wep1";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Wep2";
            this.Column6.Name = "Column6";
            // 
            // Drop1
            // 
            this.Drop1.HeaderText = "Wep3";
            this.Drop1.Name = "Drop1";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Wep4";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Wep5";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "DropCont";
            this.Column9.Name = "Column9";
            // 
            // Save_Sql
            // 
            this.Save_Sql.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Save_Sql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_Sql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Sql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Sql.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save_Sql.Location = new System.Drawing.Point(419, 444);
            this.Save_Sql.Name = "Save_Sql";
            this.Save_Sql.Size = new System.Drawing.Size(150, 36);
            this.Save_Sql.TabIndex = 26;
            this.Save_Sql.Text = "Sql\'e Gönder";
            this.Save_Sql.UseVisualStyleBackColor = false;
            this.Save_Sql.Click += new System.EventHandler(this.Save_Sql_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "E sim Drop Estimater";
            // 
            // Optimize_Et
            // 
            this.Optimize_Et.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Optimize_Et.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Optimize_Et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Optimize_Et.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optimize_Et.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Optimize_Et.Location = new System.Drawing.Point(251, 444);
            this.Optimize_Et.Name = "Optimize_Et";
            this.Optimize_Et.Size = new System.Drawing.Size(150, 36);
            this.Optimize_Et.TabIndex = 28;
            this.Optimize_Et.Text = "Optimize Et";
            this.Optimize_Et.UseVisualStyleBackColor = false;
            this.Optimize_Et.Click += new System.EventHandler(this.Optimize_Et_Click);
            // 
            // SqlClear
            // 
            this.SqlClear.BackColor = System.Drawing.Color.DarkTurquoise;
            this.SqlClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SqlClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SqlClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SqlClear.Location = new System.Drawing.Point(584, 444);
            this.SqlClear.Name = "SqlClear";
            this.SqlClear.Size = new System.Drawing.Size(150, 36);
            this.SqlClear.TabIndex = 29;
            this.SqlClear.Text = "Sql.Clear";
            this.SqlClear.UseVisualStyleBackColor = false;
            this.SqlClear.Click += new System.EventHandler(this.SqlClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1068, 504);
            this.Controls.Add(this.SqlClear);
            this.Controls.Add(this.Optimize_Et);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save_Sql);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HOME);
            this.Controls.Add(this.Close_APP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close_APP;
        private System.Windows.Forms.Button HOME;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drop1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button Save_Sql;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Optimize_Et;
        private System.Windows.Forms.Button SqlClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}