namespace Prova1Bi
{
    partial class frmCalculaMedia
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
            this.numNota1 = new System.Windows.Forms.NumericUpDown();
            this.numNota2 = new System.Windows.Forms.NumericUpDown();
            this.numNota3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btZerar = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota3)).BeginInit();
            this.SuspendLayout();
            // 
            // numNota1
            // 
            this.numNota1.DecimalPlaces = 1;
            this.numNota1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numNota1.Location = new System.Drawing.Point(316, 63);
            this.numNota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNota1.Name = "numNota1";
            this.numNota1.Size = new System.Drawing.Size(120, 35);
            this.numNota1.TabIndex = 0;
            this.numNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNota1.Enter += new System.EventHandler(this.numNota1_Enter);
            // 
            // numNota2
            // 
            this.numNota2.DecimalPlaces = 1;
            this.numNota2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numNota2.Location = new System.Drawing.Point(316, 104);
            this.numNota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNota2.Name = "numNota2";
            this.numNota2.Size = new System.Drawing.Size(120, 35);
            this.numNota2.TabIndex = 1;
            this.numNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNota2.Enter += new System.EventHandler(this.numNota2_Enter);
            // 
            // numNota3
            // 
            this.numNota3.DecimalPlaces = 1;
            this.numNota3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numNota3.Location = new System.Drawing.Point(316, 145);
            this.numNota3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNota3.Name = "numNota3";
            this.numNota3.Size = new System.Drawing.Size(120, 35);
            this.numNota3.TabIndex = 2;
            this.numNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNota3.Enter += new System.EventHandler(this.numNota3_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nota 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(221, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 117);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calcular Média";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(192, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.BackColor = System.Drawing.Color.Salmon;
            this.lblMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedia.Location = new System.Drawing.Point(155, 294);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(167, 59);
            this.lblMedia.TabIndex = 8;
            this.lblMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btZerar
            // 
            this.btZerar.BackColor = System.Drawing.Color.White;
            this.btZerar.ForeColor = System.Drawing.Color.Black;
            this.btZerar.Location = new System.Drawing.Point(30, 447);
            this.btZerar.Name = "btZerar";
            this.btZerar.Size = new System.Drawing.Size(118, 41);
            this.btZerar.TabIndex = 9;
            this.btZerar.Text = "&Zerar";
            this.btZerar.UseVisualStyleBackColor = false;
            this.btZerar.Click += new System.EventHandler(this.btZerar_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCalcular.Location = new System.Drawing.Point(176, 447);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(118, 41);
            this.btCalcular.TabIndex = 10;
            this.btCalcular.Text = "&Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Crimson;
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(318, 447);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(118, 41);
            this.btSair.TabIndex = 11;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmCalculaMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(459, 534);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btZerar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numNota3);
            this.Controls.Add(this.numNota2);
            this.Controls.Add(this.numNota1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmCalculaMedia";
            this.Text = "Calcular Média";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCalculaMedia_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numNota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNota3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNota1;
        private System.Windows.Forms.NumericUpDown numNota2;
        private System.Windows.Forms.NumericUpDown numNota3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btZerar;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSair;
    }
}