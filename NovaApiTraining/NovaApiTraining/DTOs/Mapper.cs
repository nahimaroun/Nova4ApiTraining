using AutoMapper;

namespace NovaApiTraining.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Bitfinex, Crypto>()
              .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.last_price))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.timeStamp, opt => opt.MapFrom(src => src.Converted))
              .ForMember(dest => dest.Source, opt => opt.MapFrom(_ => "Bitfinex"));

            CreateMap<BitStamp, Crypto>()
              .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.last))
              .ForMember(dest => dest.Source, opt => opt.MapFrom(_ => "BitStamp"))
              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
              .ForMember(dest => dest.timeStamp, opt => opt.MapFrom(src => src.Converted));
        }
    }
}