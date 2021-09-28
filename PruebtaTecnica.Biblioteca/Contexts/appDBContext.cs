using Microsoft.EntityFrameworkCore;
using PruebtaTecnica.Biblioteca.Entities;

namespace PruebtaTecnica.Biblioteca.Contexts
{
	public class appDBContext : DbContext
	{
		public appDBContext(DbContextOptions<appDBContext> options) : base(options)
		{
		}

		public DbSet<paciente_informacion> paciente_informacion { get; set; }

		public DbSet<doctor_informacion_basica> doctor_informacion_basica { get; set; }

		public DbSet<cita> cita { get; set; }

		public DbSet<diagnostico> diagnostico { get; set; }
	}
}