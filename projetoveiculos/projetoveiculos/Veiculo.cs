using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projetoveiculos
{
    public abstract class Veiculo
    {
        private string modelo;
        private int quilometragem;
        private double preco;
        private string marca;
        private string descricao;
        private string placa;

        public Veiculo()
        {
            this.modelo = null;
            this.quilometragem = 0;
            this.preco = 0;
            this.marca = null;
            this.descricao = null;
            this.placa = null;
        }
        public Veiculo(string modelo, int quilometragem, double preco, string marca, string descricao, string placa)
        {
            this.modelo = modelo;
            this.quilometragem = quilometragem;
            this.preco = preco;
            this.marca = marca;
            this.descricao = descricao;
            this.placa = placa;
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Quilometragem
        {
            get { return quilometragem; }
            set { quilometragem = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public abstract String ImprimeDados();
    }
}
