using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToMany.Services
{
    public interface IRepo <K, T>
    {
        bool Create(T t);
        bool Delete(K k);
        T Get(K k);
        bool Update(K k, T t);
        ICollection<T> GetAll();
    }
}
