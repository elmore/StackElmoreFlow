using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace StackElmoreFlow.Models.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var NHibernateConfig = new Configuration();

                    NHibernateConfig.Configure(HttpContext.Current.Server.MapPath(@"Models\NHibernate\hibernate.cfg.xml"));

                    NHibernateConfig.AddDirectory(new System.IO.DirectoryInfo(HttpContext.Current.Server.MapPath(@"Models\NHibernate\Mappings")));

                    _sessionFactory = NHibernateConfig.BuildSessionFactory();
                }

                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}