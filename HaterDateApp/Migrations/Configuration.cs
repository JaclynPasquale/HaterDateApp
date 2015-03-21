namespace HaterDateApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HaterDateApp.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<HaterDateApp.HaterDateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HaterDateApp.HaterDateContext context)
        {
            context.Profile.AddOrUpdate(i => i.ApplicationUserId,
            
                new Profiles
                {
                    ApplicationUserId = "JaneD0e",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "jane@gmail.com",
                    City = "New York City",
                    State = "New York",
                    Gender = 'F',
                    Age = 27,
                    PreferredGender = 'M',
                    PictureURL = "http://animalia-life.com/data_images/cat/cat1.jpg",
                    AboutBlurb = "about me",
                    
               },
               new Profiles
               {
                   ApplicationUserId = "JonD0e",
                   FirstName = "Jon",
                   LastName = "Doe",
                   Email = "jon@gmail.com",
                   City = "San Francisco",
                   State = "California",
                   Gender = 'M',
                   Age = 27,
                   PreferredGender = 'F',
                   PictureURL = "http://www.cats.org.uk/uploads/images/pages/photo_latest14.jpg",
                   AboutBlurb = "about me",

               },
               new Profiles
               {
                   ApplicationUserId = "Mittens",
                   FirstName = "Leon",
                   LastName = "Peck",
                   Email = "leon@gmail.com",
                   City = "Nashville",
                   State = "Tennessee",
                   Gender = 'M',
                   Age = 29,
                   PreferredGender = 'F',
                   PictureURL = "http://www.cats.org.uk/uploads/images/pages/photo_latest14.jpg",
                   AboutBlurb = "about me",

               },
               new Profiles
               {
                   ApplicationUserId = "BlaisingGrattles",
                   FirstName = "Blaise",
                   LastName = "Grattles",
                   Email = "blaise@gmail.com",
                   City = "Nashville",
                   State = "Tennessee",
                   Gender = 'M',
                   Age = 26,
                   PreferredGender = 'F',
                   PictureURL = "http://breadedcat.com/wp-content/uploads/2012/02/cat-breading-tutorial-004.jpg",
                   AboutBlurb = "about me",

               },
               new Profiles
               {
                   ApplicationUserId = "Sonda",
                   FirstName = "Sonda",
                   LastName = "Sengupta",
                   Email = "sonda@gmail.com",
                   City = "Nashville",
                   State = "Tennessee",
                   Gender = 'F',
                   Age = 26,
                   PreferredGender = 'M',
                   PictureURL = "http://coins4.cat/wp-content/uploads/2014/03/FB-header.jpg",
                   AboutBlurb = "about me",

               },
               new Profiles
               {
                   ApplicationUserId = "Jayquellin",
                   FirstName = "Jackie",
                   LastName = "Pquat",
                   Email = "jayquellin@gmail.com",
                   City = "Nashville",
                   State = "Tennessee",
                   Gender = 'F',
                   Age = 26,
                   PreferredGender = 'M',
                   PictureURL = "http://s3.amazonaws.com/assets.prod.vetstreet.com/06/36bbf0e6f211e19ff5005056ad4734/file/AP-BAKLFT_Sphynx_Cat.jpg",
                   AboutBlurb = "about me",

               }

           );
        }

    }
}

