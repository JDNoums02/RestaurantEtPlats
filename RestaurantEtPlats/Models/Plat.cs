using System.ComponentModel.DataAnnotations;

namespace RestaurantEtPlats.Models
{
    public class Plat
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        public double Prix { get; set; }
        public string Categorie { get; set; }
        public string CheminImage { get; set; }
        public int RestaurantId { get; set; }
    
}
}
