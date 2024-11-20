﻿using PropiedadesWEB.Models;
using System.ComponentModel.DataAnnotations;

namespace PropiedadesWEB.Models
{
	public class Inquilino
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public string Telefono { get; set; }
		public string Email { get; set; }
		public ICollection<Contrato> Contratos { get; set; }
	}

}