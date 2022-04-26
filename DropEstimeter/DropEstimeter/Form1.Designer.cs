namespace DropEstimeter
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Find_Data = new System.Windows.Forms.Button();
            this.Close_APP = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Save_Data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ss = new System.Windows.Forms.ListBox();
            this.nextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(670, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://deriva.e-sim.org/apiFights.html?battleId=1857&roundId=1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Find_Data
            // 
            this.Find_Data.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Find_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Find_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find_Data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Find_Data.Location = new System.Drawing.Point(34, 97);
            this.Find_Data.Name = "Find_Data";
            this.Find_Data.Size = new System.Drawing.Size(119, 36);
            this.Find_Data.TabIndex = 5;
            this.Find_Data.Text = "Find Data";
            this.Find_Data.UseVisualStyleBackColor = false;
            this.Find_Data.Click += new System.EventHandler(this.Find_Data_Click);
            // 
            // Close_APP
            // 
            this.Close_APP.BackColor = System.Drawing.Color.Red;
            this.Close_APP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_APP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_APP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_APP.Location = new System.Drawing.Point(34, 444);
            this.Close_APP.Name = "Close_APP";
            this.Close_APP.Size = new System.Drawing.Size(155, 36);
            this.Close_APP.TabIndex = 6;
            this.Close_APP.Text = "Close App";
            this.Close_APP.UseVisualStyleBackColor = false;
            this.Close_APP.Click += new System.EventHandler(this.Close_APP_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Yellow;
            this.richTextBox2.Location = new System.Drawing.Point(-5, 139);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(867, 10);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(34, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(670, 23);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "C:\\Users\\Taha\\Desktop";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.Yellow;
            this.richTextBox3.Location = new System.Drawing.Point(-5, 395);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(929, 10);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // Save_Data
            // 
            this.Save_Data.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Save_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save_Data.Enabled = false;
            this.Save_Data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Data.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save_Data.Location = new System.Drawing.Point(34, 203);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(119, 36);
            this.Save_Data.TabIndex = 15;
            this.Save_Data.Text = "Save Data";
            this.Save_Data.UseVisualStyleBackColor = false;
            this.Save_Data.Click += new System.EventHandler(this.Save_Data_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "E sim Drop Estimater";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ss
            // 
            this.ss.FormattingEnabled = true;
            this.ss.Location = new System.Drawing.Point(34, 263);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(670, 108);
            this.ss.TabIndex = 19;
            // 
            // nextPage
            // 
            this.nextPage.BackColor = System.Drawing.Color.DarkTurquoise;
            this.nextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextPage.Location = new System.Drawing.Point(556, 444);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(148, 36);
            this.nextPage.TabIndex = 20;
            this.nextPage.Text = "Next Page";
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(735, 492);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save_Data);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Close_APP);
            this.Controls.Add(this.Find_Data);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Find_Data;
        private System.Windows.Forms.Button Close_APP;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Save_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ss;
        private System.Windows.Forms.Button nextPage;
    }
}

