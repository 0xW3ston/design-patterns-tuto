using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Observer
{
    public interface IObserver
    {
        void Update(string new_msg);
    }
}
