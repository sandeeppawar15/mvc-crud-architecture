using mvc_crud.codefirst;
using mvc_crud.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_crud.data
{
    public class UserRepository : IUserRepository
    {


        /*
         Egar Loading
         Lazy Loading
        */

        /// <summary>
        /// Get all (implemenet pagination)
        /// </summary>
        /// <returns></returns>
        public User Get()
        {
            var users = new User();
            using (var db = new mvccrudContext())
            {
                users = db.Users.FirstOrDefault();
            }

            return users;
        }


        public User GetById(int id)
        {
            var users = new User();

            //for unmanaged resouse we use using : e.g - File Operation, external clod service
            using (var db = new mvccrudContext())
            {
                users = db.Users.FirstOrDefault();
            }

            return users;
        }


        // post call to save record
        // patch
        // put
        // delete


    }
}
