using AutoMapper;
using RealEstate.Models;
using RealEstateApplication.Dtos;
using RealEstateApplication.Services;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class MemberController : Controller
    {

        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        public ActionResult Index()
        {
            var memberList = _memberService.GetAll();
            var model = Mapper.Map<List<MemberModel>>(memberList);
            return View(model);
        }
    }
}