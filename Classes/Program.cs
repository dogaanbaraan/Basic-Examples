
using Classes;

CustomerManager customerManager = new CustomerManager();

customerManager.Add();
customerManager.Update();

Console.ReadLine();

ProductManager productManager = new ProductManager();
productManager.Add();   
productManager.Update();

Console.ReadLine();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Baran";
customer.LastName = "Doğan";
customer.City = "İstanbul";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Barno",
    LastName = "Dogann",
    City = "Sivas"
};

Console.WriteLine(customer2.FirstName);





