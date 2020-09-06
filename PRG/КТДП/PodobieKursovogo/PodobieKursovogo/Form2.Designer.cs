namespace PodobieKursovogo
{
    partial class fAvtor
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
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_exit
            // 
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.Image = global::PodobieKursovogo.Properties.Resources.закрыть;
            this.pb_exit.Location = new System.Drawing.Point(590, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 187;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            this.pb_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_exit_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(80, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 30);
            this.label1.TabIndex = 188;
            this.label1.Text = "НЕДОРАЗРАБОТЧИК СИЯ ПРОГРАММЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(180, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 30);
            this.label2.TabIndex = 188;
            this.label2.Text = "ПОЧЕРНЯЕВА Д. Н.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(180, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 30);
            this.label3.TabIndex = 189;
            this.label3.Text = "ПОЧЕРНЯЕВА Д. Н.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(120, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 30);
            this.label4.TabIndex = 190;
            this.label4.Text = "ДИЗАЙНЕР СИЯ ПРОГРАММЫ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(140, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 30);
            this.label6.TabIndex = 192;
            this.label6.Text = "НАПИСАТЬ РАЗРАБОТЧИКУ";
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // fAvtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(623, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAvtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}