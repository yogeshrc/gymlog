using GymLogService.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace GymLogService.Controllers
{
    public class ValuesController : ApiController
    {
        private List<BodyPart> _values;

        public ValuesController()
        {
            _values = new List<BodyPart>();
        }

        // GET api/values
        public IEnumerable<BodyPart> Get()
        {
            return _values;
        }

        // GET api/values/5
        public BodyPart Get(int id)
        {
            return _values[id];
        }

        // POST api/values
        public void Post([FromBody]BodyPart value)
        {
            _values.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]BodyPart value)
        {
            _values[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _values.RemoveAt(id);
        }
    }
}
