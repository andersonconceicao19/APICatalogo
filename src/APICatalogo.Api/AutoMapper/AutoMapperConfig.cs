using APICatalogo.Api.DTO;
using APICatalogo.Business.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Api.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CategoriaDTO, Categoria>().ReverseMap();
        }
    }
}
