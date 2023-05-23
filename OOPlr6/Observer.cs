using OOPlr6;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlr6
{
    class Observer
    {
        public Observer()
        {

        }
        public void notifyMarked(Base who, Graphics gr, bool check)
        {
            if (check) who.mark();
            else who.unmark();
            who.draw(gr);
        }
    }
}