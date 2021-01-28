using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Burada biz <> işaretleri arasına istediğimizi yazabiliriz ancak tek bir generic (jenerik) oluşturacaksak standart olarak 'T' (Type) koyulur.
    // Biz hatırlarsak List<T> yazıp 'T'nin olduğu yere istediğimiz veir tipini yazabiliyorduk ( int, string, bool, double... ). 
    // Yani biz burada class'a 'T' tipi ile çalışacağız demiş oluyoruz. Bir başka deyişle 'T', verdiğimiz tipe karşılık geliyor.
    // PRogramın amacı ise şu: Eğer List<> olmasaydı biz kendi 'collection'umuzu nasıl oluştururduk?
    class MyList<T> // yukarıyı oku orada <T> yapısını anlatılıyor
    {
        T[] items; // bir dizi oluşturulunca 'new'lenmek zorundadır. Biz bu diziyi burada 'new'lemiyoruz çünkü kullanıcı 'MyList<string> isimler;' gibi bir tanımlama yapabilir.
        // Bu yüzden kullanıcı 'new'lediği zaman items Array'ini 'new'lememiz gerekiyor. Burada arrayi stack kısmına kaydettik ancak daha new'lemedik yani heap'a atmadık. Bunu kullanıcı new'lediğinde yapacağız.
        // Kullanıcı new'lediğinde bunu algılamak için aşağıdaki kod parçası çalışıyor. 
        // MyList'i new'lediğimiz anda çalışan bu bloğa 'constructor' denir.
        public MyList() // Bu metod, kullanıcı MyList'i new'lediğinde çalışır. Bu kod parçasını hızlıca yazmak için 'ctor' yazıp 'TAB+TAB' yapabilirsiniz
        {
            items = new T[0]; // Burada önceden stack'a atadığımız items'i heap'a atıyoruz. Yani new'liyoruz. // ilk başta da 0 elemanlı yapıyoruz ki List class'ındaki Count() metodu gibi başlangıç uzunluğu 0 olsun.
        }
        public void Add(T item) // Burada 'T' bizim yazdığımız değişken tipine karşılık geliyor
        {
            T[] tempArray = items; // Temporary Array(Yedek Dizi) oluşturduk ve bu dizinin referansını (adresini / new'ini) items'in referansına ( adresine / new'ine ) atadık ( eşitledik ).Örneğin TempArray'in  item sayısı 5 ise items[]'in ki 6 olur.
            // Örneğin items'in referansı 101 ise tempArray'in referansı da 101 oldu. Yani biz bu adresi başka bir değişkene tutturduk.
            items = new T[items.Length + 1]; // burada ise items'i new'ledik yani ona yeni bir adres(referans) verdik. Örneğin eski referans 101 ise 102 referansını tutturduk.
            // Yani 'new' ifadesi yeni bir referans ( heap'ta yeni bir yer) vermeye yarar. Daha sonra köşeli parantez içerisine de (T[]) 'items.Lenght + 1 yazdık. 
            // Yani items array'i kaç elemanlı ise onun bir fazlası. Yani ilk başta 0 olacağı için 0+1 den 1 elemanlı olmuş olur.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
