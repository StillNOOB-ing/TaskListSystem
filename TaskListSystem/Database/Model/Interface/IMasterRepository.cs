﻿using TaskListSystem.Database.Model;
using System.Linq.Expressions;

namespace TaskListSystem.Database.Interface
{
    public interface IMasterRepository
    {
        #region AccountInfo

        public IQueryable<MAccountInfo> GetAccountInfoDB(Expression<Func<MAccountInfo, bool>> predicate);
        public Task<List<MAccountInfo>> GetAccountInfoAll(Expression<Func<MAccountInfo, bool>> predicate);
        public Task<ResultInfo> InsertAccountInfo(MAccountInfo item);
        public Task<ResultInfo> UpdateAccountInfo(MAccountInfo item);
        public Task<ResultInfo> DeleteAccountInfo(MAccountInfo item);

        #endregion

        #region UserLevelRight

        public IQueryable<MUserLevelRight> GetUserLevelRightDB(Expression<Func<MUserLevelRight, bool>> predicate);
        public Task<List<MUserLevelRight>> GetUserLevelRightAll(Expression<Func<MUserLevelRight, bool>> predicate);
        public Task<ResultInfo> InsertUserLevelRight(MUserLevelRight item);
        public Task<ResultInfo> UpdateUserLevelRight(MUserLevelRight item);
        public Task<ResultInfo> DeleteUserLevelRight(MUserLevelRight item);

        #endregion

        #region Status

        public IQueryable<MStatus> GetStatusDB(Expression<Func<MStatus, bool>> predicate);
        public Task<List<MStatus>> GetStatusAll(Expression<Func<MStatus, bool>> predicate);
        public Task<ResultInfo> InsertStatus(MStatus item);
        public Task<ResultInfo> UpdateStatus(MStatus item);
        public Task<ResultInfo> DeleteStatus(MStatus item);

        #endregion

        #region Type

        public IQueryable<MType> GetTypeDB(Expression<Func<MType, bool>> predicate);
        public Task<List<MType>> GetTypeAll(Expression<Func<MType, bool>> predicate);
        public Task<ResultInfo> InsertType(MType item);
        public Task<ResultInfo> UpdateType(MType item);
        public Task<ResultInfo> DeleteType(MType item);

        #endregion
    }
}
