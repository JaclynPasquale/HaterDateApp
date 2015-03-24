using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDateApp.Data
{
    public class Dislikes
    {

        public Dislikes()
        {

        }
        public int Id { get; set; }
        public string ProfileId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionValue { get; set; }

        public virtual Profiles profile { get; set; }
    }

}