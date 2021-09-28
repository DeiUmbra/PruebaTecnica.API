using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebtaTecnica.Biblioteca.Contexts;
using PruebtaTecnica.Biblioteca.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaTecnica.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PacienteGeneralController : ControllerBase
	{
		private readonly appDBContext context;

		public PacienteGeneralController(appDBContext context)
		{
			this.context = context;
		}

		// GET: api/PacienteGeneral
		[HttpGet]
		public IEnumerable<paciente_informacion> Get()
		{
			return context.paciente_informacion.ToList();
		}

		// GET: api/PacienteGeneral/5
		[HttpGet("{id}", Name = "GetPaciente")]
		public paciente_informacion Get(int id)
		{
			var paciente = context.paciente_informacion.FirstOrDefault(p => p.id_paciente == id);
			return paciente;
		}

		// POST: api/PacienteGeneral
		[HttpPost]
		public ActionResult Post([FromForm] paciente_informacion paciente)
		{
			try
			{
				paciente.date_created = DateTime.Now;
				context.paciente_informacion.Add(paciente);
				context.SaveChanges();
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		// PUT: api/PacienteGeneral/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromForm] paciente_informacion paciente)
		{
			if (paciente.id_paciente == id)
			{
				try
				{
					paciente.date_created = DateTime.Now;
					context.Entry(paciente).State = EntityState.Modified;
					context.SaveChanges();
					return Ok();
				}
				catch (Exception ex)
				{
					return BadRequest();
				}
			}
			else
			{
				return BadRequest();
			}
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			var paciente = context.paciente_informacion.FirstOrDefault(p => p.id_paciente == id);
			if (paciente != null)
			{
				context.Remove(paciente);
				context.SaveChanges();
				return Ok();
			}
			else
			{
				return BadRequest();
			}
		}
	}
}