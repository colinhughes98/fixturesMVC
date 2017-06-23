using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BettingApp.ViewModels;
using Common.Interfaces;
using Common.Model;
using Common.Services;

namespace BettingApp.Controllers
{
    public class FixtureDetailController : Controller
    {
        private readonly IFixtureInfo _fixture;

        public FixtureDetailController(IFixtureInfo fixture)
        {
            _fixture = fixture;
        }
        // GET: Fixtures
        public ActionResult Index()
        {
            var fixtureFromService = _fixture.GetFixture(1);
            var vm = ModelFactory.Create(fixtureFromService);
            return View(vm);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(FixtureViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _fixture.UpdateFixture(ModelFactory.Create(vm));
            }
            return View(vm);
        }

        public ActionResult Edit(int id)
        {            
            return new EmptyResult();
        }

        public ActionResult GetFixture(int id)
        {
            var fixtureFromService = _fixture.GetFixture(id);
            var vm = ModelFactory.Create(fixtureFromService);
            return View(vm);
        }
    }

    public static class ModelFactory
    {
        public static FixtureViewModel Create(FixtureModel fixture)
        {
            return new FixtureViewModel {AwayTeam = fixture.AwayTeam, HomeTeam = fixture.HomeTeam};
        }

        public static FixtureModel Create(FixtureViewModel viewModel)
        {
            return new FixtureModel {AwayTeam = viewModel.AwayTeam, HomeTeam = viewModel.HomeTeam};
        }
    }
}