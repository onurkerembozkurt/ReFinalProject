using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//core layer does not take reference from other layers
//if would do that doesnt make global using for core 
//because that makes to core relative which reference 
//get from layer

namespace Core.DataAccess
{
    //Generic Constraint
    //class : that means can be reference type
    //so i want the user can not write any reference type
    //and the object which IEntity is main relative for our classes
    //thats why we write that
    //But writing IEntity makes the rules
    //we are able to write IEntity or the object who implements IEntity
    //cause of that we dont want to write IEntity
    //so for that we are suppose to write new() end of line
    //and that makes we just can add an object that can be concrete object
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
