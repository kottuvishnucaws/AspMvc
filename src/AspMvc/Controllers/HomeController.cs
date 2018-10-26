using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspMvc.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Data;

namespace AspMvc.Controllers
{
    public class HomeController : Controller
    {
        private static List<Student_Info> student;

        public IActionResult Index(Student_Info info)
        {
            if (info.Name != null)
            {
                InsertStudentData(info).Wait();
                ModelState.Clear();
                ViewBag.Success = "Submitted Successfully...!";
            }
            return View();
        }

        public IActionResult GetStudentData()
        {
            GetStudent().Wait();

            return View(student);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
            //var document2 = new Student_Info
            //{
            //    Student_ID = 3,
            //    Name = "VishnuKumar",
            //    Branch = "ece"
            //};

            //await collection.InsertManyAsync(new[] { document, document2 });
            await collection.InsertOneAsync(document);
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
    }
}
