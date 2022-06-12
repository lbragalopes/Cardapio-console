using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using cardapio_console.Models;
using Nancy.Json;
using Newtonsoft.Json;


namespace cardapio_console
{
    class Program
    {
        static void Main(string[] args)

        {
            bool exibeMenu = true;
            while (exibeMenu)
            {
                exibeMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ PEDIDOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═══════════════MENU DE OPÇÕES══════════════╗    ");
            Console.WriteLine("║ 1 EFETUAR PEDIDO                          ║    ");
            Console.WriteLine("║ 2 SAIR                                    ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════╝    ");

            Console.WriteLine(" ");
            Console.Write("DIGITE UMA OPÇÃO : ");

            switch (Console.ReadLine())
            {
                case "1":
                    Pedido();
                    return true;
                case "2":
                    return false;
                default:
                    return true;
            }
        }

        private static void Pedido()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════ Pedido  ═══════════════════ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            int[] mesasAceitas = { 1, 2, 3, 4 };
            int numeroMesa;

            while (true)
            {
                Console.Write("Qual o número da mesa?: ");
                numeroMesa = int.Parse(Console.ReadLine());

                if (mesasAceitas.Contains(numeroMesa))
                {
                    break;
                }

                Console.WriteLine("Mesa inválida! São válidas apenas as mesas 1, 2, 3 e 4.");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Qual o item (Código) do pedido abaixo?");

            var pedido = new Pedido();
            int codproduto, quantidade;

            do
            {

                Cardapio cardapio = new Cardapio();
                cardapio.ExibirCardapio();
                Console.Write("Informe o Código: ");
                codproduto = int.Parse(Console.ReadLine());

                if (codproduto != 999)
                {
                    var produto = ValidarProduto(codproduto);
                    if (produto == null)
                    {
                        Console.WriteLine("Produto inválido!");
                        continue;
                    }

                    Console.Write("Informe a quantidade: ");
                    quantidade = int.Parse(Console.ReadLine());

                    pedido.ValorTotal = pedido.ValorTotal + (produto.ValorUnitario * (double)quantidade);
                    pedido.ListaDeProduto.Add(produto);
                }

            } while (codproduto != 999);


            //Saida 1:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("══════════════ Pedido Encerrado ═════════════ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"A mesa {numeroMesa} pediu os seguintes itens: ");
            for (int i = 0; i < pedido.ListaDeProduto.Count; i++)
            {
                Console.WriteLine($"  {i + 1} - {pedido.ListaDeProduto[i].Descricao}");
            }
            Console.WriteLine($"Com o valor total de R$ {pedido.ValorTotal:F2}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            //Saida 2 // Imprimir itens do pedido em json.
            //var serializer = new JavaScriptSerializer();
            //var serializedResult = serializer.Serialize(pedido);
            var json = JsonConvert.SerializeObject(pedido, Formatting.Indented);
            //string jsonString = FormatOutput(serializedResult);
            //Console.WriteLine (serializedResult,jsonString);
            Console.WriteLine(json+"\n");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("═══════════════════════════════════════════════ ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.Write("Pressione uma tecla para continuar...");
            Console.ReadKey();

        }

       
        private static Produto ValidarProduto(int codproduto)
        {
            var cardapio = new Cardapio();
            return cardapio.ListaDeProduto.FirstOrDefault(a => a.Codigo == codproduto);
        }
                
        }
    }
