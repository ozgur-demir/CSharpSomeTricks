// Operator overload

Rectangle r1 = new Rectangle() { x=10, y=20 };
Rectangle r2 = new Rectangle() { x=15, y=40 };
Rectangle r3 = r1 + r2;
Console.WriteLine(r3);

class Rectangle
{
    public int x;
    public int y;
    public override string ToString()
    {
        return x.ToString() + " " + y.ToString();
    }
    public static Rectangle operator +(Rectangle r1,Rectangle r2)
    {
        return new Rectangle() { x = r1.x + r2.x, y = r1.y + r2.y };
    }
}