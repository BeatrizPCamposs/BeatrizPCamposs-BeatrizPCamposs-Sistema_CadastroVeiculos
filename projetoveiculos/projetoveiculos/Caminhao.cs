using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    public class Caminhao : Veiculo
    {
        private string porte;
        private string plataforma;
        private int eixo;

        public Caminhao() 
        {
            this.porte = null;
            this.plataforma = null;
            this.eixo = 0;
        }

        public Caminhao(string modelo, int quilometragem, double preco, string marca, string descricao, string placa,string porte,string plataforma,int eixo)
        {
            this.Modelo = modelo;
            this.Quilometragem = quilometragem;
            this.Preco = preco;
            this.Marca = marca;
            this.Descricao = descricao;
            this.Placa = placa;
            this.Porte = porte;
            this.Plataforma = plataforma;
            this.Eixo = eixo;
            
        }

        public string Porte
        {
            get { return porte; }
            set { porte = value;  }
        }

        public string Plataforma
        {
            get { return plataforma; }
            set { plataforma = value; }
        }

        public int Eixo
        {
            get { return eixo; }
            set { eixo = value; }
        }

        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat("Modelo: ", this.Modelo, "\n",
                              "Quilometragem: ", this.Quilometragem.ToString(), "\n",
                              "Preço: ", this.Preco.ToString(), "\n",
                              "Marca: ", this.Marca, "\n",
                              "Descrição: ", this.Descricao, "\n",
                              "Placa: ", this.Placa, "\n",
                              "Porte: ",this.Porte, "\n",
                              "Plataforma: ",this.Plataforma, "\n",
                              "Eixo: ",this.Eixo.ToString(), "\n"
                              );
            return s;
        }
    }
}
