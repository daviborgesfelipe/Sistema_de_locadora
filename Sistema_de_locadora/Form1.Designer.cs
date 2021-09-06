
namespace Sistema_de_locadora
{
    partial class TbTituloFilme
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LabelCategoria = new System.Windows.Forms.Label();
            this.LabelLancamento = new System.Windows.Forms.Label();
            this.Alugado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Location = new System.Drawing.Point(12, 31);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(80, 13);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Título do Filme:";
            this.LabelTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // BtnInserir
            // 
            this.BtnInserir.Location = new System.Drawing.Point(15, 54);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(181, 23);
            this.BtnInserir.TabIndex = 2;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(390, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(672, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(591, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LabelCategoria
            // 
            this.LabelCategoria.AutoSize = true;
            this.LabelCategoria.Location = new System.Drawing.Point(306, 31);
            this.LabelCategoria.Name = "LabelCategoria";
            this.LabelCategoria.Size = new System.Drawing.Size(55, 13);
            this.LabelCategoria.TabIndex = 7;
            this.LabelCategoria.Text = "Categoria:";
            this.LabelCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // LabelLancamento
            // 
            this.LabelLancamento.AutoSize = true;
            this.LabelLancamento.Location = new System.Drawing.Point(588, 31);
            this.LabelLancamento.Name = "LabelLancamento";
            this.LabelLancamento.Size = new System.Drawing.Size(69, 13);
            this.LabelLancamento.TabIndex = 8;
            this.LabelLancamento.Text = "Lançamento:";
            // 
            // Alugado
            // 
            this.Alugado.Location = new System.Drawing.Point(107, 112);
            this.Alugado.Name = "Alugado";
            this.Alugado.Size = new System.Drawing.Size(100, 20);
            this.Alugado.TabIndex = 9;
            // 
            // TbTituloFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.Alugado);
            this.Controls.Add(this.LabelLancamento);
            this.Controls.Add(this.LabelCategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelTitulo);
            this.Name = "TbTituloFilme";
            this.Text = "Diario Marítimo";
            this.Load += new System.EventHandler(this.TbTituloFilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabelCategoria;
        private System.Windows.Forms.Label LabelLancamento;
        private System.Windows.Forms.TextBox Alugado;
    }
}

