using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;

namespace PMIS.DAL
{
    public class SessonManager
    {
        private ISessionFactory _sessionFactory;

        public SessonManager()
        {
            _sessionFactory = GetSessionFactory();
        }

        private ISessionFactory GetSessionFactory()
        {
            return (new Configuration()).Configure().BuildSessionFactory();
        }

        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
