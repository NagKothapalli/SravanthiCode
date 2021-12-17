using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.Inheritance
{
    public class ReusableComponents
    {
        public ReusableComponents()
        {

        }
        //*********************ReusableComponents********************
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication from RC");
        }
        public void LoginToApplication()
        {
            Console.WriteLine("RC : LoginToApplication ");
        }
        protected void LogoutFromApplication()
        {
            Console.WriteLine("RC : LogoutFromApplication ");
        }
        protected void CloseApplication()
        {
            Console.WriteLine("RC : CloseApplication ");
        }
        public void Compose()
        {
            Console.WriteLine("RC : Compose Mail ");
        }
        public void Open()
        {
            Console.WriteLine("RC : Open Mail ");
        }
        public void Reply()
        {
            Console.WriteLine("RC : Reply Mail ");
        }
        public void Forward()
        {
            Console.WriteLine("RC : Forward Mail ");
        }
        public void Send()
        {
            Console.WriteLine("RC : Send Mail ");
        }
        public void Delete()
        {
            Console.WriteLine("RC : Delete Mail ");
        }
    }
}
