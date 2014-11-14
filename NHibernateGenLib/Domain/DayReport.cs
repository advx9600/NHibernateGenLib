using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateGenLib.Domain
{
    public class DayReport
    {
        public virtual long Id { get; set; }
        public virtual String Title { get; set; }
        public virtual String Detail { get; set; }
        public virtual DateTime UpTime { get; set; }
        public virtual int Status { get; set; }
        public virtual Boolean IsPlan { get; set; }
    }

    public class ReportConfig
    {
        public virtual long Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String Val { get; set; }
    }
}