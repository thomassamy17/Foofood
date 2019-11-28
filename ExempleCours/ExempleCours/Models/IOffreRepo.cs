using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExempleCours.Models
{
    public interface IOffreRepo
    {
        IEnumerable<OffreEntite> All { get;}
        OffreEntite GetById(int id);

        void Save(OffreEntite offre);
    }
}