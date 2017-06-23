using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Interfaces;

namespace BettingApp.Controllers
{
    public class FixturesController : Controller
    {
        private readonly IFixtureInfo _fixture;

        public FixturesController(IFixtureInfo fixture)
        {
            _fixture = fixture;
        }
        // GET: Fixtures
        public ActionResult Index()
        {
            var fixtures = _fixture.GetAllFixtures();
            return View(fixtures);
        }
    }
}