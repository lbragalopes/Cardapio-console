

 # Sugestão atividade:

Requisitos funcionais e não funcionais

Desenvolver um pedido e cardápio digital de uma lancheria.

1 - Requisitos Funcionais:

 * O usuário deve informar o número da mesa;
 * As opções do cardápio devem ser exibidas formatadas;
 * As mesas aceitas são: 1, 2, 3 e 4. Validar mesa inválida, e solicitar novamente a mesa;
 * Validar código de produto válido na lista de produtos(consultar via linq na lista de produtos);
 * Finalizar pedido ao informar código do produto 999;
 * Após finalizar pedido, imprimir a lista de itens do pedido em formato JSON( utilize a classe JavaScriptSerializer() )

2 - Requisitos não funcionais

  * C#;
  * Criar classes em arquivos .cs separados.
  * Classes:
    - Pedido
      - Valor Total
      - Lista de Produto
    - Produto
      - Codigo
      - Descricao
      - ValorUnitario      
    - Cardapio
      - Lista de Produto

  * Utilizar array para armazenar lista de mesas aceitas(1,2,3,4);
  * Utilizar Lista do objeto Produto para armazenar lista de cardápio de produtos e preços;
  * Após encerrar pedido, imprimir a lista de itens do pedido em formato JSON( utilize a classe JavaScriptSerializer() )


3 - Descrição da tarefa
    - O cardápio automatizado de uma lancheria
      - Quando o usuário abrir o sistema, mostrar o menu de exemplo(mais abaixo) e ao escolher a entrada abaixo:
      - Entrada :

```
Qual o numero da mesa ?: XX
Qual  o item (Codigo) do pedido abaixo? 

- Entrada em loop :
Código  Produto                   Preço Unitário (R$)
100       Cachorro quente     R$  5,70
101       X Completo          R$ 18,30
102       X Salada            R$ 16,50
103       Hamburguer          R$ 22,40
104       Coca 2L             R$ 10,00
105       Refrigerante        R$  1,00
999       Encerra pedido

Informe o Codigo: XX
Informe a Quantidade:XX

```
- Quando o usuário digitar 999, encerrar pedido e mostrar saída

```
///Saida 1:

A mesa XXX pediu os seguintes itens:
 1 - Cachorro quebte
 2 - X Completo
Com valor total de R$: 60,6

```
/// Saída 2
// Imprimir items do pedido em json. 

```json
          
{ "ValorTotal" : 60.6,
  "Itens" : [
    { "Codigo" : 100,
      "Descricao" : "Cachorro quente"
    },
    { "Codigo" : 101,
      "Descricao" : "X Completo"
    }    
]}

```
# Exemplos

- menu Principal

```
   
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
            Console.WriteLine("╔═════════════════MENU DE OPÇÕES════════════════╗    ");
            Console.WriteLine("║ 1 EFETUAR PEDIDO                              ║    ");
            Console.WriteLine("║ 2 SAIR                                        ║    ");
            Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

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
            Console.WriteLine("Pedido");

            // TODO
            Console.Write("Pressione uma tecla para continuar...");
            Console.ReadKey();
        } 
    }      

```
