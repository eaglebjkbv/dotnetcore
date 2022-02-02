namespace NinjectExample
{
    class LoglaMongo : Iloglama
    {
        public string sifreCoz(string mesaj)
        {
            return "Şifrelendi Mongo servere kaydedildi Mesaj:"+mesaj;
        }

        public string sifreYap(string mesaj)
        {
            return "Şifre Çözüldü Mongo serverdan okundu Mesaj:"+mesaj;
        }
    }

}
