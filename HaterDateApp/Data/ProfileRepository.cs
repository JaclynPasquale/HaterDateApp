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

        //public DbSet<Data.Questions> GetDbSet()
        //{
        //    return _dbContext.Question;
        //}

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
        public void AddDislike(Data.Dislikes dislike)
        {
            _dbContext.Dislike.Add(dislike);
            _dbContext.SaveChanges();
        }

        public void Add(Data.Profiles profile)
        {
            
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

        public IQueryable<Profiles> GetProfileByState(string state)
        {
            var profile = from a in _dbContext.Profile
                         select a;
            
            profile = profile.Where(s => s.State.Contains(state));

           return profile;
        }

        public IQueryable<Data.Profiles> SearchFor(System.Linq.Expressions.Expression<Func<Data.Profiles, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }


        public IQueryable<Data.Questions> GetQuestions()
        {
            return _dbContext.Question;
        }
    }
}