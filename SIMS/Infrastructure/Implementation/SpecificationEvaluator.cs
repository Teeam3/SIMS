﻿using Core.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class SpecificationEvaluator<TEntity> where TEntity : class
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
        {
            var query = inputQuery;
            if(specification.Criteria != null) 
            {
                query = query.Where(specification.Criteria);
            }
            if(specification.OrderBy != null) 
            {
                query = query.OrderBy(specification.OrderBy);
            }
            if(specification.OrderByDescending != null)
            {
                query = query.OrderByDescending(specification.OrderByDescending);
            }
            query = specification.Includes.Aggregate(query,(current, include) => current.Include(include));
            return query;
        }
    }
}
