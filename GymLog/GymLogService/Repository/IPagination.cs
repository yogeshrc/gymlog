namespace GymLogService.Repository
{
    interface IPagination<TEntity> where TEntity: class
    {
        PagedResult<TEntity> Search(int pageNumber, int pageSize);
    }
}
