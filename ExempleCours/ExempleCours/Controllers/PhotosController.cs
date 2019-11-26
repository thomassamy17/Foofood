using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExempleCours.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExempleCours.Controllers
{
    public class PhotosController : Controller
    {
        public IActionResult Index()
        {
            var galerie = new List<Photo>()
            {
                new Photo(titre: "chat A", url: "chat.jpg"),
                new Photo(titre: "chat B", url: "chat.jpg"),
                new Photo(titre: "chat C", url: "chat.jpg")
            };

            for(var i=0; i<galerie.Count; i++)
            {
                galerie[i].AugmenterLesVues();
            }
            foreach (var photo in galerie)
            {
                photo.AugmenterLesVues();
            }
            return View(galerie);
        }
    }
}