using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Observer
{
    public class UserObserver : IObserver
    {
        private string latestMsg = "";
        public void Update(string new_msg)
        {
            latestMsg = new_msg;
            Console.WriteLine($"[NEW NOTIFICATION]: \u001b[1;31m {latestMsg} \u001b[0m");
        }
    }
}
