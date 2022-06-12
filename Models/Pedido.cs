using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using cardapio_console.Models;


namespace cardapio_console.Models
{
    class Pedido

    {
        public Pedido()
        {
            ListaDeProduto = new List<Produto>();
        }

        public double ValorTotal { get; set; }
        public List<Produto> ListaDeProduto { get; set; }
    }

}


