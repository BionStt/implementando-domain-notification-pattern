using DomainNotificationHelperSample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainNotificationSample.Data.Context
{
    public class DnDataContext: DbContext
    {
        public DnDataContext():base("DnCnnStr"){ }

        public DbSet<User> Users { get; set; }
    }
}
