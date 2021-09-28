using System;
using System.ComponentModel.DataAnnotations;

namespace PruebtaTecnica.Biblioteca.Entities
{
	public class diagnostico
	{
		[Key]
		public int id_diagnostico { get; set; }
		public int paciente_id { get; set; }
		public int doctor_id { get; set; }
		public string diagnostico_texto { get; set; }
		public DateTime? date_created { get; set; }

	}
}