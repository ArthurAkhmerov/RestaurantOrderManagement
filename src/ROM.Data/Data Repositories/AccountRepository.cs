using System.Collections.Generic;
using System.Linq;
using Core.Common.Data;
using ROM.Business.Entities;
using ROM.Data;
using ROM.Data.Contracts;

namespace ROM.Data
{
    public class AccountRepository : DataRepositoryBase<Account>, IAccountRepository
    {

        protected override Account AddEntity(ROMContext entityContext, Account entity)
        {
            return entityContext.AccountSet.Add(entity);
        }

        protected override Account UpdateEntity(ROMContext entityContext, Account entity)
        {
            return (from e in entityContext.AccountSet
                where e.AccountId == entity.AccountId
                select e).FirstOrDefault();
        }

        protected override IEnumerable<Account> GetEntities(ROMContext entityContext)
        {
            return from e in entityContext.AccountSet
                select e;
        }

        protected override Account GetEntity(ROMContext entityContext, int id)
        {
            var query = (from e in entityContext.AccountSet
                where e.AccountId == id
                select e);
            var results = query.FirstOrDefault();

            return results;
        }

        #region IAccountRepository Members

        public Account GetByLogin(string login)
        {
            using (ROMContext entityContext = new ROMContext())
            {
                return (from a in entityContext.AccountSet
                    where a.LoginEmail == login
                    select a).FirstOrDefault();
            }
        }

        #endregion
    }
}