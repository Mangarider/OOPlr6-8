using OOPlr6;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlr6
{
    public class Group : Base
    {
        private List<Base> group = new List<Base>();
        private SolidBrush brush = new SolidBrush(Color.LightGray);

        public Group()
        {
            this.Name = "Group";
        }
        public override int returnX()
        {
            if (group.Count != 0) return this.group[0].returnX();
            else return -1;
        }
        public override int returnY()
        {
            if (group.Count != 0) return this.group[0].returnY();
            else return -1;
        }
        public void addShape(Base Shape)
        {
            group.Add(Shape);
        }
        public override void draw(Graphics gr)
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].draw(gr);
            }
        }
        public override void mark()
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].mark();
            }
        }
        public override void unmark()
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].unmark();
            }
        }
        public override void remark()
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].remark();
            }
        }
        public override bool is_marked()
        {
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].is_marked()) return true;
            }
            return false;
        }
        public override SolidBrush GetBrush()
        {
            return brush;
        }
        public override void setColor(Color color)
        {
            for (int i = 0; i < group.Count; i++)
            {

                group[i].setColor(color);

            }
        }
        public override bool touched(int x, int y)
        {
            for (int i = 0; i < group.Count; i++)
            {
                if (group[i].touched(x, y))
                    return true;
            }
            return false;
        }
        public override void move(int x, int y, int width, int height)
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].move(x, y, width, height);

            }
        }
        public override void changeSize(int num)
        {
            for (int i = 0; i < group.Count; i++)
            {
                group[i].changeSize(num);

            }
        }
        public override void save(StreamWriter st)
        {
            st.WriteLine("Group");
            st.WriteLine("The amount is " + group.Count);
            for (int i = 0; i < group.Count; i++)
            {
                group[i].save(st);
            }

        }
        public int returnSize()
        {
            return group.Count();
        }
        public override void load(StreamReader st)
        {
            //14
            int count = Int32.Parse(st.ReadLine().Substring(14));

            for (int i = 0; i < count; i++)
            {
                string figure = st.ReadLine();
                Base shape;
                switch (figure)
                {
                    case "Circle":
                        shape = new CCircle(0, 0, 0);
                        break;
                    case "Square":
                        shape = new Square(0, 0);
                        break;
                    case "Triangle":
                        shape = new Triangle(0, 0);
                        shape = new Triangle(0, 0);
                        break;
                    case "Group":
                        shape = new Group();
                        break;
                    default:
                        shape = null;
                        break;
                }
                shape.load(st);
                if (shape != null) addShape(shape);
            }
        }
        public override void drawArr(Graphics g, int a_x, int a_y)
        {
            Pen p = new Pen(Brushes.GreenYellow, 3);
            p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, this.group[0].returnX(), this.group[0].returnY(), a_x, a_y);
        }
        public Base popBase(int j)
        {
            if (j < group.Count())
                return group[j];
            else return null;
        }
    }
}