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
        public virtual String UBoot { get; set; }
        public virtual String UBootFileName { get; set; }
        public virtual String Kernel { get; set; }
        public virtual String KernelFileName { get; set; }
        public virtual String Ramdisk { get; set; }
        public virtual String RamdiskFileName { get; set; }
        public virtual String Userdata { get; set; }
        public virtual String UserdataFileName { get; set; }
        public virtual String System { get; set; }
        public virtual String SystemFileName { get; set; }
        public virtual String SavePath { get; set; }
        public virtual String XmlPath { get; set; }
    }

    public class TbConfig
    {
        public virtual long Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String Val { get; set; }
    }
}
