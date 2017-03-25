using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using GymLogService.Models;
using GymLogService.Repository;
using System.Collections.Generic;
using Microsoft.OData;

namespace GymLogService.Controllers
{
    public class ExercisesController : ODataController
    {
        private static IExerciseRepository _exerciseRepository = new MockExerciseRepository();
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Exercises
        public async Task<IHttpActionResult> GetExercises(ODataQueryOptions<Exercise> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok<IEnumerable<Exercise>>(_exerciseRepository.Search());
        }

        // GET: odata/Exercises(5)
        public async Task<IHttpActionResult> GetExercise([FromODataUri] int key, ODataQueryOptions<Exercise> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok<Exercise>(_exerciseRepository.Get(key));
        }

        // PUT: odata/Exercises(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Exercise> delta)
        {
            Validate(delta.GetInstance());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(exercise);

            // TODO: Save the patched entity.

            // return Updated(exercise);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Exercises
        public async Task<IHttpActionResult> Post(Exercise exercise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(exercise);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Exercises(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Exercise> delta)
        {
            Validate(delta.GetInstance());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(exercise);

            // TODO: Save the patched entity.

            // return Updated(exercise);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Exercises(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
