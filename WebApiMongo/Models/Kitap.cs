using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WebApiMongo.Models
{
    public class Kitap
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("kadi")]
        public string KitapAdi { get; set; }
        [BsonElement("kfiyat")]
        public int KitapFiyati { get; set; }
        
    }
}