using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDatingApp.Model
{
    public class Questions
    {
        public Questions()
        {

        }
        public int Id { get; set; }
        public string QuestionName { get; set; }
    }

}