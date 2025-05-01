namespace Prova1Bi
{
    partial class frmTemperatura
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
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.numAcrescimoTemp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcrescimoTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(29, 160);
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(160, 35);
            this.numTemp.TabIndex = 0;
            this.numTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numAcrescimoTemp
            // 
            this.numAcrescimoTemp.Location = new System.Drawing.Point(278, 160);
            this.numAcrescimoTemp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAcrescimoTemp.Name = "numAcrescimoTemp";
            this.numAcrescimoTemp.Size = new System.Drawing.Size(160, 35);
            this.numAcrescimoTemp.TabIndex = 1;
            this.numAcrescimoTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(273, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 68);
            this.label3.TabIndex = 4;
            this.label3.Text = "Percentual de Acréscimo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(444, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(145, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Temperatura (°C)";
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(71, 428);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(105, 51);
            this.btNovo.TabIndex = 7;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btCalcular
            // 
            this.btCalcular.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCalcular.Location = new System.Drawing.Point(195, 428);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(116, 51);
            this.btCalcular.TabIndex = 8;
            this.btCalcular.Text = "&Calcular";
            this.btCalcular.UseVisualStyleBackColor = false;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Crimson;
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(333, 428);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(105, 51);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Salmon;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Location = new System.Drawing.Point(163, 320);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(167, 63);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(517, 530);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAcrescimoTemp);
            this.Controls.Add(this.numTemp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmTemperatura";
            this.Text = "Temperatura 1° Bimestre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTemperatura_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAcrescimoTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.NumericUpDown numAcrescimoTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblResultado;
    }
}

