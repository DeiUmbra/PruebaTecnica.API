using Microsoft.EntityFrameworkCore;
using PruebtaTecnica.Biblioteca.Contexts;
using PruebtaTecnica.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PruebaTecnica.UnitTest
{
	public class AfiliadoDataGeneralTEST
	{
		[Fact]
		public void Test1()
		{
			var options = new DbContextOptionsBuilder<appDBContext>()
			.UseInMemoryDatabase(databaseName: "dbPruebaTecnicaAFP")
			.Options;

			using (var context = new appDBContext(options))
			{
				context.afiliado_datos_generales.Add(new afiliado_datos_generales()
				{
					afi_id = 1,
					afi_nombre = "Jose",
					afi_apellido = "Martinez",
					afi_direccion = "Avenida 103, casa 22 Zacamil",
					afi_dui = "032908271",
					afi_datecreated = DateTime.Now,
					afi_dateupdated = DateTime.Now,
					afi_status = 1
				});
				context.SaveChanges();
			}

			using (var context = new appDBContext(options))
			{
				List<afiliado_datos_generales> afiliado = context.afiliado_datos_generales.ToList();


				Assert.Equal(1, afiliado.Count);
			}


		}
	}
}
