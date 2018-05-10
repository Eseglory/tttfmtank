using System;
using System.Collections.Generic;
using System.Linq;

namespace Fill.My.Tank.Common.Contracts
{
    public interface IServiceFactory
    {
        T CreateClient<T>() where T : IServiceContract;
    }
}