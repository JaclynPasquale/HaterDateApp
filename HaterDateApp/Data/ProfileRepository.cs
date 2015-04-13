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
            _dbContext = new HaterDateContext();
            _dbContext.Dislike.Load();
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
            try
            {
                _dbContext.Dislike.Add(dislike);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public void Add(Data.Profiles profile)
        {
            try
            {
                _dbContext.Profile.Add(profile);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
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


        public IQueryable<Data.Profiles> GetCompatibleProfiles(Profiles match)
        {
            return _dbContext.Profile.Where(profile => profile.PreferredGender == match.Gender && profile.Gender == match.PreferredGender);
        }

        public IEnumerable<Profiles> FindPotentialMatches(Profiles matchee)
        {
            SortedDictionary<int, List<Profiles>> dictionary =
            new SortedDictionary<int, List<Profiles>>();

            IList<Profiles> compatibleProfiles = GetCompatibleProfiles(matchee).ToList();

            foreach (Profiles potentialMatch in compatibleProfiles)
            {
                var sql = @"SELECT SUM(CASE WHEN mine.QuestionValue = theirs.QuestionValue THEN 1 ELSE 0 END) * 100.0 / COUNT(*) AS match
  FROM [HaterDateApp.HaterDateContext].[dbo].[Dislikes] as mine
  JOIN [HaterDateApp.HaterDateContext].[dbo].[Dislikes] as theirs
  on mine.QuestionId = theirs.QuestionId
  WHERE mine.ProfileId = '{0}'
  AND theirs.ProfileId = '{1}'";
                int MatchPercentage = _dbContext.Database.ExecuteSqlCommand(sql, matchee.Id, potentialMatch.Id);

                List<Profiles> list;

                if (!dictionary.TryGetValue(MatchPercentage, out list))
                {
                    list = new List<Profiles>();
                    dictionary.Add(MatchPercentage, list);
                }

                list.Add(potentialMatch);
            }

            return dictionary.Values.SelectMany(x => x).ToList();
        }


        public IQueryable<Data.Profiles> GetProfiles()
        {
            return _dbContext.Profile;
        }

        //public IQueryable<Data.Dislikes> GetDislikeId()
        //{
        //    var QuestionId = from a in DbContext
        //    if (QuestionId == null){

        //    }
        //}

        public IQueryable<Data.Dislikes> GetDislikes()
        {
            return _dbContext.Dislike;
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