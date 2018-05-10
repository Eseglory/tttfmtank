using System;
using System.Collections.Generic;
using System.Linq;

namespace Fill.My.Tank.Common.Contracts
{
    public interface IDataRepositoryFactory
    {
        T GetDataRepository<T>() where T : IDataRepository;
    }
}
