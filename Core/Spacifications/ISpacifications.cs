using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Spacifications
{   
    public interface ISpacifications<T>
    {
          Expression<Func<T,bool>> Criteria {get;}
          List<Expression<Func<T,object>>> Includes{get;}
    }
}