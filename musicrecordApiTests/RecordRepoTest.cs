using Microsoft.VisualStudio.TestTools.UnitTesting;
using musicrecordApi.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicrecordApiTests
{
    public class RecordRepoTest
    {
        [TestClass()]
        public class RecordTests
        {
            [TestMethod()]
            public void getRepo()
            {
                RecordRepository repo = new RecordRepository();
                Assert.AreEqual(repo.GetAllRecords(title: "H").Count(),1);
                Assert.AreEqual(repo.GetAllRecords(artist:"M").Count(),1);
                Assert.AreEqual(repo.GetAllRecords(title: "åååå").Count(), 0);
                Assert.AreEqual(repo.GetAllRecords(artist: "åååå").Count(), 0);


            }
        }
    }
}
