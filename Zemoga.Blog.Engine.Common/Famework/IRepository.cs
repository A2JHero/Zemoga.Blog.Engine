using System;
using Zemoga.Blog.Engine.Common.Famework;

namespace Zemoga.Blog.Engine.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
