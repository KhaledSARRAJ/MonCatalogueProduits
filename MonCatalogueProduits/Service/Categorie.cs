using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonCatalogueProduit.Service
{
    [Table ("CATEGORIES")] //c'est le nom de table à manipuler
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }
        [StringLength(30)]       //pour spécifier la taille à modifier
        public string NomCategorie { get; set; }
        public virtual ICollection<Demande> Produits { get; set; }
    }
}
