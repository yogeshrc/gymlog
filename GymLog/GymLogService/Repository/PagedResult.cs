using System.Collections.Generic;

namespace GymLogService.Repository
{
    public class PagedResult<TEntity>
    {
        private IEnumerable<TEntity> _itemsInThePage;
        private int _totalItemsInThePage;

        public PagedResult(IEnumerable<TEntity> itemsInThePage, int totalItemsInThePage)
        {
            _itemsInThePage = itemsInThePage;
            _totalItemsInThePage = totalItemsInThePage;
        }
    }
}