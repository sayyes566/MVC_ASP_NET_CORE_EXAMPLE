using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BookStore.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("age")]
        public decimal Age { get; set; }

        [BsonElement("job")]
        public string Job { get; set; }

        [BsonElement("mentor")]
        public string Mentor { get; set; }
    }
}
