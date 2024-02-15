namespace Zoo
{
    partial class Patolandia
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
            this.btnCriarPato = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbEstaCio = new System.Windows.Forms.CheckBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.numAltura = new System.Windows.Forms.NumericUpDown();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVerPato = new System.Windows.Forms.Button();
            this.numNumeroPato = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroPato)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriarPato
            // 
            this.btnCriarPato.Location = new System.Drawing.Point(110, 321);
            this.btnCriarPato.Name = "btnCriarPato";
            this.btnCriarPato.Size = new System.Drawing.Size(151, 59);
            this.btnCriarPato.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCriarPato);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ckbEstaCio);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.numAltura);
            this.panel1.Controls.Add(this.numPeso);
            this.panel1.Controls.Add(this.txtEspecie);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(524, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 383);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dados do Pato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ckbEstaCio
            // 
            this.ckbEstaCio.AutoSize = true;
            this.ckbEstaCio.Location = new System.Drawing.Point(3, 251);
            this.ckbEstaCio.Name = "ckbEstaCio";
            this.ckbEstaCio.Size = new System.Drawing.Size(86, 17);
            this.ckbEstaCio.TabIndex = 3;
            this.ckbEstaCio.Text = "Está no Cio?";
            this.ckbEstaCio.UseVisualStyleBackColor = true;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Macho",
            "Fêmea"});
            this.cmbGenero.Location = new System.Drawing.Point(3, 224);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(258, 21);
            this.cmbGenero.TabIndex = 4;
            // 
            // numAltura
            // 
            this.numAltura.Location = new System.Drawing.Point(3, 140);
            this.numAltura.Name = "numAltura";
            this.numAltura.Size = new System.Drawing.Size(258, 20);
            this.numAltura.TabIndex = 2;
            // 
            // numPeso
            // 
            this.numPeso.Location = new System.Drawing.Point(3, 98);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(258, 20);
            this.numPeso.TabIndex = 1;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(3, 182);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(258, 20);
            this.txtEspecie.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(3, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnVerPato
            // 
            this.btnVerPato.Location = new System.Drawing.Point(138, 81);
            this.btnVerPato.Name = "btnVerPato";
            this.btnVerPato.Size = new System.Drawing.Size(75, 23);
            this.btnVerPato.TabIndex = 3;
            this.btnVerPato.Text = "Procurar";
            this.btnVerPato.UseVisualStyleBackColor = true;
            this.btnVerPato.Click += new System.EventHandler(this.btnVerPato_Click);
            // 
            // numNumeroPato
            // 
            this.numNumeroPato.Location = new System.Drawing.Point(12, 82);
            this.numNumeroPato.Name = "numNumeroPato";
            this.numNumeroPato.Size = new System.Drawing.Size(120, 20);
            this.numNumeroPato.TabIndex = 4;
            // 
            // Patolandia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numNumeroPato);
            this.Controls.Add(this.btnVerPato);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVisor);
            this.Name = "Patolandia";
            this.Text = "Patolandia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroPato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarPato;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numAltura;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbEstaCio;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Button btnVerPato;
        private System.Windows.Forms.NumericUpDown numNumeroPato;
    }
}