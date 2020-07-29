using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSvc.Modal
{
   
    
    public class UserDataAccess:IUserData
    {
        private readonly UserDBContext _db;
        public UserDataAccess(UserDBContext db)
        {
            this._db = db;
        }

        public Dictionary<string,string> GetById(int id)
        {
            UserDto user = _db.users.FirstOrDefault(x => x.id == id);
            Dictionary<string, string> output = new Dictionary<string, string>();
            output.Add("name", user.name);
            output.Add("age", user.age);
            output.Add("email", user.email);
            return output;
        }
    }
}
