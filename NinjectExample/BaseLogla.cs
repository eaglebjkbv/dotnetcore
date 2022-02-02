namespace NinjectExample
{
    class BaseLogla : Iloglama
    {   private Iloglama _loglama;
        public BaseLogla(Iloglama loglama)
        {
            _loglama=loglama;
        }
        public string sifreCoz(string mesaj)
        {
            return _loglama.sifreCoz(mesaj);
        }

        public string sifreYap(string mesaj)
        {
            return _loglama.sifreYap(mesaj);
        }
    }

}
