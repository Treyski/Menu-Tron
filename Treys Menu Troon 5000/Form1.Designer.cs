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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.btnDQ = new System.Windows.Forms.Button();
            this.btnRedRobins = new System.Windows.Forms.Button();
            this.btn54th = new System.Windows.Forms.Button();
            this.btnStar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbTitle
            // 
            this.txbTitle.BackColor = System.Drawing.Color.White;
            this.txbTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTitle.Enabled = false;
            this.txbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F, System.Drawing.FontStyle.Bold);
            this.txbTitle.Location = new System.Drawing.Point(86, 43);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(340, 41);
            this.txbTitle.TabIndex = 0;
            this.txbTitle.Text = "Me-menu-ory";
            this.txbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnDQ
            // 
            this.btnDQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnDQ.Location = new System.Drawing.Point(25, 116);
            this.btnDQ.Name = "btnDQ";
            this.btnDQ.Size = new System.Drawing.Size(213, 59);
            this.btnDQ.TabIndex = 1;
            this.btnDQ.Text = "Dairy Queen";
            this.btnDQ.UseVisualStyleBackColor = true;
            this.btnDQ.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRedRobins
            // 
            this.btnRedRobins.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnRedRobins.Location = new System.Drawing.Point(272, 238);
            this.btnRedRobins.Name = "btnRedRobins";
            this.btnRedRobins.Size = new System.Drawing.Size(211, 61);
            this.btnRedRobins.TabIndex = 2;
            this.btnRedRobins.Text = "Red Robins";
            this.btnRedRobins.UseVisualStyleBackColor = true;
            this.btnRedRobins.Click += new System.EventHandler(this.btnRedRobins_Click);
            // 
            // btn54th
            // 
            this.btn54th.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn54th.Location = new System.Drawing.Point(25, 238);
            this.btn54th.Name = "btn54th";
            this.btn54th.Size = new System.Drawing.Size(213, 60);
            this.btn54th.TabIndex = 3;
            this.btn54th.Text = "54th Street";
            this.btn54th.UseVisualStyleBackColor = true;
            this.btn54th.Click += new System.EventHandler(this.btn54th_Click);
            // 
            // btnStar
            // 
            this.btnStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnStar.Location = new System.Drawing.Point(270, 116);
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(213, 59);
            this.btnStar.TabIndex = 4;
            this.btnStar.Text = "Starbucks";
            this.btnStar.UseVisualStyleBackColor = true;
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.btnStar);
            this.Controls.Add(this.btn54th);
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
        private System.Windows.Forms.Button btn54th;
        private System.Windows.Forms.Button btnStar;
    }
}

