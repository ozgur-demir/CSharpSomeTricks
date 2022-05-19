
//Using custom delegate

Car car = new Car();
car.Color = "Blue";
car.speedEvent += C_speedEvent;
for (int i = 5; i < 90; i+=5)
{
    System.Threading.Thread.Sleep(300);
    car.Speed = i;
    Console.WriteLine("The vehicle is accelerating:" + car.Speed);
}

static void C_speedEvent(int speedValue)
{
    Console.WriteLine($"Speed limit exceeded::::: Current Speed={speedValue}");
}


public delegate void speedEvent(int speed);
public class Car
{
    public event speedEvent speedEvent;
    private int _speed;
    public string? Color { get; set; }
    public int Speed
    {
        get
        {
            return _speed;
        }
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




