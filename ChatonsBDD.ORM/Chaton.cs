using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChatonsBDD.ORM
{
    public class Chaton
    {
        public int Id { get; set; }

        //Les dataannotations vont permettre d'ajouter des contraintes pour la création de la BDD
        [MaxLength(50)]
        public string Nom { get; set; }


        //Le ? veut dire Nullable<DateTime>
        public DateTime? DateDeNaissance { get; set; }


        public bool? Sterilise { get; set; }


        public bool? EstUneFemelle { get; set; }

        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }





    }
}
