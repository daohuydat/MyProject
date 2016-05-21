using MyProjectDBContext.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectDBContext.DataAccess
{
    public class AdvisorAccess
    {
        private ProjectDbContext db;
        public AdvisorAccess()
        {
            db = new ProjectDbContext();
        }
        public List<AdvisorDomain> GetAllAdvisorDomains()
        {
            return db.AdvisorDomains.ToList<AdvisorDomain>();
        }

        public List<Advisor> GetAdvisorsByDomain(AdvisorDomain domain)
        {
            return domain.Advisors.ToList<Advisor>();
        }

        public AdvisorDomain GetAdvisorDomain(int? id)
        {
            return db.AdvisorDomains.Find(id);
        
        }
           
    }
}
