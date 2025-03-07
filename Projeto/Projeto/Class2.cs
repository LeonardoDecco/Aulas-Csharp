using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public double GetArea() 
        { 
            return Largura * Altura;    
        }
        public double GetPerimetro()
        {
            return (Largura + Altura) * 2;
        }
    }
}
