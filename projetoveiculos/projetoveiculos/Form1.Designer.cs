namespace projetoveiculos
{
    partial class frmhome
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
            this.btncadcarro = new System.Windows.Forms.Button();
            this.btncadcaminhao = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncadcarro
            // 
            this.btncadcarro.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btncadcarro.FlatAppearance.BorderSize = 3;
            this.btncadcarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadcarro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadcarro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncadcarro.Location = new System.Drawing.Point(32, 301);
            this.btncadcarro.Name = "btncadcarro";
            this.btncadcarro.Size = new System.Drawing.Size(301, 66);
            this.btncadcarro.TabIndex = 0;
            this.btncadcarro.Text = "Cadastro de Carros";
            this.btncadcarro.UseVisualStyleBackColor = true;
            this.btncadcarro.Click += new System.EventHandler(this.btncadcarro_Click);
            // 
            // btncadcaminhao
            // 
            this.btncadcaminhao.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btncadcaminhao.FlatAppearance.BorderSize = 3;
            this.btncadcaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadcaminhao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadcaminhao.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncadcaminhao.Location = new System.Drawing.Point(356, 301);
            this.btncadcaminhao.Name = "btncadcaminhao";
            this.btncadcaminhao.Size = new System.Drawing.Size(301, 66);
            this.btncadcaminhao.TabIndex = 1;
            this.btncadcaminhao.Text = "Cadastro de Caminhão";
            this.btncadcaminhao.UseVisualStyleBackColor = true;
            this.btncadcaminhao.Click += new System.EventHandler(this.btncadcaminhao_Click);
            // 
            // btnsair
            // 
            this.btnsair.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnsair.FlatAppearance.BorderSize = 3;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnsair.Location = new System.Drawing.Point(686, 301);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(301, 66);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edo SZ", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(182, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "CADASTRO DE VEÍCULOS";
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btncadcaminhao);
            this.Controls.Add(this.btncadcarro);
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veículos";
            this.Load += new System.EventHandler(this.frmhome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadcarro;
        private System.Windows.Forms.Button btncadcaminhao;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label1;
    }
}

