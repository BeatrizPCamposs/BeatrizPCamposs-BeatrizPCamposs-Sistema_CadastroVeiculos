using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    public class Carro : Veiculo
    {
        private int qtdpassageiros;
        private int numportas;
        private int capportamalas;
        private string carroceria;

        public Carro()
        {
            this.qtdpassageiros = 0;
            this.numportas = 0;
            this.capportamalas = 0;
            this.carroceria = null;
        }
        public Carro(string modelo, int quilometragem, double preco, string marca, string descricao, string placa, int qtdpassageiros, int numportas, int capportamalas, string carroceria)
        {
            this.Modelo = modelo;
            this.Quilometragem = quilometragem;
            this.Preco = preco;
            this.Marca = marca;
            this.Descricao = descricao;
            this.Placa = placa;
            this.Qtdpassageiros = qtdpassageiros;
            this.Numportas = numportas;
            this.Capportamalas = capportamalas;
            this.Carroceria = carroceria;
        }

        public int Qtdpassageiros
        {
            get { return qtdpassageiros; }
            set { qtdpassageiros = value; }
        }

        public int Numportas
        {
            get { return numportas; }
            set { numportas = value; }
        }
        public int Capportamalas
        {
            get { return capportamalas; }
            set { capportamalas = value; }
        }

        public string Carroceria
        {
            get { return carroceria; }
            set { carroceria = value; }
        }
        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat("Modelo: ", this.Modelo,"\n",
                              "Quilometragem: ", this.Quilometragem.ToString(), "\n",
                              "Preço: ", this.Preco.ToString(), "\n",
                              "Marca: ", this.Marca, "\n",
                              "Descrição: ", this.Descricao, "\n",
                              "Placa: ", this.Placa, "\n",
                              "Quantidade de Passageiros: ", this.Qtdpassageiros.ToString(), "\n",
                              "Número de Portas: ", this.Numportas.ToString(), "\n",
                              "Capacidade do Porta Malas: ", this.Capportamalas.ToString(), "\n",
                              "Carroceria: ", this.Carroceria, "\n"
                              );
            return s;
        }
    }
}
