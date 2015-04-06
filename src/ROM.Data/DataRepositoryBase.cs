using Core.Common.Contracts;
using Core.Common.Data;

namespace ROM.Data
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, ROMContext>
        where T : class, IIdentifiableEntity, new()
    {
    }
}
