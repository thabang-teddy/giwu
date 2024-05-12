using Admin.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Models;
using Utility.helpers;

namespace Admin.Profiles
{
    public class BibleViewProfile : Profile
    {
        public BibleViewProfile()
        {
            // CreateMap<source, destination>();
            CreateMap<BibleVersion, BibleVersionDatatableViewModel>().ReverseMap();
            CreateMap<BibleVersion, BibleVersionViewModel>()
                .ForMember(dest => dest.BibleBookLists, opt => opt.MapFrom(src => JsonHelper.TurnStringToList(src.BookList)));
            CreateMap<BibleVerse, BibleVerseViewModel>().ReverseMap();
        }

    }
}
