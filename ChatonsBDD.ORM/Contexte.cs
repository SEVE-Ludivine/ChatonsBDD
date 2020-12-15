using Microsoft.EntityFrameworkCore;
using System;

namespace ChatonsBDD.ORM
{
    public class Contexte : DbContext 
    {
        public DbSet<Chaton> Chatons { get; set; }
        public DbSet<Categorie> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //En vrai on me mettrai surtout pas la chaine de connexion en dur dans le code !!
            //On la bougerai dans un fichier de config
            options.UseSqlite("Data Source=chatons.db");
        }
    }
}
