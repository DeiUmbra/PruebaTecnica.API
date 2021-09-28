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
	public class DiagnosticoDataController : ControllerBase
	{
		private readonly appDBContext context;

		public DiagnosticoDataController(appDBContext context)
		{
			this.context = context;
		}

		// GET: api/diagnosticoGeneral
		[HttpGet]
		public IEnumerable<diagnostico> Get()
		{
			return context.diagnostico.ToList();
		}

		// GET: api/diagnosticoGeneral/5
		[HttpGet("{id}", Name = "GetDiagnostico")]
		public diagnostico Get(int id)
		{
			var diagnostico = context.diagnostico.FirstOrDefault(p => p.id_diagnostico == id);
			return diagnostico;
		}

		// POST: api/CitaGeneral
		[HttpPost]
		public ActionResult Post([FromForm] diagnostico diagnostico)
		{
			try
			{
				diagnostico.date_created = DateTime.Now;
				context.diagnostico.Add(diagnostico);
				context.SaveChanges();
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest();
			}
		}

		// PUT: api/diagnosticoGeneral/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromForm] diagnostico diagnostico)
		{
			if (diagnostico.id_diagnostico == id)
			{
				try
				{
					context.Entry(diagnostico).State = EntityState.Modified;
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
			var diagnostico = context.diagnostico.FirstOrDefault(p => p.id_diagnostico == id);
			if (diagnostico != null)
			{
				context.Remove(diagnostico);
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