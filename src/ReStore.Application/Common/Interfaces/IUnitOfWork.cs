using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        Task CommitChangesAsync();
    }
}