using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace ExempleCours.Models
{
    public class OffreRepo : IOffreRepo
    {
        private IDbConnection connection;

        public OffreRepo(IDbConnection connection)
        {
            this.connection = connection;
        }
        public IEnumerable<OffreEntite> All => connection.Query<OffreEntite>("SELECT * FROM Offre");

        public OffreEntite GetById(int id) => connection.QueryFirst<OffreEntite>(
            "SELECT * FROM Offre Where Id=@Id",
            new {Id = id}
        );

        public void Save(OffreEntite offre)
        {
            string sql;
            if (offre.Id.HasValue)
            {
                sql = "UPDATE Offre SET Titre=@Titre, Url=@Url, Description=@Description, Prix=@Prix, UserId=@UserId WHERE Id=@Id";
            }
            else
            {
                sql = "INSERT INTO Offre (Titre, Url, Description, Prix, UserId) VALUES (@Titre, @Url, @Description, @Prix, @UserId)";
            }
        }
    }
}