using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Model;

namespace Common.Services
{
    public class Fixture : IFixtureInfo
    {
        public FixtureModel GetFixture(int id)
        {
            //web api connect

            return new FixtureModel
            {
                ID = id,
                HomeTeam = "Liverpool FC",
                AwayTeam = "Everton FC",
                KickOff = new DateTime(2017, 10, 21, 15, 00, 00)
            };
        }

        public bool UpdateFixture(FixtureModel fixtureModel)
        {
            return true;
        }

        public IEnumerable<FixtureModel> GetAllFixtures()
        {
            return new[]
            {
                new FixtureModel {AwayTeam = "1", HomeTeam = "2",ID = 11},
                new FixtureModel {AwayTeam = "3", HomeTeam = "4", ID=22}
            };
        }
    }
}
