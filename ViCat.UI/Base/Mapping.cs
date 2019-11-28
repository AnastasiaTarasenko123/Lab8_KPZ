using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViCat.UI.ViewModels;

namespace ViCat.UI.Base
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<CatViewModel, Cat>();
            Mapper.CreateMap<Cat, CatViewModel>();

            Mapper.CreateMap<AppearanceViewModel, Appearance>();
            Mapper.CreateMap<Appearance, AppearanceViewModel>();

            Mapper.CreateMap<UsersViewModel, User>();
            Mapper.CreateMap<User, UsersViewModel>();
        }
    }
}