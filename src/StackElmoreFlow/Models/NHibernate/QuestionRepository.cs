using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using StackElmoreFlow.Models.NHibernate;

namespace StackElmoreFlow.Models
{
    public class QuestionRepository
    {
        public IList<Question> GetQuestions()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Question>().ToList();
            }
        }

        public void Save(Question objQuestion)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(objQuestion);

                    transaction.Commit();
                }

            }
        }
    }
}