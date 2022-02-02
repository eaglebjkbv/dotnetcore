namespace Ogrenciler.DAL
{
    public class OgrencilerDatabaseSetting:IOgrencilerDatabaseSettings
    { 
        public string OgrencilerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IOgrencilerDatabaseSettings
    {
        string OgrencilerCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    }
}