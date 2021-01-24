using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T demek bir çeşit tip kullanacaksak yazılır.
    {
        T[] items;
        //constructor
        public MyList() //ctor yazıp tab-tab yap!!! / MyList classını çağıdığın an otomatik çalışır.
        {
            items = new T[0];
        }
        public void Add(T item) //Burda T yazmamızın amacı kullanıcı başta hangi tipi girerse öyle devam etsin demek yani tip seçimini kullanıcıya bırakıyoruz.
        {
            T[] tempArray = items; //önceki elemanlarımı korumak için tempArray de tutuyorum
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
