using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguiarPay.Presentation.ViewModels
{
    public class ComandaIndividualViewModel
    {
        public Guid Id { get; set; }
        public IEnumerable<PedidoIndividualViewModel> PedidosIndividuais { get; set; }
    }
}
