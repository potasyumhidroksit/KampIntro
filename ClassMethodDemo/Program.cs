using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.AccountNumber = "1";
            customer1.CustomerName = "Ahmet Enes";
            customer1.CustomerSurname = "Karaca";
            customer1.CustomerAddress = "Atakum";
            customer1.CustomerPhone = "5529269210";

            Customer customer2 = new Customer();
            customer2.AccountNumber = "2";
            customer2.CustomerName = "1. X kişisi";
            customer2.CustomerSurname = "Soyisim";
            customer2.CustomerAddress = "Bafra";
            customer2.CustomerPhone = "5555555555";

            Customer customer3 = new Customer();
            customer3.AccountNumber = "3";
            customer3.CustomerName = "2. X kişisi";
            customer3.CustomerSurname = "Soyisim";
            customer3.CustomerAddress = "Samsun";
            customer3.CustomerPhone = "5055055050";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager cm = new CustomerManager();

            Console.WriteLine("Müşteri sistemine hoşgeldiniz!\n" +
                "Müşteri eklemek için 1'i,\n" +
                "Müşteri listesine ulaşmak için 2'yi\n" +
                "Müşteri silmek için 3'ü tuşlayınız.\n");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Customer customerNew = new Customer();
                Console.WriteLine("Müşteri hesap numarasını giriniz: ");
                customerNew.AccountNumber = Console.ReadLine();

                Console.WriteLine("Müşteri adını giriniz: ");
                customerNew.CustomerName = Console.ReadLine();

                Console.WriteLine("Müşteri soyadını giriniz: ");
                customerNew.CustomerSurname = Console.ReadLine();

                Console.WriteLine("Müşteri adresini giriniz: ");
                customerNew.CustomerAddress = Console.ReadLine();

                Console.WriteLine("Müşteri telefon numarasını giriniz: ");
                customerNew.CustomerPhone = Console.ReadLine();

                cm.CustomerAdd(customerNew);
            }
            else if (secim == 2)
            {
                cm.CustomerList(customers);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Silmek istediğiniz müşterinin hesap numarasını giriniz:");
                string delAccountNo = Console.ReadLine();
                cm.CustomerDelete(delAccountNo);
            }
            else
            {
                Console.WriteLine("Hatalı bir seçim yaptınız!");
            }
        }
    }
}