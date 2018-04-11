using AutoMapper;
using DemoMVC.Models;
using DemoMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.App_Start
{
    public class MapperConfig
    {
        public static IMapper Mapper { get; set; }

        public static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Member, MemberVM>();
                cfg.CreateMap<MemberVM, Member>();
             });

            Mapper = config.CreateMapper();
        }
    }
}