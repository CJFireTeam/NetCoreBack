using LinqKit;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Server.IIS.Core;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace Netcore.Abstraction.PartialOverload
{
    public static class Convert
    {
        public static async Task<List<T>> ToList<T>(this IQueryable<object> query)
        {
            var queryList = await query.AsExpandable().ToListAsync();

            List<T> list = queryList.Adapt<List<T>>();

            return list;
        }

        public static T SingleOrDefault<T>(this object item)
        {
            T result = item.Adapt<T>();

            return result;
        }

        public static T ConverPrueba<T>(this object item)
        {
            T result = item.Adapt<T>();

            return result;
        }
    }
}