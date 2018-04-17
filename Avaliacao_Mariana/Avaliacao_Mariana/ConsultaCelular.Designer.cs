namespace Avaliacao_Mariana
{
    partial class ConsultaCelular
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
            this.dtCelular = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadCelular
            // 
            this.btnCadCelular.Location = new System.Drawing.Point(213, 177);
            this.btnCadCelular.Name = "btnCadCelular";
            this.btnCadCelular.Size = new System.Drawing.Size(120, 34);
            this.btnCadCelular.TabIndex = 1;
            this.btnCadCelular.Text = "Cadastrar Celular";
            this.btnCadCelular.UseVisualStyleBackColor = true;
            this.btnCadCelular.Click += new System.EventHandler(this.btnCadCelular_Click);
            // 
            // dtCelular
            // 
            this.dtCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCelular.Location = new System.Drawing.Point(11, 12);
            this.dtCelular.Name = "dtCelular";
            this.dtCelular.Size = new System.Drawing.Size(524, 150);
            this.dtCelular.TabIndex = 2;
            // 
            // ConsultaCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 226);
            this.Controls.Add(this.dtCelular);
            this.Controls.Add(this.btnCadCelular);
            this.Name = "ConsultaCelular";
            this.Text = "ConsultaCelular";
            this.Load += new System.EventHandler(this.ConsultaCelular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadCelular;
        private System.Windows.Forms.DataGridView dtCelular;
    }
}