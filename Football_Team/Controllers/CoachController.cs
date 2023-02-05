using BusinessLayer.Repositories;
using BusinessLayer.Repositories.Model;
using DataAccessLayer.EntityFramework;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Entities.ViewModel.Coach;
using Microsoft.EntityFrameworkCore;

namespace Football_Team.Controllers
{
    public class CoachController : Controller
    {
        CoachRepository coachRepository = new CoachRepository(new EfCoachRepository());
        TeamRepository teamRepository = new TeamRepository(new EfTeamRepository());

        public IActionResult Index()
        {
            var value = coachRepository.GetList();
            return View(value);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categorys = teamRepository.GetList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddCoachModel model)
        {
            var guidId = Guid.NewGuid();
            coachRepository.TAdd(new Entities.Model.Coach { Id = guidId, Name = model.Name,TeamId=model.TeamId, Status = true, CreatedDateOnUTC = DateTime.Now });
            return View("Team/Index");
        }
    }
}
