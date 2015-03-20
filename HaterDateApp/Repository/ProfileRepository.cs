﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaterDatingApp;
using System.Data.Entity;
using HaterDatingApp.Model;
using HaterDateApp;



namespace HaterDatingApp.Repository
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

        public DbSet<Model.Profiles> GetDbSet()
        {
            return _dbContext.Profile;
        }

        public int GetCount()
        {
            return _dbContext.Profile.Count<Model.Profiles>();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Profiles P)
        {
            throw new NotImplementedException();
        }

        public void Add(Model.Profiles P)
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
            _dbContext.Profile.Add(P);
            _dbContext.SaveChanges();
        }

        public Model.Profiles GetById(string id)
        {
            var query = from Profile in _dbContext.Profile
                        where Profile.ApplicationUserId == id
                        select Profile;
            return query.First<Model.Profiles>();

        }
        public void Clear()
        {
            var a = this.GetAll();
            _dbContext.Profile.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IQueryable<Model.Profiles> GetAll()
        {
            // First look to see if the stash is populated. If so
            // then return that stash otherwise do what's below.
            //var qu = from Profiles in _dbContext.Profiles select Profiles;
            //return qu.ToList<Model.Profile>();
            return _dbContext.Profile;
        }

        public IQueryable<Model.Profiles> SearchFor(System.Linq.Expressions.Expression<Func<Model.Profiles, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }




    }
}