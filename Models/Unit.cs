using System.ComponentModel.DataAnnotations;

namespace CompanyCore.Models
{
    public class Unit
    {
        [Key] 
        public int UnitID { get; set; }
        public string UnitName { get; set; }
        public IList<Personel> Personels { get; set; }
    }
}
