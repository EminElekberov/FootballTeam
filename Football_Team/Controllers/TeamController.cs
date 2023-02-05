using BusinessLayer.Repositories;
using DataAccessLayer.EntityFramework;
using Entities;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Football_Team.Controllers
{
    public class TeamController : Controller
    {
        TeamRepository teamRepository = new TeamRepository(new EfTeamRepository());
        public IActionResult Index()
        {
            var value = teamRepository.GetList();
            return View(value);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddTeamModel model)
        {
            var guidId = Guid.NewGuid();
            teamRepository.TAdd(new Entities.Model.Team { Id = guidId, Title = model.Title, Status = true, CreatedDateOnUTC = DateTime.Now });
            return View("Team/Index");
        }
        public async Task<IActionResult> Delete(Guid id)
        {
            var value = teamRepository.GetById(id);
            if (value != null)
            {
                value.Status = false;
                teamRepository.TUpdate(value);
            }
            return Redirect("/Team/Index");
        }
        public async Task<IActionResult> Details(Guid id)
        {
            var value = teamRepository.GetById(id);
            return View(value);
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var value = teamRepository.GetById(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateTeamModel model)
        {
            var value = teamRepository.GetById(model.Id);
            if (value != null)
            {

                value.Title = model.Title;
                value.Status = true;
                value.ModifiedDateOnUTC = DateTime.Now;
                value.CreatedDateOnUTC = DateTime.Now;
                teamRepository.TUpdate(value);
            }
            return Redirect("/Team/Index");
        }
    }
}
