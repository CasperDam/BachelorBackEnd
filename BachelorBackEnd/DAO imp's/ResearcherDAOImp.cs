using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BachelorBackEnd
{
    public class ResearcherDAOImp : IResearcherDAO
    {

        public void AddResearcher()
        {
            using (mydbEntities ent = new mydbEntities())
            {
                test_table table = new test_table();
                table.age = 13;
                table.id = 1;
                table.name = "Test";
                table.smoker = 0;
                table.timestamp = DateTime.Now;
                ent.test_table.Add(table);
                ent.SaveChanges();
            }
        }

        public void DeleteResearcher()
        {
            throw new NotImplementedException();
        }

        public void GetAllResearchers()
        {
            throw new NotImplementedException();
        }

        public void GetResearcher()
        {
            throw new NotImplementedException();
        }

        public void VerifyResearcher()
        {
            throw new NotImplementedException();
        }
    }
}
