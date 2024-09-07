using Admin.ViewModel.BibleVersion;
using DataAccess.ViewModel.BibleView;
using AutoMapper;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Utility.helpers;
using Admin.ViewModel.BibleBookList;

namespace Admin.Profiles
{
    public class BibleBookListProfile : Profile
    {
        public BibleBookListProfile()
        {
            // CreateMap<source, destination>();
            CreateMap<BibleBookList, BibleBookListDatatableViewModel>()
                .ForMember(dest => dest.BookList, opt => opt.MapFrom(src => TextHelper.MinimizeLength(src.BookList, 40)));
            CreateMap<BibleBookList, BibleBookListDetailsViewModel>().ReverseMap();
            CreateMap<BibleBookList, BibleBookListEditViewModel>().ReverseMap();
            CreateMap<BibleBookList, BibleBookListViewModel>().ReverseMap();

            //Select List Items
            CreateMap<BibleBookList, SelectListItem>()
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

        }

    }
}
