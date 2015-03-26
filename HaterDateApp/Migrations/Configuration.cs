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
                    QuestionName = "Radio djs"
                },
                new Questions
                {
                    QuestionName = "Cats"
                },
                
                new Questions
                {
                    QuestionName = "The police"
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
                    QuestionName = "Cryptic Facebook statuses"
                },
                new Questions
                {
                    QuestionName = "Spiders"
                },
                new Questions
                {
                    QuestionName = "Bicycling"
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
                    QuestionName = "Yoga"
                },
                new Questions
                {
                    QuestionName = "The tv show \"Friends\""
                },
                 new Questions
                {
                    QuestionName = "Walmart"
                },
                new Questions
                {
                    QuestionName = "People that bring their desktop computers to a coffee shop"
                },
                new Questions
                {
                    QuestionName = "Vegans"
                },
                new Questions
                {
                    QuestionName = "Skirillex"
                },
                new Questions
                {
                    QuestionName = "Dave Matthews Band"
                },
                new Questions
                {
                    QuestionName = "Patcholi oil"
                },
                new Questions
                {
                    QuestionName = "Jam bands"
                },
                new Questions
                {
                    QuestionName = "Video games"
                },
                new Questions
                {
                    QuestionName = "People that have a strong opinion on the pronouncation of \"gyro\""
                },
                new Questions
                {
                    QuestionName = "Sweet Tea"
                },
                new Questions
                {
                    QuestionName = "Fast Food"
                },
                new Questions
                {
                    QuestionName = "Crossfit"
                },
                new Questions
                {
                    QuestionName = "Trucks"
                },
                new Questions
                {
                    QuestionName = "Rom coms"
                },
                new Questions
                {
                    QuestionName = "using the wrong form of \"your/your're\""
                },
                new Questions
                {
                    QuestionName = "Men's sandals (mandles)"
                },
                new Questions
                {
                    QuestionName = "Pronouncing the \"h\" in why and wheat"
                },
                new Questions
                {
                    QuestionName = "People who think dairy is paleo"
                },
                new Questions
                {
                    QuestionName = "Traveling by plane"
                }

             );
        }

    }
}

