
//Using custom delegate
Car car = new Car();
car.Color = "Blue";
car.speedEvent += (speedval) => { Console.WriteLine("Speed limit exceeded::::: Current Speed=" + speedval); return true; };
for (int i = 5; i < 90; i += 5)
{
    System.Threading.Thread.Sleep(300);
    car.Speed = i;
    Console.WriteLine("The vehicle is accelerating:" + car.Speed);
}

public class Car
{
    public event Func<int,bool> speedEvent;  //Predicate<int>
    private int _speed;
    public string? Color { get; set; }
    public int Speed
    {
        get => _speed;
        set
        {
            if (value >= 80 && speedEvent != null)
            {
                speedEvent(value);
                _speed = value;
            }
            else
            {
                _speed = value;
            }
        }
    }
}




