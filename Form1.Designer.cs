namespace Zoo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriarPato = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnTempoVida = new System.Windows.Forms.Button();
            this.btnMataPato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriarPato
            // 
            this.btnCriarPato.Location = new System.Drawing.Point(12, 82);
            this.btnCriarPato.Name = "btnCriarPato";
            this.btnCriarPato.Size = new System.Drawing.Size(135, 64);
            this.btnCriarPato.TabIndex = 0;
            this.btnCriarPato.Text = "Criar Pato";
            this.btnCriarPato.UseVisualStyleBackColor = true;
            this.btnCriarPato.Click += new System.EventHandler(this.btnCriarPato_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.Multiline = true;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(506, 64);
            this.txtVisor.TabIndex = 1;
            // 
            // btnTempoVida
            // 
            this.btnTempoVida.Location = new System.Drawing.Point(383, 82);
            this.btnTempoVida.Name = "btnTempoVida";
            this.btnTempoVida.Size = new System.Drawing.Size(135, 64);
            this.btnTempoVida.TabIndex = 2;
            this.btnTempoVida.Text = "Tempo Vida";
            this.btnTempoVida.UseVisualStyleBackColor = true;
            this.btnTempoVida.Click += new System.EventHandler(this.btnTempoVida_Click);
            // 
            // btnMataPato
            // 
            this.btnMataPato.Location = new System.Drawing.Point(153, 82);
            this.btnMataPato.Name = "btnMataPato";
            this.btnMataPato.Size = new System.Drawing.Size(135, 64);
            this.btnMataPato.TabIndex = 3;
            this.btnMataPato.Text = "Matar Pato";
            this.btnMataPato.UseVisualStyleBackColor = true;
            this.btnMataPato.Click += new System.EventHandler(this.btnMataPato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 158);
            this.Controls.Add(this.btnMataPato);
            this.Controls.Add(this.btnTempoVida);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnCriarPato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPato;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btnTempoVida;
        private System.Windows.Forms.Button btnMataPato;
    }
}

