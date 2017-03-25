using System;

namespace GymLogService.Repository
{
    /*
     * Use this interface for transactional updates
     */
    interface IUnitOfWork: IDisposable
    {
        void SaveChanges();
    }
}
