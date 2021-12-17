using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SravanthiSelenium.InheritanceByObject
{
    public class RComponents
    {
        public RComponents()
        {
            Console.WriteLine("Delete all Temp Records"); //We have to write the required code to delete temp records
            Console.WriteLine("Open Google Chrome Browser");
        }
        public RComponents(String browsername)
        {
            Console.WriteLine("Delete all Temp Records"); //We have to write the required code to delete temp records
            Console.WriteLine("Open Browser  of user choice : " + browsername);  // we have to write if conditions here
        }
        public RComponents(String browsername,int version)
        {
            Console.WriteLine("Delete all Temp Records"); //We have to write the required code to delete temp records
            Console.WriteLine("Open Browser  of user choice : " + browsername  + " With Version : " + version);  // we have to write if conditions here
        }
        //*********************ReusableComponents********************
        public void LaunchApplication()
        {
            Console.WriteLine("RC : LaunchApplication ");
        }
        public void LoginToApplication()
        {
            Console.WriteLine("RC : LoginToApplication ");
        }
        public void LogoutFromApplication()
        {
            Console.WriteLine("RC : LogoutFromApplication ");
        }
        public void CloseApplication()
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
