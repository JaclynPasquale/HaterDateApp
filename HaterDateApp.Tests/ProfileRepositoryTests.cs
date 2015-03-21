﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HaterDateApp;
using HaterDateApp.Data;
using System.Data.Entity;

namespace HaterDatingAppTests
{
    [TestClass]
    public class ProfileRepositoryTests
    {
        private static ProfileRepository repo;

        [ClassInitialize]
        public static void SetUp(TestContext _context)
        {
            repo = new ProfileRepository();
            repo.Clear();
        }
        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }
        [TestCleanup]
        public void ClearDatabase()
        {
            repo.Clear();
        }
        [TestMethod]
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new Profiles("Jane", "Jane", "Doe", "New York", "New York", "janedoe@gmail.com", 25, 'F', 'M', "https://s-media-cache-ak0.pinimg.com/originals/cb/80/cc/cb80cc8aed218910fc3e42163f891798.jpg"));
            Assert.AreEqual(1, repo.GetCount());
        }
        [TestMethod]
        public void TestAllMethods()
        {
            repo.Add(new Profiles("Jim", "Jim", "Jones", "Los Angeles", "California", "joejones@gmail.com", 28, 'M', 'F', "https://s-media-cache-ak0.pinimg.com/originals/cb/80/cc/cb80cc8aed218910fc3e42163f891798.jpg"));
            Assert.AreEqual(1, repo.GetCount());
            repo.Clear();


        }
    }
}
