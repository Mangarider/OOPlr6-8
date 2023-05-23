using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
}

namespace OOPlr6
{
    public abstract class Base
    {

        private Observer obs = new Observer();
        public string Name { get; init; }
        protected bool marked = true;
        public abstract int returnX();
        public abstract int returnY();
        public string returnName()
        {
            return Name;

        }
        public void onSubjectChanged(Graphics gr, bool check)
        {
            obs.notifyMarked(this, gr, check);
        }



        public abstract SolidBrush GetBrush();

        public abstract void draw(Graphics g);

        public abstract void mark();

        public abstract void unmark();

        public abstract void remark();
        public abstract bool touched(int x, int y);
        public abstract bool is_marked();

        public abstract void move(int x, int y, int width, int height);

        public abstract void changeSize(int num);

        public abstract void setColor(Color color);

        public abstract void save(StreamWriter st);
        public abstract void load(StreamReader st);

        public abstract void drawArr(Graphics g, int a_x, int a_y);
        ~Base()
        {

        }
    }
}