using HaterDateApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaterDateApp.Data
{
    interface iProfileRepository
    {
        int GetCount(); //
        void Add(Profiles E); //
        void Delete(Profiles E); //
        void Clear(); //
        IQueryable<Profiles> GetProfiles(); //
        Profiles GetById(string id); //

        IQueryable<Profiles> SearchFor(Expression<Func<Profiles, bool>> predicate);


        //IEnumerable<string> GetProfiles();
    }
}
