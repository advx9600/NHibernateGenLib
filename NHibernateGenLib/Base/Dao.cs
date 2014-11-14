using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

using NHibernateGenLib.Domain.ImgFlash;

namespace NHibernateGenLib.Base
{
    public class Dao
    {
        public static void Add(Object obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(obj);
                transaction.Commit();
            }
        }
        public static void Insert(Object obj)
        {
            Add(obj);
        }
        public static void Save(Object obj)
        {
            Add(obj);
        }

        public static void Update(Object obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(obj);
                transaction.Commit();
            }
        }
        /*
         * 这个方法需要把类 TbConfig 相应改掉
         */
        public static void updateConfig(String name, String val)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<TbConfig>().Where(c => c.Name == name).List();
                var entry = list.ElementAt(0);
                entry.Val = val;
                Update(entry);
            }
        }

        public static void Remove(Object obj)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(obj);
                transaction.Commit();
            }
        }

        /*
         * 这个只是个查询Config表的sample
         */
        private static String QueryConfig(String name)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var list = session.QueryOver<TbConfig>().Where(c => c.Name == name).List();
                if (list.ElementAt(0).Val == null) return "";
                return list.ElementAt(0).Val.ToString();
            }
        }
    }
}
