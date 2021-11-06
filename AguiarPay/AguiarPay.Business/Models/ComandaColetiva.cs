using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class ComandaColetiva : Entity
    {
        public PedidoColetivo PedidoColetivo { get; set; }
    }
}
