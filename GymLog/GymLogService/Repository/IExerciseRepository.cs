using GymLogService.Models;
using System.Collections.Generic;

namespace GymLogService.Repository
{
    interface IExerciseRepository: IRepository<Exercise, int>, IPagination<Exercise>
    {
        IEnumerable<Exercise> Search();
        IEnumerable<Exercise> Search(string exerciseName);
    }
}
