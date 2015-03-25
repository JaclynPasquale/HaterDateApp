using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDateApp.Data
{
    public class Profiles
    {
        public Profiles()
        {

        }

        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string LastName { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string City { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string State { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Range(1, 150)]
        public int Age { get; set; }

        //[RegularExpression(@"[MF]")]
        [Required]
        public string Gender { get; set; }

        //[RegularExpression(@"[MF]")]
        [Required]
        public string PreferredGender { get; set; }

        [DataType(DataType.Url)]
        public string PictureURL { get; set; }

        public string AboutBlurb { get; set; }

        public ICollection<Dislikes> dislikes { get; set; }



        public Profiles(string UserName, string FirstName, string LastName, string City, string State, string Email, int Age, string Gender, string PrefGender, string PicURL, string AboutBlurb)
        {
            this.ApplicationUserId = UserName;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
            this.State = State;
            this.Email = Email;
            this.Age = Age;
            this.Gender = Gender;
            this.PreferredGender = PrefGender;
            this.PictureURL = PicURL;
            this.AboutBlurb = AboutBlurb;
        }
    

      
}


}
