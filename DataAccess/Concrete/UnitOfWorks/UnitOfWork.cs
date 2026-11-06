using Core.DataAccess.Repositories.Abstract;
using Core.DataAccess.UnitOfWorks;
using DataAccess.Concrete.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IUserDal _userDal;
        private readonly IAppointmentDal _appointmentDal;

        public UnitOfWork(AppDbContext context, IUserDal userDal, IAppointmentDal appointmentDal)
        {
            _context = context;
            _userDal = userDal;
            _appointmentDal = appointmentDal;
        }

        public IUserDal Users => _userDal;

        public IAppointmentDal Appointment => _appointmentDal;

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
