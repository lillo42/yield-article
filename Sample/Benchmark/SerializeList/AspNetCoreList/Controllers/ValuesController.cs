using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreList.Controllers 
{
    [Route ("api/[controller]")]
    public class ValuesController : Controller 
    {
        private const int MAX = 1_000_000;
        // GET api/values
        [HttpGet ("NoYield")]
        public IEnumerable<int> NoYield () 
        {
            var list = new List<int> (MAX);
            for (int i = 0; i < MAX; i++) 
            {
                list.Add (i);
            }
            return list;
        }

        [HttpGet ("Yield")]
        public IEnumerable<int> Yield () 
        {
            for (int i = 0; i < MAX; i++) 
            {
                yield return i;
            }
        }

    }
}