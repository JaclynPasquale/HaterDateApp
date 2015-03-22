﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaterDateApp;
using System.Data.Entity;
using HaterDateApp.Data;




namespace HaterDateApp.Data
{
    public class ProfileRepository : iProfileRepository
    {
        private HaterDateContext _dbContext;


        public ProfileRepository()
        {

            _dbContext = new HaterDateContext();
            _dbContext.Profile.Load();
            _dbContext = new HaterDateContext();
            _dbContext.Question.Load();
        }
        public HaterDateContext Context()
        {
            return _dbContext;
        }
        //public QuestionDBContext Context()
        //{
        //    return dbContextQ;
        //}

        public DbSet<Data.Profiles> GetDbSet()
        {
            return _dbContext.Profile;
        }

        public int GetCount()
        {
            return _dbContext.Profile.Count<Data.Profiles>();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Delete(Data.Profiles P)
        {
            throw new NotImplementedException();
        }

        public void Add(Data.Profiles profile)
        {
            /* Solution 1:
             * Find if the event is in the DB;
             * 
             * var query = from Event in _dbContext.Events
             * where Event.Date == E.Date and Event.Name == E.Name
             * select Event;
             * 
             * if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Solution 2:
             * 
             * Migration on the table, adding another field. Like, a hash (Name+Date).
             * 
             * var gimme_hash = Sha1.Create(E.Name+E.Date);
             * gimme_hash.Hash;
             * _dbContext.Event.Find(e => e.Hash == E.hash);
             * _dbContext.Event.SingleOrDefault(e => e.Hash == E.hash);
             * OR use LINQ
             * 
             *if (query.ToList().Count > 0) {
             *  throw new ArgumentException();
             * }
             * 
             * Thinking forward, we want the UI window handling the Event addition to tell the user they
             * can't add duplicates
             * */
            _dbContext.Profile.Add(profile);
            _dbContext.SaveChanges();
        }

        public Data.Profiles GetById(string id)
        {
            var query = from Profile in _dbContext.Profile
                        where Profile.ApplicationUserId == id
                        select Profile;
            return query.First<Data.Profiles>();

        }
        public void Clear()
        {
            var a = this.GetProfiles();
            _dbContext.Profile.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Profiles> GetProfilebyUserId(string userId)
        {
            var ProfilebyId = from p in _dbContext.Profile
                             where p.ApplicationUserId == userId
                             select p;
            return ProfilebyId.ToList();
        }

        public IQueryable<Data.Profiles> GetProfiles()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            //var qu = from Profiles in _dbContext.Profiles select Profiles;
            //return qu.ToList<Model.Profile>();
            return _dbContext.Profile;
        }

        public IQueryable<Data.Profiles> SearchFor(System.Linq.Expressions.Expression<Func<Data.Profiles, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }




    }
}