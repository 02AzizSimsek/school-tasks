using System;

namespace Nesne
{

    class Test
    {
        private BenimStringim benimString;
        public Test(BenimStringim benimStringim)
        {
            this.benimString = benimStringim;
        }
        public void TestEt()
        {
           
           
            Console.WriteLine(benimString);
            Console.WriteLine("_________________________");
            Console.WriteLine("==> Eleman Sayisi <==");
            Console.WriteLine(benimString.ElemanSayisi());
           
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Araya Girme <==");
            Console.WriteLine(benimString.ArayaGirmeMetodu(8, "007"));
            
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Birlestirme Metodu <==");
            string birlestirme = BenimStringim.BirlestirmeMetodu("Back", "End");
            Console.WriteLine("Back End ilk hali");
            Console.WriteLine(birlestirme);
        
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Char Diziye Donusturme/Bu kısımda  sıkıntı olabilir <==");
            Console.WriteLine(benimString.CharDiziyeDonusturmeMetodu());           
           
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Deger Alma <==");            
            Console.WriteLine(benimString.DegerAlmaMetodu(5,3));
         
            Console.WriteLine("__________________________");
            Console.WriteLine("==>Diziye Ayirma<==");
            BenimStringim s2 = new BenimStringim("Ai Bootstrap C# Developer Engima Fortran Gidecek");
            string[] subs = s2.DiziyeAyirmaMetodu(' ');          
            foreach (var tmp in subs)
            {
                Console.WriteLine(tmp);
            }
          
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Deger Indis Cevirme <==");
            Console.WriteLine(benimString.DegerIndisCevirMetodu(new BenimStringim("Dev")));
           
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Sirala Adan Z'ye <==");
            Console.WriteLine(benimString.SiralaAdanzyeMetodu());
           
            Console.WriteLine("__________________________");
            Console.WriteLine("==> Sirala Z'den A'ya <==");
            Console.WriteLine(benimString.SiralaZdenayaMetodu());
          
            Console.WriteLine("_________________________");
            Console.WriteLine("==> Ters Cevirme <==");
            Console.WriteLine(benimString.TersCevirmeMetodu());
               
        }
    }
}