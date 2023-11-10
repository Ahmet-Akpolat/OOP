namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // It's Me
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNum = "123455";
            customer1.TcNum = "01234567890";
            customer1.Name = "Ahmet";
            customer1.Surname = "Akpolat";

            // Tobeto
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNum = "123456";
            customer2.CompanyName = "Tobeto";
            customer2.TaxNum = "9876543210";

            // Bireysel - Kurumsal Müşteri
            // SOLİD Prensipleri

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}