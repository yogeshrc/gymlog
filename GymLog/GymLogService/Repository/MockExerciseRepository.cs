using System;
using System.Collections.Generic;
using System.Linq;
using GymLogService.Models;

namespace GymLogService.Repository
{
    public class MockExerciseRepository : IExerciseRepository
    {
        private Exercise[] _exerciseList = new Exercise[]
        {
            new Exercise { Id = 1, Name = "Treadmill" },
            new Exercise {Id = 2, Name = "Half crunches" },
            new Exercise {Id= 3, Name = "Cycling" },
            new Exercise {Id = 4, Name = "Oblique crunches" },
            new Exercise {Id = 5, Name = "Reverse crunches" },
            new Exercise {Id = 6, Name = "Pull ups" },
            new Exercise {Id = 7, Name = "Dumbell curl" },
            new Exercise {Id = 8, Name = "Wrist curl" }
        };

        public void Delete(Exercise entity)
        {
            throw new NotImplementedException();
        }

        public Exercise Get(int id)
        {
            return _exerciseList.SingleOrDefault(e => e.Id == id);
        }

        public void Save(Exercise entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exercise> Search()
        {
            return _exerciseList;
        }

        public IEnumerable<Exercise> Search(string exerciseName)
        {
            return _exerciseList.Where(e => e.Name.ToLower().Contains(exerciseName.ToLower()));
        }

        public PagedResult<Exercise> Search(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}