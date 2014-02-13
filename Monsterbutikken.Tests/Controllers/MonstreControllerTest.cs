using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monsterbutikken;
using Monsterbutikken.Controllers;
using Monsterbutikken.Models;

namespace Monsterbutikken.Tests.Controllers
{
    [TestClass]
    public class MonstreControllerTest
    {
        [TestMethod]
        public void Get()
        {
            MonstreController controller = new MonstreController();

            IEnumerable<MonsterJson> result = controller.Get();

            Assert.IsNotNull(result);
            Assert.AreEqual(26, result.Count());
        }
    }
}
