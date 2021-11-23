using AguiarPay.Business.Models;
using AguiarPay.Presentation.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguiarPay.Presentation.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ComandaIndividual, ComandaIndividualViewModel>().ReverseMap();
            CreateMap<PedidoIndividual, PedidoIndividualViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
