using System;
using System.ComponentModel.Composition;
using System.Linq;
using Fill.My.Tank.Common.Contracts;
using Fill.My.Tank.Common.Core;

namespace Fill.My.Tank.Common.Data
{
    [Export(typeof(IDataRepositoryFactory))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class DataRepositoryFactory : IDataRepositoryFactory
    {
        T IDataRepositoryFactory.GetDataRepository<T>()
        {
            return ObjectBase.Container.GetExportedValue<T>();
        }
    }
}
