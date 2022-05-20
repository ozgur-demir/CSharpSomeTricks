using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class Abstraction
    {
        void WriteToScreen(string txt)
        {
            Console.WriteLine(txt); // It's an example for abstraction.We know this method.We already using it for writing somethings to console.But we don't know behind of this method.
                                    // We don't know how .NET FW is creating this text(font,size,location).We are not interest with them.We just know WriteLine method.
        }
    }
}
