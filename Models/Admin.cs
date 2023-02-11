using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyCore.Models
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }

		[Column(TypeName = "Varchar(20)")]
		public string User { get; set; }

		[Column(TypeName = "Varchar(50)")]
		public string Password { get; set; }
	}
}
