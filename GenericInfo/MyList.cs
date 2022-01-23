using System;
using System.Collections.Generic;
using System.Text;

namespace GenericInfo
{
    class MyList<T>//diğer değerler classlar da eklenebilir. Fakat generic bir tane değer alıyroysa ona t diyeibliriz  a da diyebilriia
    {


        T[] items; //metodun dışında yazılır ama claassın içinde. o yüzden her yerden erişilebilir


        public MyList()
        {
            items = new T[0]; //0 elemanlı bir dizi oluşturduk 
        }
        public void Add(T item) //T olarak ne verilirse istenilen elemanın tipi de ol olsun . string isterse string, int olursa int. fark etmez
        {
            T[] tempArray = items; //Geçici dizinin referansı itemsın değerlerini tutuyo. çünkü new yapıldığında referans numarası sıfırlanır biz sıfırlamamak için geçicici diziye aktarıyoruz. 
            items = new T[items.Length + 1]; //dizinin eleman sayısını 1 arttırır 

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
