using System;
using System.Collections.Generic;

namespace Validation.Entities
{
    public class Venda
    {
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public TipoVenda Tipo { get; set; }
        public List<ItemVenda> Items { get; set; }
    }
}
