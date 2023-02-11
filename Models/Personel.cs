using System.ComponentModel.DataAnnotations;

namespace CompanyCore.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelName { get; set; }
        public string PersonelLastName { get; set; }
        public string PersonelCity{ get; set; }
        public int UnitID { get; set; }
        public Unit Unit { get; set; }

    }
}
