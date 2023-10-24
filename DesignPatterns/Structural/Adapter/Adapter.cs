using DesignPatterns.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    // کتابخانه قدیمی که نیاز به Adapter دارد
    public class Adaptee
    {
        public string SpecificRequest()
        {
            return "Specific Request";
        }
    }

    // *******************************************

    // واسط مورد نیاز ما
    public interface ITarget
    {
        void Request();
    }

    // Adapter
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            LocalConsole.WriteLine("This is our own" + _adaptee.SpecificRequest());
        }
    }
}
