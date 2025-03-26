using TaskListSystem.Database.Model;
using TaskListSystem.Database;
using System.Linq.Expressions;

namespace TaskListSystem.Database.Interface
{
    public interface ITaskRepository
    {
        #region DailyTask

        public IQueryable<TDailyTask> GetDailyTaskDB(Expression<Func<TDailyTask, bool>> predicate);
        public Task<List<TDailyTask>> GetDailyTaskAll(Expression<Func<TDailyTask, bool>> predicate);
        public Task<ResultInfo> InsertDailyTask(TDailyTask item);
        public Task<ResultInfo> UpdateDailyTask(TDailyTask item);
        public Task<ResultInfo> DeleteDailyTask(TDailyTask item);

        #endregion
    }
}
