using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using System.Linq.Expressions;



namespace Core.models
{
    public class BaceSpacification<T> : ISepacifiction<T>
    {
        public Expression<Func<T, bool>> Criteria { get; }



        public BaceSpacification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();


        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }



    }
}