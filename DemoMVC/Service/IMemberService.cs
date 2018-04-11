using DemoMVC.Models;
using DemoMVC.Repository;
using DemoMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Service
{
    public interface IMemberService
    {
        IEnumerable<MemberVM> GetAll();

        MemberVM GetById(string id);

        bool Create(MemberVM vm);

        bool Update(MemberVM vm);

        bool Delete(string id);
    }
}