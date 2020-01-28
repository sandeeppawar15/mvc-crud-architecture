using mvc_crud.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvc_crud.data
{
    public interface IUserRepository
    {
        User Get();        
    }
}
