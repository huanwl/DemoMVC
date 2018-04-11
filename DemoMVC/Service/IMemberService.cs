using DemoMVC.Models;
using DemoMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Service
{
    public interface IMemberService
    {
        IEnumerable<Member> GetAll();

        Member GetById(string id);

        bool Create(Member model);

        bool Update(Member model);

        bool Delete(string id);
    }
}