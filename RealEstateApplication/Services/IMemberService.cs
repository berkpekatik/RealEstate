using RealEstateApplication.Dtos;
using System.Collections.Generic;

namespace RealEstateApplication.Services
{
    public interface IMemberService
    {
        MemberDto Add(MemberDto member);
        MemberDto Get(int id);
        MemberDto Update(MemberDto member);
        List<MemberDto> GetAll();
    }
}
