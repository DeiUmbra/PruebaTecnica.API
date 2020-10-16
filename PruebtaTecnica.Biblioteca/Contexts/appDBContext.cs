using Microsoft.EntityFrameworkCore;
using PruebtaTecnica.Biblioteca.Entities;

namespace PruebtaTecnica.Biblioteca.Contexts
{
	public class appDBContext : DbContext
	{
		public appDBContext(DbContextOptions<appDBContext> options) : base(options)
		{
		}

		public DbSet<afiliado_datos_generales> afiliado_datos_generales { get; set; }
	}
}