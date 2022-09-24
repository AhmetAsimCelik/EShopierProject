using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshopier.DAL
{
    public interface IDataAccess<T>
    {
        int Update(T obj);
    }
}
