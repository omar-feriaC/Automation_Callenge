using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BaseFramework.Rest;
using BaseFramework.Model;

namespace Challenge.Tests
{
    [TestClass]
    public class User_Tests
    {
        private readonly String baseUrl = ConfigurationManager.AppSettings["baseUrl"];

        [TestMethod]
        public void CreateUser_Positive()
        {
            String endpoint = "/api/v1/QATest/CreateUser/"; 
            User user = new User();
            user.UserName = ""; //We should probably make this random somehow so that this test will always pass. If the user name stays the same, this test will only work once.
            user.Password = "";
            Rest rest = new Rest(baseUrl);
            HTTP_RESPONSE resp = rest.GET(endpoint);
            Assert.AreEqual(HttpStatusCode.OK, resp.StatusCode, $"Expected Status Code {HttpStatusCode.OK}, Received {resp.StatusCode}");
            //We should probably do some more assertions here on the response to check that our GET request was successful.
        }
        public void CreateUser_UserName_Less_Than_8_Negative()
        {
            String endpoint = "/api/v1/QATest/CreateUser/";
            User user = new User();
            user.UserName = "tooshrt";
            user.Password = ConfigurationManager.AppSettings["Password"];
            Rest rest = new Rest(baseUrl);
            HTTP_RESPONSE resp = rest.GET(endpoint);
            //Need some assertions here to check the response.
        }
        public void CreateUser_Password_Less_Than_8_Negative()
        {
            String endpoint = "/api/v1/QATest/CreateUser/";
            User user = new User();
            user.UserName = "tooshrt";
            user.Password = ConfigurationManager.AppSettings["Password"];
            Rest rest = new Rest(baseUrl);
            HTTP_RESPONSE resp = rest.GET(endpoint);
            //Need some assertions here to check the response.
        }

        [TestMethod]
        public void GetUserAuth_Positive()
        {
            String endpoint = "/api/v1/QATest/oauth/token/";
            //Need the rest of this test to be completed.
        }

        [TestMethod]
        public void GetUserAuth_Negative()
        {
            String endpoint = "/api/v1/QATest/oauth/token/";
            //Need the rest of this test to be completed.
        }
    }
    
}
