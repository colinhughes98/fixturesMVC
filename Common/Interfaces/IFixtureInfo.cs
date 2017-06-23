using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Interfaces
{
    public interface IFixtureInfo
    {
        FixtureModel GetFixture(int id);
        bool UpdateFixture(FixtureModel fixtureModel);
        IEnumerable<FixtureModel> GetAllFixtures();
    }
}
