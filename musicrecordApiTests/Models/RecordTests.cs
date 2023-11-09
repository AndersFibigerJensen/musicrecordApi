using Microsoft.AspNetCore.Authentication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using musicrecordApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicrecordApi.Models.Tests
{
    [TestClass()]
    public class RecordTests
    {
        [TestMethod()]
        public void ValidateTitleTest()
        {
            Record record1 = new Record { Artist = "ACDC", Title = "Thunder", Duration = 200, PublicationYear = 1980, Downloads = 123 };
            Record record2 = new Record { Artist = "ACDC", Title = "", Duration = 200, PublicationYear = 1980, Downloads = 123 };
            Record record3 = new Record { Artist = "ACDC", Title = null, Duration = 200, PublicationYear = 1980, Downloads = 123 };
            Assert.ThrowsException<ArgumentNullException>(() => record2.ValidateTitle());

        }

        [TestMethod()]
        public void ArtistValidateTest()
        {
            Assert.Fail();
        }
    }
}