using Core.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        public IUserDal Users { get;}

        public IAppointmentDal Appointment { get; }

        public Task<int> SaveChangesAsync();
    }
}
