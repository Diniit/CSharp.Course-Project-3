namespace PodobieKursovogo
{
    partial class Options
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
            this.lVr = new System.Windows.Forms.Label();
            this.b_kartinka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_exit
            // 
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.Image = global::PodobieKursovogo.Properties.Resources.закрыть;
            this.pb_exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb_exit.Location = new System.Drawing.Point(620, 0);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(30, 30);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_exit.TabIndex = 187;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            this.pb_exit.MouseLeave += new System.EventHandler(this.pb_exit_MouseLeave);
            this.pb_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_exit_MouseMove);
            // 
            // lVr
            // 
            this.lVr.AutoSize = true;
            this.lVr.Font = new System.Drawing.Font("Consolas", 15F);
            this.lVr.ForeColor = System.Drawing.Color.White;
            this.lVr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lVr.Location = new System.Drawing.Point(30, 30);
            this.lVr.Name = "lVr";
            this.lVr.Size = new System.Drawing.Size(223, 29);
            this.lVr.TabIndex = 188;
            this.lVr.Text = "ФОНОВЫЙ РИСУНОК";
            this.lVr.Visible = false;
            // 
            // b_kartinka
            // 
            this.b_kartinka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.b_kartinka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_kartinka.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.b_kartinka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.b_kartinka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.b_kartinka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_kartinka.Font = new System.Drawing.Font("Franklin Gothic Heavy", 13.8F);
            this.b_kartinka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b_kartinka.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b_kartinka.Location = new System.Drawing.Point(50, 70);
            this.b_kartinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_kartinka.Name = "b_kartinka";
            this.b_kartinka.Size = new System.Drawing.Size(170, 50);
            this.b_kartinka.TabIndex = 189;
            this.b_kartinka.Text = "ЗАГРУЗИТЬ";
            this.b_kartinka.UseVisualStyleBackColor = false;
            this.b_kartinka.Click += new System.EventHandler(this.b_zhad_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(653, 452);
            this.Controls.Add(this.b_kartinka);
            this.Controls.Add(this.lVr);
            this.Controls.Add(this.pb_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Опции";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_exit;
        private System.Windows.Forms.Label lVr;
        private System.Windows.Forms.Button b_kartinka;
    }
}