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



        // GET: api/Profile
        //[Route("api/Profile")]
        //public IEnumerable<string> Get()
        //{
        //    //string userId = User.Identity.GetUserId();
        //    //if (userId != null)
        //    //{
        //    //    return .GetPlacesbyUserId(userId);
        //    //}
        //    //return _db.GetAllPlaces();


        //}

        // GET: api/Profile/5

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
        

        [Route("api/Profile")]
        public HttpResponseMessage Post(Profiles profile)
        {
            profile.ApplicationUserId = User.Identity.GetUserId();
            _repo.Add(profile);
            return Request.CreateResponse(HttpStatusCode.Created, profile);
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
