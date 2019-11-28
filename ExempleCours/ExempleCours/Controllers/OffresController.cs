using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExempleCours.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using Dapper;


namespace ExempleCours.Controllers
{
    public class OffresController : Controller
    {
        public IActionResult Index()
        {
            var chaineConnexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Program .NET\Foofood-master\ExempleCours\ExempleCours\Data\Data.mdf; Integrated Security = True; Connect Timeout = 30";

            try
            {
                using (var connection = new SqlConnection(chaineConnexion))
                {
                    var galerie = connection.Query<OffreEntite>("SELECT * FROM Offre");

                    return View(galerie);

                } // Appel du Dispose de connection (ferme la connexion)
            }
            catch (SqlException e)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(OffreEntite nouveau)
        {
            if (ModelState.IsValid)
            {
                var chaineConnexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Program .NET\Foofood-master\ExempleCours\ExempleCours\Data\Data.mdf; Integrated Security = True; Connect Timeout = 30";

                try
                {
                    using (var connection = new SqlConnection(chaineConnexion))
                    {
                        connection.Execute("INSERT INTO Offre (Titre,Description,Url,Prix,UserId) VALUES (@Titre,@Description,@Url,@Prix,1)",nouveau);

                        return RedirectToAction(nameof(Index));

                    }
                }
                catch (SqlException e)
                {
                    return RedirectToAction(e.Message, "Home");
                }
            }
            return View();
        }

        public IActionResult Detail(int id)
        {
            var chaineConnexion = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Program .NET\Foofood-master\ExempleCours\ExempleCours\Data\Data.mdf; Integrated Security = True; Connect Timeout = 30";

            try
            {
                using (var connection = new SqlConnection(chaineConnexion))
                {
                    var galerie = connection.QueryFirst<OffreEntite>("SELECT * FROM Offre WHERE Id = @Id",new { Id = id });

                    return View(galerie);

                } // Appel du Dispose de connection (ferme la connexion)
            }
            catch (SqlException e)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
