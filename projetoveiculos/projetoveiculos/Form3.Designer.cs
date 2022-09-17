namespace projetoveiculos
{
    partial class frmcadcaminhao
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
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.txtquilometragem = new System.Windows.Forms.TextBox();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumderodas = new System.Windows.Forms.TextBox();
            this.txtplataforma = new System.Windows.Forms.TextBox();
            this.txtporte = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btncad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(191, 256);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(288, 22);
            this.txtdescricao.TabIndex = 24;
            this.txtdescricao.TextChanged += new System.EventHandler(this.txtdescricao_TextChanged);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(191, 202);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(288, 22);
            this.txtmarca.TabIndex = 23;
            this.txtmarca.TextChanged += new System.EventHandler(this.txtmarca_TextChanged);
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(191, 151);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(288, 22);
            this.txtpreco.TabIndex = 22;
            this.txtpreco.TextChanged += new System.EventHandler(this.txtpreco_TextChanged);
            // 
            // txtquilometragem
            // 
            this.txtquilometragem.Location = new System.Drawing.Point(191, 96);
            this.txtquilometragem.Name = "txtquilometragem";
            this.txtquilometragem.Size = new System.Drawing.Size(288, 22);
            this.txtquilometragem.TabIndex = 21;
            this.txtquilometragem.TextChanged += new System.EventHandler(this.txtquilometragem_TextChanged);
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(191, 45);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(288, 22);
            this.txtmodelo.TabIndex = 20;
            this.txtmodelo.TextChanged += new System.EventHandler(this.txtmodelo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(35, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(35, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quilometragem:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Modelo:";
            // 
            // txtnumderodas
            // 
            this.txtnumderodas.Location = new System.Drawing.Point(657, 200);
            this.txtnumderodas.Name = "txtnumderodas";
            this.txtnumderodas.Size = new System.Drawing.Size(288, 22);
            this.txtnumderodas.TabIndex = 33;
            // 
            // txtplataforma
            // 
            this.txtplataforma.Location = new System.Drawing.Point(657, 149);
            this.txtplataforma.Name = "txtplataforma";
            this.txtplataforma.Size = new System.Drawing.Size(288, 22);
            this.txtplataforma.TabIndex = 32;
            // 
            // txtporte
            // 
            this.txtporte.Location = new System.Drawing.Point(657, 94);
            this.txtporte.Name = "txtporte";
            this.txtporte.Size = new System.Drawing.Size(288, 22);
            this.txtporte.TabIndex = 31;
            // 
            // txtplaca
            // 
            this.txtplaca.Location = new System.Drawing.Point(657, 43);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(288, 22);
            this.txtplaca.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(567, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(496, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Eixo:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(496, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 22);
            this.label8.TabIndex = 27;
            this.label8.Text = "Plataforma:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(496, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 26;
            this.label9.Text = "Porte:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(496, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Placa:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnvoltar.FlatAppearance.BorderSize = 3;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnvoltar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnvoltar.Location = new System.Drawing.Point(646, 327);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(299, 65);
            this.btnvoltar.TabIndex = 36;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnexibir.FlatAppearance.BorderSize = 3;
            this.btnexibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexibir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnexibir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnexibir.Location = new System.Drawing.Point(343, 327);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(299, 65);
            this.btnexibir.TabIndex = 35;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btncad
            // 
            this.btncad.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btncad.FlatAppearance.BorderSize = 3;
            this.btncad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btncad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btncad.Location = new System.Drawing.Point(38, 327);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(299, 65);
            this.btncad.TabIndex = 34;
            this.btncad.Text = "Cadastrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // frmcadcaminhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 446);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txtnumderodas);
            this.Controls.Add(this.txtplataforma);
            this.Controls.Add(this.txtporte);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtquilometragem);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcadcaminhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Caminhão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.TextBox txtquilometragem;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumderodas;
        private System.Windows.Forms.TextBox txtplataforma;
        private System.Windows.Forms.TextBox txtporte;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btncad;
    }
}