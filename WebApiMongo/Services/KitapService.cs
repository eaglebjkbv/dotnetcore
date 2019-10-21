using WebApiMongo.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace WebApiMongo.Services
{
    public class KitapService
    {
        private readonly IMongoCollection<Kitap> _kitaplar;
        
        public KitapService(IKitapciDatabaseSettings settings)
        {
            var client=new MongoClient(settings.ConnectionString);
            var database=client.GetDatabase(settings.DatabaseName);

            _kitaplar=database.GetCollection<Kitap>(settings.KitapciCollectionName);
        }
        public List<Kitap> Get()=>
            _kitaplar.Find(kitap=>true).ToList();

        public Kitap Get(string id) =>
            _kitaplar.Find<Kitap>(kitap=>kitap.Id==id).FirstOrDefault();
        public Kitap Create(Kitap kitap)
        {
            _kitaplar.InsertOne(kitap);
            return kitap;
        }
        public void Update(string id,Kitap kitapIn)=>
            _kitaplar.ReplaceOne(kitap=> kitap.Id==id,kitapIn);
        public void Remove(Kitap kitapIn) =>
            _kitaplar.DeleteOne(kitap=>kitap.Id==kitapIn.Id );
        public void Remove (string id)=>
            _kitaplar.DeleteOne(kitap=> kitap.Id==id);
    }


}