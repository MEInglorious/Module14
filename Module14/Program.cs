using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;


namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Михаил", "Иванов", 375291234567, "ivanov@mail.ru"));
            phoneBook.Add(new Contact("Павел", "Смирнов", 375331110022, "smirnov@mail.ru"));
            phoneBook.Add(new Contact("Александр", "Кузнецов", 375253210123, "kuznecov@mail.ru"));
            phoneBook.Add(new Contact("Кирилл", "Попов", 375441515987, "popov@mail.ru"));
            phoneBook.Add(new Contact("Владислав", "Васильев", 375299537518, "vasilev@mail.ru"));
            phoneBook.Add(new Contact("Евгений", "Петров", 375449871436, "petrov@mail.ru"));

            // сортируем список контактов
            var sortedPhoneBook = phoneBook.OrderBy(x => x.Name).ThenBy(y => y.LastName);

            // выводим список в консоль
            foreach (var contact in sortedPhoneBook)
                Console.WriteLine("{0} {1}", contact.Name, contact.LastName);

            Console.ReadKey();
        }
    }
}