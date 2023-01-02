using System;

namespace Task7Subtask7._7
{
    class Order
    {

        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Возраст заказчика", Age);
        }
    }

    class Years : Order
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 16)
                {
                    Console.WriteLine("Заказ можно оформить только с 16 лет");
                }
                else
                {
                    age = value;
                }
            }
        }





        class Product : Order {


            public string Name;
            public string Description;
        }

        // Класс для объекта “Коллекция продуктов”
        class ProductCollection
        {
            // Закрытое поле, хранящее продукты в виде массива
            private Product[] collection;

            // Конструктор с добавлением массива продукта
            public ProductCollection(Product[] collection)
            {
                this.collection = collection;
            }

            // Индексатор по массиву
            public Product this[int index]
            {
                get
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        return collection[index];
                    }
                    else
                    {
                        return null;
                    }
                }

                private set
                {
                    // Проверяем, чтобы индекс был в диапазоне для массива
                    if (index >= 0 && index < collection.Length)
                    {
                        collection[index] = value;
                    }
                }
            }

        }
    
   
    




    abstract class Delivery
        {
            public string Address;
        }

        class HomeDelivery : Delivery
        {
            /* ... */
        }

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }

        class Order<TDelivery,
        TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            // ... Другие поля
        }
    }
}