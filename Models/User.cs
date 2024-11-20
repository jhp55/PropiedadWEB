using System.ComponentModel.DataAnnotations;

namespace PropiedadWEB.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
