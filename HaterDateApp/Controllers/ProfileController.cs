using HaterDateApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;


namespace HaterDateApp.Controllers
{
    public class ProfileController : ApiController
    {
        ProfileRepository _repo = new ProfileRepository();

        // GET: api/Profile/
        [Route("api/Profile")]
        public IEnumerable<Profiles> Get()
        {
            string userId = User.Identity.GetUserId();
            if (userId != null)
            {
                return _repo.GetProfilebyUserId(userId);
            }
            return _repo.GetProfiles();
        }

        [Route("api/Profile/{id}")]
        public IEnumerable<Profiles> Get(int id)
        {
            var profile = _repo.GetProfiles();

            if (id != 0)
            {
                profile = profile.Where(i => i.Id == id);
            }

            return profile;
        }

        [Route("api/Profile")]
        public IEnumerable<Profiles> Get(string state)
        {
            return _repo.GetProfileByState(state);
        }
        

        [Route("api/profile")]
        public HttpResponseMessage Post(Profiles profile)
        {
            profile.ApplicationUserId = User.Identity.GetUserId();
            _repo.Add(profile);
            return Request.CreateResponse(HttpStatusCode.Created, profile);
        }


        [Route("api/dislike")]
        public HttpResponseMessage Post(Dislikes dislike)
        {
            dislike.ProfileId = User.Identity.GetUserName();
            _repo.AddDislike(dislike);
            return Request.CreateResponse(HttpStatusCode.Created, dislike);
        }

        [Route("api/questions")]
        public IEnumerable<Questions> GetQuestions()
        {
            return _repo.GetQuestions()
                .Take(20)
                .ToList();
               
                    
        }
       
        // PUT: api/Profile/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Profile/5
        public void Delete(int id)
        {
        }
    }
}
