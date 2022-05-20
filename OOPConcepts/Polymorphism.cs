using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class Polymorphism
    {
        class Shape
        {
            public void Add() //static
            {
                Console.WriteLine("Shape is creating as file ...");
            }
            public void Add(string db) //static
            {
                Console.WriteLine("Shape is adding to db..."+db);

            }
            public virtual void CreateShape() //dynamic 
            {
                Console.WriteLine("Shape is creating...");
            }
        }
        class Triangle:Shape //dynamic
        {
            public override void CreateShape()
            {
                Console.WriteLine("Triangle is creating...");
            }
        }
        class Rectangle : Shape //dynamic
        {
            public override void CreateShape()
            {
                Console.WriteLine("Rectangle is creating...");
            }
        }
    }
}
