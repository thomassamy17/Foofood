using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExempleCours.Models;
using Microsoft.AspNetCore.Mvc;


namespace ExempleCours.Controllers
{
    public class OffresController : Controller
    {
        private List<Offre> offres = new List<Offre>()
        {
            new Offre(1,"Brownie","Au chocolat","https://static.750g.com/images/622-auto/5df6e20eacc62872a3e1640305892963/brownie-au-chocolat-noir.jpeg",12),
            new Offre(2,"Brownie blanc","Au chocolat blanc","https://img-3.journaldesfemmes.fr/0pzfJYdUsyk9N0uqNmE5Hl37RM0=/750x/smart/image-icu/10025520_1038048759.jpg",14),
            new Offre(3,"Brownie vanille","Au chocolat vanille","https://assets.afcdn.com/recipe/20130122/61722_w1024h768c1cx826cy952.jpg",11)
        };
        public IActionResult Index()
        {
            
            return View(offres);
        }
        public IActionResult Detail(int id)
        {
            Offre monOffre = null;
            if (offres != null)
            {
                foreach (Offre offre in offres)
                {
                    if (offre.Id == id)
                    {
                        monOffre = offre;
                    }
                }

            }
            return View(monOffre);
        }
    }
}
