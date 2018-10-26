using JOBSBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOBSBD.Data.Interfaces
{
   public interface IPersonalDetailRepository:IRepository<PersonalDetail>
    {
        IEnumerable<PersonalDetail> GetPersonalDetails();
        PersonalDetail GetPersonalDetail(int id);
    }
}
