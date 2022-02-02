namespace WebApiMongo.Models
{
    public class KitapciDatabaseSettings : IKitapciDatabaseSettings
    {
        public string KitapciCollectionName { get ; set ; }
        public string ConnectionString { get; set;  }
        public string DatabaseName { get; set  ;}
    }
    public interface IKitapciDatabaseSettings
    {
        string KitapciCollectionName { get; set; }
        string ConnectionString{get;set;}
        string DatabaseName { get; set; }
    }
}