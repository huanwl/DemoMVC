using AutoMapper;
using DemoMVC.App_Start;
using DemoMVC.Models;
using DemoMVC.Repository;
using DemoMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Service
{
    public class MemberService : IMemberService
    {
        readonly IRepository<Member> _memberRepository;

        public MemberService(Repository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public IEnumerable<MemberVM> GetAll()
        {
            var models = _memberRepository.GetAll();
            var vms = MapperConfig.Mapper.Map<IEnumerable<MemberVM>>(models);
            return vms;
        }

        public MemberVM GetById(string id)
        {
            var model = _memberRepository.GetById(id);
            var vm = MapperConfig.Mapper.Map<MemberVM>(model);
            return vm;
        }

        public bool Create(MemberVM vm)
        {
            var model = MapperConfig.Mapper.Map<Member>(vm);
            _memberRepository.Create(model);
            _memberRepository.SaveChange();
            return true;
        }   

        public bool Update(MemberVM vm)
        {
            var model = MapperConfig.Mapper.Map<Member>(vm);
            _memberRepository.Update(model);
            _memberRepository.SaveChange();
            return true;
        }

        public bool Delete(string id)
        {
            var model = _memberRepository.GetById(id);
            _memberRepository.Delete(model);
            _memberRepository.SaveChange();
            return true;
        }
    }
}