using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvc.Models
{
    public class Student_Info
    {    
        [BsonId]
        public ObjectId _id { get; set; }
        public Int32 Student_ID { get ; set; }
        public string Name{ get; set; }
        public string Branch{ get; set; }
    }
}
