using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp_Application.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
