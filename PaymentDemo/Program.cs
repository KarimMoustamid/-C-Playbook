// See https://aka.ms/new-console-template for more information
using Pluralsight.CShPlaybook.MethodsProps;
CookieCustomer customer = new CookieCustomer(0, "", "");

Console.WriteLine(customer);

char firstCh = customer.NameFirstChar;
Console.WriteLine("customer's name starts with " + firstCh);