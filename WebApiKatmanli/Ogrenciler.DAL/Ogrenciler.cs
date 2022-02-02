using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Ogrenciler.DAL
{
    public class Ogrenciler
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int id { get; set; } 
        
        [BsonElement("adi")]
        public string ad { get; set; } 
        public string soyad { get; set; }

    }
}