using NUnit.Framework;
using System.IO;
using System.Net.Http;

namespace FreshBooks.Api.Tests
{
    public abstract class BaseTests
    {
        protected FreshBooksClient client;

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            string[] auth = null;
                if(File.Exists("auth.txt"))
                    auth = File.ReadAllLines("auth.txt");
            
                if(auth == null || auth.Length < 2)
            {
                throw new System.Exception("You are either missing an auth.txt file, or it is not formatted correctly. Please create an auth.txt file in the test folder with the first line equal to the API URL, and the second line equal to your authentication token.");
            }

            client = new HttpClient().FreshBooks(auth[0], auth[1]);
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            client = null;
        }
    }
}