using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateGenLib.Domain.ImgFlash
{
    public class TbImage
    {
        public virtual long Id { get; set; }
        public virtual String Board { get; set; }
        public virtual String GitBranch { get; set; }
        public virtual String Uboot { get; set; }
        public virtual String UbootPath { get; set; }
        public virtual String Kernel { get; set; }
        public virtual String KernelPath { get; set; }
        public virtual String System { get; set; }
        public virtual String SystemPath { get; set; }
    }

    public class TbConfig
    {
        public virtual long Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String Val { get; set; }
    }
}
