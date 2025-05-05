namespace Prova1Bi
{
    partial class frmMenu
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
            this.btTemperatura = new System.Windows.Forms.Button();
            this.btMedia = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTemperatura
            // 
            this.btTemperatura.Location = new System.Drawing.Point(195, 71);
            this.btTemperatura.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btTemperatura.Name = "btTemperatura";
            this.btTemperatura.Size = new System.Drawing.Size(208, 180);
            this.btTemperatura.TabIndex = 0;
            this.btTemperatura.Text = "&Temperatura";
            this.btTemperatura.UseVisualStyleBackColor = true;
            this.btTemperatura.Click += new System.EventHandler(this.btTemperatura_Click);
            // 
            // btMedia
            // 
            this.btMedia.Location = new System.Drawing.Point(488, 71);
            this.btMedia.Margin = new System.Windows.Forms.Padding(7);
            this.btMedia.Name = "btMedia";
            this.btMedia.Size = new System.Drawing.Size(208, 180);
            this.btMedia.TabIndex = 1;
            this.btMedia.Text = "&Media";
            this.btMedia.UseVisualStyleBackColor = true;
            this.btMedia.Click += new System.EventHandler(this.btMedia_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(853, 346);
            this.btSair.Margin = new System.Windows.Forms.Padding(7);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(118, 37);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 399);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btMedia);
            this.Controls.Add(this.btTemperatura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmMenu";
            this.Text = "Menu de Aplicações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTemperatura;
        private System.Windows.Forms.Button btMedia;
        private System.Windows.Forms.Button btSair;
    }
}