using System;
using System.Collections.Generic;
using System.Linq;

namespace Fill.My.Tank.Common.Contracts
{
    public interface IDataRepository
    {

    }

    public interface IDataRepository<T> : IDataRepository
        where T : class, IIdentifiableEntity, new()
    {
        T Add(T entity);

        void Remove(T entity);

        void Remove(long id);

        T Update(T entity);

        IEnumerable<T> Get();

        T Get(long id);
    }
}
