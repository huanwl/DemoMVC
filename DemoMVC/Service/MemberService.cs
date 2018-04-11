using DemoMVC.Models;
using DemoMVC.Repository;
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

        public IEnumerable<Member> GetAll()
        {
            return _memberRepository.GetAll();
        }

        public Member GetById(string id)
        {
            return _memberRepository.GetById(id);
        }

        public bool Create(Member model)
        {
            _memberRepository.Create(model);
            _memberRepository.SaveChange();
            return true;
        }   

        public bool Update(Member model)
        {
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