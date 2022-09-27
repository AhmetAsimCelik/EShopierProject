using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL.Messages
{
    public enum ErrorMessageCode
    {
        UsernameAlreadyExists = 101,
        EmailAlreadyExists = 102,
        UserIsNotActive = 151,
        UsernameOrPassWrong = 152,      
        UserIsNotFound = 156,
        ProfileCouldNotUpdated = 157,
        UserCouldNotFind = 158,
        UserCouldNotRemove = 159,
        UserCouldNotInserted = 160,
        NotSamePassword = 161,
        EmptyUserName = 162,
        EmptyPassword = 163,
        WrongUserName = 164,
        WrongPassword = 164


    }
}
