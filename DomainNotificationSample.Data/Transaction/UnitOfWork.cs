using DomainNotificationSample.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotificationSample.Data.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private DnDataContext _context;

        public UnitOfWork(DnDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
