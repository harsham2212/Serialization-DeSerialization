using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationAndDeSerialization
{
    class JSONSerialization
    {
        public static void JsonSerialization()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Sam",
                Description = "Welcome to Universe"
            };

            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
        public static void JsonDeSerialization()
        {
            string json = @"{'Name':'Sam',
                              Description':'Welcome to Universe'}";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine(bsObj.Name);
        }
    }


[DataContract]
class BlogSites
    {
        public string Name { get; set; }
        public string Description { get; set; }  
    }
}
