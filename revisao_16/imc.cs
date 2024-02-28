using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_16
{
    internal class imc
    {
        private double peso, altura;

        public double Peso
        {
            get => peso;
            set
            {
                if (value > 0)
                {
                    peso = value;
                }
                else
                {
                    throw new ArgumentException("Peso devará ser maior que zero.");
                }
            }
        }


        public double Altura
        {
            get => altura;
            set
            {
                if (value > 0)
                {
                    altura = value;
                }
                else
                {
                    throw new ArgumentException("Altura deverá ser maior que zero.");
                }
            }
        }
        public double CalcularIMC()
        {
            return this.Peso / (this.Altura * this.Altura);
        }

        public string TabelaIMC()
        {
            if (CalcularIMC() < 18.5)
            {
                return "Você está abaixo do peso!";
            }
            else if (CalcularIMC() >= 18.5 && CalcularIMC() <= 24.9)
            {
                return "Parabéns - Você está no peso normal!";
            }
            else if (CalcularIMC() >= 25 && CalcularIMC() <= 29.9)
            {
                return "Você está em sobrepeso!";
            }
            else if (CalcularIMC() >= 30 && CalcularIMC() <= 34.9)
            {
                return "Obesidade Grau I!";
            }
            else if (CalcularIMC() >= 35 && CalcularIMC() <= 39.9)
            {
                return "Obesidade Grau II!";
            }
            else
            {
                return "Obesidade Grau III";
            }
        }
    }
}
            