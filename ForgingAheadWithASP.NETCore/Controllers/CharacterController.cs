using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ForgingAheadWithASP.NETCore.Models;

namespace ForgingAheadWithASP.NETCore.Controllers
{
	public class CharacterController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CharacterController(ApplicationDbContext context)
		{
			this._context = context;
		}

		public IActionResult Create(Character character)
		{
			_context.Characters.Add(character);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
