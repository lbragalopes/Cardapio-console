using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cardapio_console.Models
{
    public class Cardapio
    {
        public List<Produto> ListaDeProduto { get; set; }

        public Cardapio()
        {
            ListaDeProduto = new List<Produto>() {
                 new Produto(100, "Cachorro Quente",5.70),
                 new Produto(101, "X Completo", 18.30),
                 new Produto(102, "X Salada", 16.30),
                 new Produto(103, "Hamburguer", 22.40),
                 new Produto(104, "Coca 2L", 10.00),
                 new Produto(105, "Refrigerante", 1.00)
            };
        }

        public void ExibirCardapio()
        {
           // Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("╔══════════════════════CARDÁPIO═════════════════════╗");
            Console.WriteLine();
            Console.WriteLine("  Código\tProduto\t\tPreço Unitário (R$)");
            Console.WriteLine();
            foreach (var produto in ListaDeProduto)
            {
                var outuput = String.Format("   {0,-8}{1,-21}{2}{3:F2}", produto.Codigo, produto.Descricao, "R$ ", produto.ValorUnitario);
                Console.WriteLine(outuput);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t999  Encerra pedido");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╚═══════════════════════════════════════════════════╝");
            Console.WriteLine(" ");
        }

    }
}