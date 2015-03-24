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
            context.Question.AddOrUpdate(i => i.QuestionName,

                new Questions
                {
                    QuestionName = "Children"
                },
                new Questions
                {
                    QuestionName = "Snakes"
                },
                new Questions
                {
                    QuestionName = "The word \"Moist\""
                },
                new Questions
                {
                    QuestionName = "Handlebar Mustaches"
                },
                new Questions
                {
                    QuestionName = "People that say \"LOL\" unironically"
                },
                new Questions
                {
                    QuestionName = "The great outdoors"
                },
                new Questions
                {
                    QuestionName = "Kayne West"
                },
                new Questions
                {
                    QuestionName = "Soup that's too hot"
                },
                new Questions
                {
                    QuestionName = "Motorcycles"
                },
                new Questions
                {
                    QuestionName = "Non-crispy bacon"
                },
                new Questions
                {
                    QuestionName = "People that buy one-ply toilet paper"
                },
                new Questions
                {
                    QuestionName = "E-cigs"
                },
                new Questions
                {
                    QuestionName = "Apple products"
                },
                new Questions
                {
                    QuestionName = "Djs on the radio"
                },
                new Questions
                {
                    QuestionName = "Cats"
                },
                new Questions
                {
                    QuestionName = "Tailgating"
                },
                new Questions
                {
                    QuestionName = "The Police"
                },
                new Questions
                {
                    QuestionName = "Nickleback"
                },
                new Questions
                {
                    QuestionName = "Small Dogs"
                },
                new Questions
                {
                    QuestionName = "Your neighbors cooking indian food"
                },
                new Questions
                {
                    QuestionName = "Cryptic Facebook status'"
                },
                new Questions
                {
                    QuestionName = "Spiders"
                },
                new Questions
                {
                    QuestionName = "Biking"
                },
                
                new Questions
                {
                    QuestionName = "Crappy horror movies"
                },
                 new Questions
                {
                    QuestionName = "NASCAR"
                },
                new Questions
                {
                    QuestionName = "The tv show \"Friends\""
                },
                 new Questions
                {
                    QuestionName = "Walmart"
                }
             );
        }

    }
}

