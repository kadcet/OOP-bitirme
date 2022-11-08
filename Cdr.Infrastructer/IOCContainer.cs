

namespace Cdr.Infrastructer
{
    public class IOCContainer
    {
        private static readonly Dictionary<Type, Func<object>> container = new Dictionary<Type, Func<object>>();
        // sözlüğün içine bişeyleri eklemek ve birşeyleri ordan çözümlemek

        // çözümlemek
        public static T Resolve<T>()
        {
            
            // T ye dönüştür. Neyi. container içerisinde arama yapıcan (liste gibi açande ındex yok. Neyle kaydettik Type ile.O zaman Type den sorucam. typeof keywordü geriye Type döner ) [BURADA] Typeof gelen T nin tipini bul onu containerin index paranntezlerinin içine parametre olarak geç.Ordan bir metod gelecek. Yukarıda Func.
            // () ile metodu çalıştır. onuda en soldaki T ye kest ediyorum. Resolve<T> T burda hep interfacelerim oluyor.
            return (T)container[typeof(T)]();

            /* Örneğin Resolve<T>() T yi çözümle dediler. Örneğin T nin yerinde ICategoryServise var. container in içine 
            ICategoryServise i Type ye dönüştürdüm. odan geriye CategoryService geliyor. Bu metodu tetiklemem çalıştırmam lazım ki CategoryService si üretsin. Elimde an itibariyle CategoryService var mı var. Bunu T ye kest ediyorum tekrar yani IICategoryServise ne tekrar kest ediyorum ki geriye dönebileyim. */
            

        }
        // Kaydet
        public static void Register<T>(Func<object> func)
        {
            if(container.ContainsKey(typeof(T)))
                container.Remove(typeof(T));

            container.Add(typeof(T), func);
        }

       
    }
}
#region Dictionary Mantığı
//List<string> strList = new List<string>();
//strList.Add("coder");
//var x = strList[0];

//Dictionary<string, string> sozluk = new Dictionary<string, string>();
//sozluk.Add("Coder", "Bir eğitim firmasıdır");

//var a = sozluk["Coder"];
//// benden key istiyo. coder i verdim. Bana coder key inin karşılındaki değeri ver.
//// a nın içine Bir eğitim firmasıdır gelecek

//Dictionary<Type, Func<object>> bizimki = new Dictionary<Type, Func<object>>();
//bizimki.Add(typeof(ICategoryService),()=> new CategoryService()); 

// sondakini buna çevirdik

//bizimki.Add(typeof(ICategoryService),()Olustur); 

//static CategoryService Olustur()
//{
//    return new CategoryService();
//}

#endregion

//var metot = container[typeof(T)];
//var servis = metot();
//return(T)servis;


// T ye dönüştür neyi container içerisinde listedeki gibi arama yapıcam [] () metodu çalıştır
//return (T)container[typeof(T)]();