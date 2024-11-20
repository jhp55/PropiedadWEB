using PropiedadesWEB.Models;
using System.ComponentModel.DataAnnotations;

namespace PropiedadesWEB.Models
{

	public class Propiedad
	{
		public int Id { get; set; }
		public string Direccion { get; set; }
		public string TipoPropiedad { get; set; }
		public int NumeroHabitaciones { get; set; }
		public int PrecioAlquiler { get; set; }
		public bool Disponible { get; set; }
		public ICollection<Contrato> Contratos { get; set; }
	}
}