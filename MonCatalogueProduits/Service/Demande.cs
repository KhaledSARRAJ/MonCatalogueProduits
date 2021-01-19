using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MonCatalogueProduit.Service
{
    [Table("DEMANDES")]  //Nom de table à manipuler
    public class Demande
    {
        [Key] 
        public int DemandeID { get; set; }  
        [Required,MinLength(6),MaxLength(70)] //
        [StringLength(70)] // taille 
        public string Designation { get; set; }
        [Required,Range(10,500000)]
        public string Lieu { get; set; }
        public string Description { get; set; }

        public int CategorieID { get; set; }
        [ForeignKey("CategorieID")]  // clè etranger

        //lazy loading : eviter de charger les entités lièes en mèmoire sans en avoir besoin
        //include aprés pour l'appeler
        public virtual Categorie Categorie { get; set;  }



    }
}
