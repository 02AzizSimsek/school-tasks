using System.Collections;

namespace Nesne
{

    class BenimStringim
    {
        private string data;
        public BenimStringim(string data)
        {
            this.data = data;
        }
        
        //nensedeki eleman sayısını verecek kod blogu
        
            public int ElemanSayisi()
            {
            int elemanSayisi = 0;
           
            foreach  (var tmp in data)
            {               
                elemanSayisi++;
            }
            return elemanSayisi;
            }
       
        
        // Girilmiş string Sabit veya Nesne değeri,ana nesnenin değerlerinin arasına yerleştirilecek yerleştirme parametre olarak verilen bir dizinden itibaren olacaktır.
       
        public string ArayaGirmeMetodu(int dizin, string data)
        {
            char[] chk = new char[dizin];
            
            char[] chl = new char[ElemanSayisi() - dizin];
            
            for (int i = 0; i < dizin; i++)
            {
                chk[i] = this.data[i];
            }
            
            int sayac = dizin;
            
            for (int i = 0; i < ElemanSayisi() - dizin; i++)
            {
                chl[i] = this.data[sayac++];
            }
           
            return new string(chk) + data + new string(chl);
        }


        //İki string nesne değeri birleştirilecek kod blogu
       
        public static string BirlestirmeMetodu(string dataK, string dataL)
        {
            return dataK + dataL;
        }
       
        // Ana nesnenin değerini verilen karaktere göre diziye ayıracak kod blogu,(ayrılan kısım Test.cs kısımında satır 37 deki gidecek yazısı.)
        
        public string[] DiziyeAyirmaMetodu(char chr)
        {
            ArrayList arrayList = new ArrayList();
           
            string tmp = "";
            
            for (int i = 0; i < ElemanSayisi(); i++)
            {
               
                if (data[i] != chr)
                {
                    tmp += data[i];
                   
                    continue;
                }

                
                arrayList.Add(tmp);
                tmp = "";
            }
            
            string[] subStrings = new string[arrayList.Count];
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                subStrings[i] = arrayList[i].ToString();
            }

            return subStrings;
        }
       

        // Ana nesnenin değerini belirtilen dizinden başlayarak belirtilen karakter kısmına kadar geri döndüren kod blogu
        public string DegerAlmaMetodu(int dizin, int character)
        {
            char[] ch1 = new char[character];
        
            int sayac = dizin;
           
            for (int i = 0; i < character; i++)
            {
                ch1[i] = data[dizin++];
            }
            
            return new string(ch1);
        }
      
        
        // Ana nesne içerisinde aranan kısmın indisini döndürecek olna kod blogu.
        public int DegerIndisCevirMetodu(BenimStringim data)
        {
            bool match;

            for (int i = 0; i < ElemanSayisi() - data.ElemanSayisi() + 1; i++)
            {
                match = true;
              
                for (int j = 0; j < data.ElemanSayisi(); j++)
                {
                
                    if (this.data[i + j] != data.data[j])
                    {
                        match = false;
                    
                     break;
                    }
                }
               
                if (match) return i;
            }
            return -1;
        }
       
        //Ana nesne değerini char diziye dönüştürecek kod blogu,bunun çalıştıgından emin degilim .
     
        public char[] CharDiziyeDonusturmeMetodu()
        {
          
            char[] ch = new char[ElemanSayisi()];
         
            for (int i = 1; i < ElemanSayisi(); i++)
            {
                ch[i] = data[i];
            }
           
            return ch;
        }
      
        // Ana nesnenin değerini ters çeviren kod blogu
       
        public string TersCevirmeMetodu()
        {
        
            char[] chars = data.ToCharArray();
        
            for (int i = 0, j = ElemanSayisi() - 1; i < j; i++, j--)
            {
                chars[i] = data[j];
                chars[j] = data[i];
            }
       
            return new string(chars);
        }
       
        //Ana nesnenin elemanlarını a dan z ye sıralı döndüren kod blogu
       
        public string SiralaAdanzyeMetodu()
        {
            char temp;
            
            string str = data.ToLower();
         
            char[] charStr = str.ToCharArray();
           
            for (int i = 1; i < ElemanSayisi(); i++)
            {
                for (int j = 0; j < ElemanSayisi() - 1; j++)
                {
                    if (charStr[j] > charStr[j + 1])
                    {
                        temp = charStr[j];
          
                        charStr[j] = charStr[j + 1];
          
                        charStr[j + 1] = temp;
                    }
                }
            }
            return new string(charStr);
        }
        
        
        //Ana nesnenin değerini z den a ya sıralayacak kod blogu.
        public string SiralaZdenayaMetodu()
        {
            
            char temp;
            string str = data.ToLower();
           
            char[] charStr = str.ToCharArray();
            
            for (int i = 1; i < ElemanSayisi(); i++)
            {
              
                for (int j = 0; j < ElemanSayisi() - 1; j++)
                {
                 
                    if (charStr[j] < charStr[j + 1])
                    {
                        temp = charStr[j];
                        charStr[j] = charStr[j + 1];
                        charStr[j + 1] = temp;
                    }
                }
            }
          
            return new string(charStr);
        }      
       
        public override string ToString()
        {
            return data;
        }
    }
}