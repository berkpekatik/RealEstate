using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using RealEstateApplication.Dtos;
using RealEstateData;

namespace RealEstateApplication.Services
{
    public class MemberService : IMemberService
    {
        private readonly IRepository<Member> _memberRepository;

        public MemberService(IRepository<Member> memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public MemberDto Add(MemberDto member)
        {
            var data = Mapper.Map<Member>(member);
            _memberRepository.Insert(data);
            _memberRepository.SaveAll();
            return Mapper.Map<MemberDto>(data);
        }

        public MemberDto Get(int id)
        {
            var result = _memberRepository.Table.FirstOrDefault(x => x.MemberId == id);
            return Mapper.Map<MemberDto>(result);
        }
        public List<MemberDto> GetAll()
        {
            var result = _memberRepository.Table.ToList();
            return Mapper.Map<List<MemberDto>>(result);
        
        }
        public MemberDto Update(MemberDto member)
        {
            var result = _memberRepository.Table.FirstOrDefault(x => x.MemberId == member.MemberId);
            result.Username = member.Username;
            result.Password = member.Password;
            result.Email = member.Email;
            _memberRepository.SaveAll();
            return member;
        }

    }
}
