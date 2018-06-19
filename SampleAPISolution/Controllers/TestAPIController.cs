using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleAPISolution.Models;

namespace SampleAPISolution.Controllers
{
    public class TestAPIController : ApiController
    {
        // GET: api/Test
        public static List<TestData> testdatalist
             = new List<TestData>()
             {
                new TestData()
                {
                     Id= "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                     ApplicationId= 197104,
                     Type= "Debit",
                     Summary= "Payment",
                     Amount= 58.26,
                     PostingDate= Convert.ToDateTime("2016-07-01T00:00:00"),
                    IsCleared= true,
                    ClearedDate= Convert.ToDateTime("2016-07-02T00:00:00")
                },
               new TestData()
               {
                    Id= "d2032222-47a6-4048-9894-11ab8ebb9f69",
                    ApplicationId= 197104,
                    Type= "Debit",
                    Summary= "Payment",
                    Amount= 50.09,
                    PostingDate= Convert.ToDateTime("2016-08-01T00:00:00"),
                    IsCleared= true,
                    ClearedDate= Convert.ToDateTime("2016-08-02T00:00:00")
                }

                };

        public List<TestData> Get()
        {
            return testdatalist;
        }

        // GET: api/Test/5
        public TestData Get(string id)
        {
            TestData data = testdatalist.Where(i => i.Id == id).SingleOrDefault();
            return data ;
        }

        // POST: api/Test
        public List<TestData> Post(TestData input)
        {
            TestData data = new TestData()
            {
                Id = input.Id,
                ApplicationId = input.ApplicationId,
                Type = input.Type,
                Summary = input.Summary,
                Amount = input.Amount,
                PostingDate = input.PostingDate,
                IsCleared = input.IsCleared,
                ClearedDate = input.ClearedDate


            };
            testdatalist.Add(data);
            return testdatalist;

        }

        // PUT: api/Test/5
        public TestData Put(string id, TestData input)
        {
            TestData data = testdatalist.Where(i => i.Id == id).SingleOrDefault();
            if (data!=null){

                data.Id = input.Id;
                data.ApplicationId = input.ApplicationId;
                data.Type = input.Type;
                data.Summary = input.Summary;
                data.Amount = input.Amount;
                data.PostingDate = input.PostingDate;
                data.IsCleared = input.IsCleared;
                data.ClearedDate = input.ClearedDate;
            }
               
            return data;
                
        }

        // DELETE: api/Test/5
        public void Delete(string id,TestData input)
        {
            TestData data = testdatalist.Where(i => i.Id == id).SingleOrDefault();
            if (data != null)
            {
                testdatalist.Remove(data);
            }
        }
    }
}
