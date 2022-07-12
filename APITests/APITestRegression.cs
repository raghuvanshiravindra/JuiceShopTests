using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JuiceShopAPIDemo;
using RestSharp;

namespace APITests
{
    [TestClass]
    public class APITestRegression
    {
        [TestMethod]
        public void VerifyProductSearch()
        {
            var juiceDemo = new JuiceShopDemo();
            var response = juiceDemo.GetJuices();
            Assert.AreEqual("success", response.Status);
            Assert.AreEqual("Apple Juice (1000ml)", response.Data[0].Name);
            Assert.AreEqual("The all-time classic.", response.Data[0].Description);
            Assert.AreEqual("Apple Pomace", response.Data[1].Name);
            Assert.AreEqual("Finest pressings of apples. Allergy disclaimer: Might contain traces of worms. Can be <a href=\"/#recycle\">sent back to us</a> for recycling.", response.Data[1].Description);
        }
        [TestMethod]
        public void PostNewComment()
         {
               string payload = @"{
                                   ""UserId"":""461"",
                                   ""captchaId"": ""583"",
                                   ""captcha"": ""23"",
                                   ""comment"": ""Wonderful 2"",
                                   ""rating"": ""3""
                                   }";
               var comment = new APIHelper<LeaveCustomerFeedbackDTO>();
               var url = comment.SetUrl("api/");
               var request = comment.CreatePostRequest(payload);
               var response = comment.GetResponse(url, request);
               LeaveCustomerFeedbackDTO content = comment.GetContent<LeaveCustomerFeedbackDTO>(response);
        Console.WriteLine(response.Content);
               Assert.AreEqual("Wonderful 2", content.comment);
               Assert.AreEqual(3, content.rating);
        }        
    }
}
