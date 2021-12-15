using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private List<Services> _services;

        private List<Testimonials> _testimonials;
        
        public HomeController()
        {
            _services = new List<Services>
            {
                new Services{Id=1,Icon="",Title="Main Title",Text="is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,"},
                new Services{Id=2,Icon="",Title="Lorem Ipsum",Text="It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout."},
                new Services{Id=3,Icon="",Title="Ipsum Lorem",Text="Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC,"},
                new Services{Id=4,Icon="",Title="Main Text",Text="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form"}

            };

            _testimonials = new List<Testimonials>
            {
                new Testimonials{Id=1, Image="",Name="Fatime", Position="CEO",Text="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some"},
                 new Testimonials{Id=2, Image="",Name="Elnur", Position="CEO",Text="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some"},
                  new Testimonials{Id=3, Image="",Name="Eyyub", Position="CEO",Text="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some"},
               new Testimonials{Id=4, Image="",Name="Eli", Position="CEO",Text="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some"}

            };


        }
        public ActionResult Index()
        {
            HomeViewModel HMW = new HomeViewModel
            {
                Services = _services,
                Testimonials = _testimonials

            };
            return View(HMW);
        }

      
    }
   


}
