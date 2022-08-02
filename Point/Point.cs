using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Point
    {
        int x;
        int y;
        public void Initialize(int x, int y)
        {
            SetX(x);
            SetY(y);    
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public void Translate(int xOffset, int yOffset)
        {
            this.x += xOffset;
            this.y += yOffset;
        }
        public void Scale(int a)
        {
            this.x *= a;
            this.y *= a;
        }
        public double Distance(Point p)
        {
            double value;
            value=Math.Sqrt((this.x - p.x)*(this.x-p.x)+(this.y-p.y)*(this.y-p.y)); 
            return value;
        }
        static void Main()
        {
            Point p=new Point();
            Point p2=new Point();
            p.Initialize(3, 2);
            p.Translate(3, 2);
            p.Scale(2);
            p2.Initialize(3, 4);
            double Value;
            int x, y;
            Value = p.Distance(p2);
            x=p.GetX();
            y= p.GetY();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Value);
        }
    }
    
}
