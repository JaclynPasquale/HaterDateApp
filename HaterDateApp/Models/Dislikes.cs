using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Dislikes
    {

        public Dislikes()
        {

        }
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionValue { get; set; }

        public virtual Profiles profile { get; set; }
    }

}