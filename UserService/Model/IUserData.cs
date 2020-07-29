using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSvc.Modal
{
   public interface IUserData
    {
        Dictionary<string, string> GetById(int id);
    }
}
