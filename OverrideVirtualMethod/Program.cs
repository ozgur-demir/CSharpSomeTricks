//Override virtual method

Customer c = new Customer("Ozgur", "Demir");
Console.WriteLine(c);

class Customer
{
    private string Name { get; set; }
    private string Surname { get; set; }
    public Customer(string Name, string Surname) { this.Name = Name; this.Surname = Surname; }
    public override string ToString()
    {
        return $"{Name} {Surname}";
    }
}