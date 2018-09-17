using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BachelorBackEnd;

namespace BachelorBackEnd
{
    public class ParticipantDAOImp : IParticipantDAO
    {
        public void AddParticipant()
        {

            using (mydbEntities ent = new mydbEntities())
            {
                
                
                ent.SaveChanges();
                
            }
        }

        public void DeleteParticipant()
        {
            throw new NotImplementedException();
        }

        public void GetAllPArticipants()
        {
            throw new NotImplementedException();
        }

        public void GetParticipant()
        {
            throw new NotImplementedException();
        }

        public void VerifyParticipant()
        {
            throw new NotImplementedException();
        }
    }
}
