using Monsterbutikken.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Monsterbutikken.Controllers
{
    public class MonstreController : ApiController
    {
        public IEnumerable<MonsterJson> Get()
        {
            IList<MonsterJson> list = new List<MonsterJson>();
            list.Add(new MonsterJson("Ao (skilpadde)", 100000));
            list.Add(new MonsterJson("Bakeneko", 120000));
            list.Add(new MonsterJson("Basilisk", 175000));
            list.Add(new MonsterJson("Det erymanthiske villsvin", 100));
            list.Add(new MonsterJson("Griff", 100));
            list.Add(new MonsterJson("Hamløper", 100));
            list.Add(new MonsterJson("Hippogriff", 100));
            list.Add(new MonsterJson("Hydra", 100));
            list.Add(new MonsterJson("Kentaur", 100));
            list.Add(new MonsterJson("Kerberos", 100));
            list.Add(new MonsterJson("Kraken", 100));
            list.Add(new MonsterJson("Mannbjørn", 100));
            list.Add(new MonsterJson("Mantikora", 100));
            list.Add(new MonsterJson("Margyge", 100));
            list.Add(new MonsterJson("Marmæle", 100));
            list.Add(new MonsterJson("Minotauros", 100));
            list.Add(new MonsterJson("Nekomusume", 100));
            list.Add(new MonsterJson("Rokk", 100));
            list.Add(new MonsterJson("Seljordsormen", 100));
            list.Add(new MonsterJson("Sfinks", 100));
            list.Add(new MonsterJson("Sirene", 100));
            list.Add(new MonsterJson("Sjøorm", 100));
            list.Add(new MonsterJson("Succubus", 100));
            list.Add(new MonsterJson("Valravn", 100));
            list.Add(new MonsterJson("Vampyr", 100));
            list.Add(new MonsterJson("Varulv", 100));
            return list.OrderBy(m => m.navn);
        }
    }
}