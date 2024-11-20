using Microsoft.EntityFrameworkCore;
using PropiedadesWEB.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;
using PropiedadWEB.Models;

namespace PropiedadesWEB.Data
{
	public class PropiedadesContext : DbContext
	{
		public DbSet<Propiedad> Propiedads { get; set; }
		public DbSet<Inquilino> Inquilinos { get; set; }
		public DbSet<Contrato> Contratos { get; set; }
		public DbSet<Pago> Pagos { get; set; }
		public DbSet<User> User { get; set; }
	}

	
}
