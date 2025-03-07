using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(int quantidade, string nome, double preco)
        {
            Nome = nome;    
            Preco = preco;  
            Quantidade = quantidade;
        }
        public double GetPreco()
        {
            return Preco * Quantidade;
        }
        public string GetDetailProduct()
        {
            return $"Nome: {Nome},Preço: {Preco},Quantidade: {Quantidade}";
        }
    }
}
