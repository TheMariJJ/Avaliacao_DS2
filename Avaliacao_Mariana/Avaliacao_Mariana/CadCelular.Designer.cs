namespace Avaliacao_Mariana
{
    partial class CadCelular
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
            this.btnCadCelular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txbAno = new System.Windows.Forms.TextBox();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.txbMemoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadCelular
            // 
            this.btnCadCelular.Location = new System.Drawing.Point(19, 160);
            this.btnCadCelular.Name = "btnCadCelular";
            this.btnCadCelular.Size = new System.Drawing.Size(75, 23);
            this.btnCadCelular.TabIndex = 8;
            this.btnCadCelular.Text = "Cadastrar";
            this.btnCadCelular.UseVisualStyleBackColor = true;
            this.btnCadCelular.Click += new System.EventHandler(this.btnCadCelular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(143, 160);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 13);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 52);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 17;
            this.lblModelo.Text = "Modelo:";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(38, 29);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 20);
            this.txbMarca.TabIndex = 18;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(38, 66);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(100, 20);
            this.txbModelo.TabIndex = 19;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(12, 102);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 20;
            this.lblAno.Text = "Ano:";
            // 
            // txbAno
            // 
            this.txbAno.Location = new System.Drawing.Point(38, 118);
            this.txbAno.Name = "txbAno";
            this.txbAno.Size = new System.Drawing.Size(56, 20);
            this.txbAno.TabIndex = 21;
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(118, 102);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(50, 13);
            this.lblMemoria.TabIndex = 22;
            this.lblMemoria.Text = "Memória:";
            // 
            // txbMemoria
            // 
            this.txbMemoria.Location = new System.Drawing.Point(140, 118);
            this.txbMemoria.Name = "txbMemoria";
            this.txbMemoria.Size = new System.Drawing.Size(78, 20);
            this.txbMemoria.TabIndex = 23;
            // 
            // CadCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 207);
            this.Controls.Add(this.txbMemoria);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.txbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadCelular);
            this.Name = "CadCelular";
            this.Text = "Cadastrar Celular";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadCelular_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCelular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txbAno;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txbMemoria;
    }
}