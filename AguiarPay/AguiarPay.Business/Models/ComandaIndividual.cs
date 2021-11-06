using System;
using System.Collections.Generic;
using System.Text;

namespace AguiarPay.Business.Models
{
    public class ComandaIndividual : Entity
    {
        public IEnumerable<PedidoIndividual> PedidosIndividuais { get; set; }
    }
}
