using Admin.ViewModel.BibleVersion;
using DataAccess.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Utility.helpers;

namespace Admin.Profiles
{
    public class BibleProfile : Profile
    {
        public BibleProfile()
        {
            // CreateMap<source, destination>();
            CreateMap<BibleVersion, BibleVersionDatatableViewModel>()
                .ForMember(dest => dest.InfoURL, opt => opt.MapFrom(src => TextHelper.MinimizeLength(src.InfoURL, 40)))
                .ForMember(dest => dest.Copyright, opt => opt.MapFrom(src => TextHelper.MinimizeLength(src.Copyright,40)));
            CreateMap<BibleVersion, BibleVersionViewModel>()
                .ForMember(dest => dest.BibleBookLists, opt => opt.MapFrom(src => JsonHelper.TurnStringToList(src.BibleBookList != null ? src.BibleBookList.BookList : "")));
            CreateMap<BibleVerse, BibleVerseViewModel>().ReverseMap();

            CreateMap<BibleVersion, BibleVersionCreateViewModel>().ReverseMap();
            CreateMap<BibleVersion, BibleVersionEditViewModel>().ReverseMap();

            //Select List Items
            CreateMap<BibleVersion, SelectListItem>()
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Version))
               .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

        }

    }
}
