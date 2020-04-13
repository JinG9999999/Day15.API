using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Day15.API.BLL;
using Day15.API.Model;

namespace Day15.API.UI.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        TAPDBLL bll = new TAPDBLL();
        public IEnumerable<TAPDModel> Get()
        {
            return bll.Show();
        }

        // GET: api/User/5
        public IEnumerable<TAPDModel> Get(string name)
        {
            var line = bll.Show();
            if (!string.IsNullOrEmpty(name))
            {
                line = line.Where(m => m.Name.Contains(name)).ToList(); ;
            }
            return line;
        }

        // POST: api/User
        public void Post([FromBody]TAPDModel m)
        {
            bll.Add(m);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public int Delete(string id)
        {
            return bll.Del(id);
        }
    }
}
