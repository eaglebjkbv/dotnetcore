namespace NinjectExample
{
    class LoglaSql : Iloglama
    {
        public string sifreCoz(string mesaj)
        {
            return "Şifrelendi SQL servere kaydedildi Mesaj :"+mesaj;
        }

        public string sifreYap(string mesaj)
        {
            return "Şifre Çözüldü SQL serverdan okundu Mesaj:"+mesaj;
        }
    }

}
