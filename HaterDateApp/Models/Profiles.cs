using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDateApp.Model
{
    public class Profiles
    {
        public Profiles()
        {

        }

        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string FirstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        private string LastName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string City { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        public string State { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$"), StringLength(30)]
        [Required]
        [DataType(DataType.EmailAddress)]
        private string Email { get; set; }

        [Required]
        [Range(1, 150)]
        public int Age { get; set; }

        [RegularExpression(@"[MF]")]
        [Required]
        public char Gender { get; set; }

        [RegularExpression(@"[MF]")]
        [Required]
        public char PreferredGender { get; set; }

        [DataType(DataType.Url)]
        public string PictureURL { get; set; }

        public ICollection<Dislikes> dislikes { get; set; }



        public Profiles(string UserName, string FirstName, string LastName, string City, string State, string Email, int Age, char Gender, char PrefGender, string PicURL)
        {
            this.ApplicationUserId = ApplicationUserId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
            this.State = State;
            this.Email = Email;
            this.Age = Age;
            this.Gender = Gender;
            this.PreferredGender = PrefGender;
            this.PictureURL = PicURL;
        }
    }


}
