using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Repositories.Abstract
{
    public interface IAppointmentDal:IGenericRepository<Appointment>
    {
        Task<IEnumerable<Appointment>> GetAppointmentsByUserIdAsync(int userId);
        Task<IEnumerable<Appointment>> GetAppointmentsByDateRangeAsync(int userId, DateTime start, DateTime end);
    }
}
