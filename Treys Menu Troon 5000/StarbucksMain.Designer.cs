namespace Treys_Menu_Troon_5000
{
    partial class StarbucksMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarbucksMain));
            this.btnFrap = new System.Windows.Forms.Button();
            this.btnCof = new System.Windows.Forms.Button();
            this.btnRe = new System.Windows.Forms.Button();
            this.btnSm = new System.Windows.Forms.Button();
            this.btnESp = new System.Windows.Forms.Button();
            this.btnTe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrap
            // 
            this.btnFrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnFrap.Location = new System.Drawing.Point(34, 184);
            this.btnFrap.Margin = new System.Windows.Forms.Padding(4);
            this.btnFrap.Name = "btnFrap";
            this.btnFrap.Size = new System.Drawing.Size(233, 74);
            this.btnFrap.TabIndex = 1;
            this.btnFrap.Text = "Frappuccinos";
            this.btnFrap.UseVisualStyleBackColor = true;
            this.btnFrap.Click += new System.EventHandler(this.btnFrap_Click);
            // 
            // btnCof
            // 
            this.btnCof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCof.Location = new System.Drawing.Point(34, 22);
            this.btnCof.Margin = new System.Windows.Forms.Padding(4);
            this.btnCof.Name = "btnCof";
            this.btnCof.Size = new System.Drawing.Size(233, 74);
            this.btnCof.TabIndex = 2;
            this.btnCof.Text = "Coffee";
            this.btnCof.UseVisualStyleBackColor = true;
            this.btnCof.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRe
            // 
            this.btnRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRe.Location = new System.Drawing.Point(34, 333);
            this.btnRe.Margin = new System.Windows.Forms.Padding(4);
            this.btnRe.Name = "btnRe";
            this.btnRe.Size = new System.Drawing.Size(233, 74);
            this.btnRe.TabIndex = 3;
            this.btnRe.Text = "Refreshers";
            this.btnRe.UseVisualStyleBackColor = true;
            this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
            // 
            // btnSm
            // 
            this.btnSm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSm.Location = new System.Drawing.Point(308, 333);
            this.btnSm.Margin = new System.Windows.Forms.Padding(4);
            this.btnSm.Name = "btnSm";
            this.btnSm.Size = new System.Drawing.Size(233, 74);
            this.btnSm.TabIndex = 4;
            this.btnSm.Text = "Smoothies";
            this.btnSm.UseVisualStyleBackColor = true;
            this.btnSm.Click += new System.EventHandler(this.btnSm_Click);
            // 
            // btnESp
            // 
            this.btnESp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnESp.Location = new System.Drawing.Point(308, 22);
            this.btnESp.Margin = new System.Windows.Forms.Padding(4);
            this.btnESp.Name = "btnESp";
            this.btnESp.Size = new System.Drawing.Size(233, 74);
            this.btnESp.TabIndex = 5;
            this.btnESp.Text = "Espresso";
            this.btnESp.UseVisualStyleBackColor = true;
            this.btnESp.Click += new System.EventHandler(this.btnESp_Click);
            // 
            // btnTe
            // 
            this.btnTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnTe.Location = new System.Drawing.Point(308, 184);
            this.btnTe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTe.Name = "btnTe";
            this.btnTe.Size = new System.Drawing.Size(233, 74);
            this.btnTe.TabIndex = 6;
            this.btnTe.Text = "Tea";
            this.btnTe.UseVisualStyleBackColor = true;
            this.btnTe.Click += new System.EventHandler(this.btnTe_Click);
            // 
            // StarbucksMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 439);
            this.Controls.Add(this.btnTe);
            this.Controls.Add(this.btnESp);
            this.Controls.Add(this.btnSm);
            this.Controls.Add(this.btnRe);
            this.Controls.Add(this.btnCof);
            this.Controls.Add(this.btnFrap);
            this.Name = "StarbucksMain";
            this.Text = "Starbucks Main Menu";
            this.Load += new System.EventHandler(this.StarbucksMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFrap;
        private System.Windows.Forms.Button btnCof;
        private System.Windows.Forms.Button btnRe;
        private System.Windows.Forms.Button btnSm;
        private System.Windows.Forms.Button btnESp;
        private System.Windows.Forms.Button btnTe;
    }
}