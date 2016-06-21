namespace Treys_Menu_Troon_5000
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
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.btnDQ = new System.Windows.Forms.Button();
            this.btnRedRobins = new System.Windows.Forms.Button();
            this.btnPeiWei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTitle
            // 
            this.txbTitle.BackColor = System.Drawing.Color.Lime;
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitle.Location = new System.Drawing.Point(98, 30);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(315, 31);
            this.txbTitle.TabIndex = 0;
            this.txbTitle.Text = "Trey\'s Menu Tron 5000";
            this.txbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnDQ
            // 
            this.btnDQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDQ.Location = new System.Drawing.Point(147, 91);
            this.btnDQ.Name = "btnDQ";
            this.btnDQ.Size = new System.Drawing.Size(213, 41);
            this.btnDQ.TabIndex = 1;
            this.btnDQ.Text = "Dairy Queen";
            this.btnDQ.UseVisualStyleBackColor = true;
            this.btnDQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRedRobins
            // 
            this.btnRedRobins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRedRobins.Location = new System.Drawing.Point(147, 163);
            this.btnRedRobins.Name = "btnRedRobins";
            this.btnRedRobins.Size = new System.Drawing.Size(211, 44);
            this.btnRedRobins.TabIndex = 2;
            this.btnRedRobins.Text = "Red Robins";
            this.btnRedRobins.UseVisualStyleBackColor = true;
            // 
            // btnPeiWei
            // 
            this.btnPeiWei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPeiWei.Location = new System.Drawing.Point(145, 237);
            this.btnPeiWei.Name = "btnPeiWei";
            this.btnPeiWei.Size = new System.Drawing.Size(213, 43);
            this.btnPeiWei.TabIndex = 3;
            this.btnPeiWei.Text = "Pei Wei";
            this.btnPeiWei.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.btnPeiWei);
            this.Controls.Add(this.btnRedRobins);
            this.Controls.Add(this.btnDQ);
            this.Controls.Add(this.txbTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Button btnDQ;
        private System.Windows.Forms.Button btnRedRobins;
        private System.Windows.Forms.Button btnPeiWei;
    }
}

