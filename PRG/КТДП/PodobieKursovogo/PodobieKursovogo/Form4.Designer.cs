namespace PodobieKursovogo
{
    partial class MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            this.l_ok = new System.Windows.Forms.Label();
            this.l_mes1 = new System.Windows.Forms.Label();
            this.l_mes2 = new System.Windows.Forms.Label();
            this.l_mes3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_ok
            // 
            this.l_ok.AutoSize = true;
            this.l_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_ok.Font = new System.Drawing.Font("Franklin Gothic Demi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_ok.ForeColor = System.Drawing.Color.White;
            this.l_ok.Location = new System.Drawing.Point(181, 200);
            this.l_ok.Name = "l_ok";
            this.l_ok.Size = new System.Drawing.Size(59, 38);
            this.l_ok.TabIndex = 1;
            this.l_ok.Text = "OK";
            this.l_ok.Click += new System.EventHandler(this.l_ok_Click);
            this.l_ok.MouseLeave += new System.EventHandler(this.l_ok_MouseLeave);
            this.l_ok.MouseMove += new System.Windows.Forms.MouseEventHandler(this.l_ok_MouseMove);
            // 
            // l_mes1
            // 
            this.l_mes1.AutoSize = true;
            this.l_mes1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_mes1.ForeColor = System.Drawing.Color.White;
            this.l_mes1.Location = new System.Drawing.Point(21, 80);
            this.l_mes1.Name = "l_mes1";
            this.l_mes1.Size = new System.Drawing.Size(24, 25);
            this.l_mes1.TabIndex = 0;
            this.l_mes1.Text = "1";
            this.l_mes1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_mes1.Visible = false;
            // 
            // l_mes2
            // 
            this.l_mes2.AutoSize = true;
            this.l_mes2.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_mes2.ForeColor = System.Drawing.Color.White;
            this.l_mes2.Location = new System.Drawing.Point(80, 80);
            this.l_mes2.Name = "l_mes2";
            this.l_mes2.Size = new System.Drawing.Size(24, 25);
            this.l_mes2.TabIndex = 2;
            this.l_mes2.Text = "2";
            this.l_mes2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_mes2.Visible = false;
            // 
            // l_mes3
            // 
            this.l_mes3.AutoSize = true;
            this.l_mes3.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_mes3.ForeColor = System.Drawing.Color.White;
            this.l_mes3.Location = new System.Drawing.Point(50, 60);
            this.l_mes3.Name = "l_mes3";
            this.l_mes3.Size = new System.Drawing.Size(24, 25);
            this.l_mes3.TabIndex = 3;
            this.l_mes3.Text = "3";
            this.l_mes3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_mes3.Visible = false;
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(427, 247);
            this.ControlBox = false;
            this.Controls.Add(this.l_mes3);
            this.Controls.Add(this.l_mes2);
            this.Controls.Add(this.l_ok);
            this.Controls.Add(this.l_mes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_ok;
        public System.Windows.Forms.Label l_mes1;
        public System.Windows.Forms.Label l_mes2;
        public System.Windows.Forms.Label l_mes3;
    }
}