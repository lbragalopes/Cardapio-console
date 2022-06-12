using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cardapio_console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }

        public Produto(int codigo, string descricao, double valorUnitario)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.ValorUnitario = valorUnitario;
        }
    }
}
