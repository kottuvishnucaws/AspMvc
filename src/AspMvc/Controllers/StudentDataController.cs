using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspMvc.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace AspMvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDataController : ControllerBase
    {
        private static List<Student_Info> student;

        // GET: api/StudentData
        [HttpGet]
        public IEnumerable<Student_Info> Get()
        {
            GetStudent().Wait();

            return student;
        }

        // GET: api/StudentData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/StudentData
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Student_Info info = JsonConvert.DeserializeObject<Student_Info>(value);

            InsertStudentData(info).Wait();
        }

        // PUT: api/StudentData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        static async Task GetStudent()
        {
            student = new List<Student_Info>();

            var connectionString = "mongodb://VishnuKottu:VishnuTemp1a@cluster0-shard-00-00-g55qv.mongodb.net:27017,cluster0-shard-00-01-g55qv.mongodb.net:27017,cluster0-shard-00-02-g55qv.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("VishnuDB");

            var collection = db.GetCollection<Student_Info>("StudentData");

            using (var cursor = await collection.Find(new BsonDocument()).ToCursorAsync())
            {
                while (await cursor.MoveNextAsync()) //Cursor maintain the batch size here.
                {
                    foreach (var doc in cursor.Current)////represent the current document in the cursor
                    {
                        student.Add(doc);
                    }
                }
            }
        }

        static async Task InsertStudentData(Student_Info info)
        {
            var connectionString = "mongodb://VishnuKottu:VishnuTemp1a@cluster0-shard-00-00-g55qv.mongodb.net:27017,cluster0-shard-00-01-g55qv.mongodb.net:27017,cluster0-shard-00-02-g55qv.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true";
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase("VishnuDB");

            var collection = db.GetCollection<Student_Info>("StudentData");

            var document = new Student_Info
            {
                Student_ID = info.Student_ID,
                Name = info.Name,
                Branch = info.Branch
            };
            await collection.InsertOneAsync(document);
        }
    }
}
