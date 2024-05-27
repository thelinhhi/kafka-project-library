using AutoMapper;
using KafkaProducer.Appplication.DTOs;
using KafkaProducer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafkaProducer.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RequestDto, Request>()
                .ForMember(destination => destination.Params, opt => opt.MapFrom(source => source.Data == null? new List<NameTypeValueModel>() : ConvertFunction.ConvertObjectToNameTypeValueModel(source.Data)));
         
        }
    }
}
