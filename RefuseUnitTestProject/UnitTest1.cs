using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Net.Http;

namespace RefuseUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
       //run tests against localhost
        string baseAddress = "http://localhost:45055/";
        String guid = Guid.NewGuid().ToString();
        String guid2 = Guid.NewGuid().ToString();
        String guid3 = Guid.NewGuid().ToString();
        string baseAddress2 = "http://pbrefusecollect.azurewebsites.net/";
        string baseAddress3 = "http://pbrefusecollect.azurewebsites.net/api/values/";

        [TestMethod]
        public void TestMethodNotNullGetPartitonkeyRowkey()
        {
            HttpClient client6 = new HttpClient();
            //http://localhost:45055/swagger
            var result = client6.GetAsync(baseAddress + "api/values/D8/1qw11123234529064ef").Result;

            client6.Dispose();

            //Install-Package Microsoft.AspNet.WebApi.Core -version 5.2.3.0
            //check to see what was returned was not null
            //if your testing against local host make sure to
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestMethodNotNullGetPartitonkey()
        {
            HttpClient client61 = new HttpClient();
            //http://localhost:45055/swagger
            var result1 = client61.GetAsync(baseAddress + "api/values/D8").Result;

            client61.Dispose();

            //Install-Package Microsoft.AspNet.WebApi.Core -version 5.2.3.0
            //check to see what was returned was not null
            //if your testing against local host make sure to
            Assert.IsNotNull(result1);
        }
        [TestMethod]
        public void TestMethodAggCountByArea()
        {
            HttpClient client7 = new HttpClient();
            //     call to test aggregate query returns values of D8 refuse not collected.

            var response2x = client7.GetAsync(baseAddress + "api/values/D8/Agg/CountByIdNotCollect").Result;
            
            client7.Dispose();
            //check that the value return is not null
            Assert.IsNotNull(response2x);
        }

        [TestMethod]
        public void TestMethodAggCountByArea2()
        {
            HttpClient client71 = new HttpClient();
            //     call to test aggregate query returns values of D8 refuse not collected.

            var response2x = client71.GetAsync(baseAddress + "api/values/D8/Agg/CountByIdNotCollect").Result;
            var result=response2x.Content.ReadAsStringAsync().Result;
            client71.Dispose();
            //check that the value return is not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethodAggCountByArea3()
        {
            HttpClient client71 = new HttpClient();
            //     call to test aggregate query returns values of D8 refuse not collected.

            var response2x = client71.GetAsync(baseAddress + "api/values/D8/Agg/CountByIdCollect").Result;
            var result = response2x.Content.ReadAsStringAsync().Result;
            client71.Dispose();
            //check that the value return is not null
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethodAggCountByArea4()
        {
            HttpClient client71 = new HttpClient();
            //     call to test aggregate query returns values of D8 refuse not collected.

            var response2x = client71.GetAsync(baseAddress + "api/values/D8/Agg/CountById").Result;
            var result = response2x.Content.ReadAsStringAsync().Result;
            client71.Dispose();
            //check that the value return is not null
            Assert.IsNotNull(result);
        }
    }
}
