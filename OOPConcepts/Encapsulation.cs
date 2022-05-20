using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public class Encapsulation
    {

      internal class User{
      
            public User(string email,string pw) { 
            
            }
            private bool Auth(User user) //This method is private because we will use it only internal
            {
                if (false) return false; //if we coudn't find this user in db.
                return true; //we found.
            }

            public bool Login(User user) //Encapsulation example.We will only use this method as public.We don't need others.But when we call this method, it will run another methods. 
            {

                if (!Auth(user))
                {
                    return false;
                }
                else
                {
                    return true;
                }
                return true;
            }  
      }
    }
}
