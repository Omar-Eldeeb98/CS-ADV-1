using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_1.Generics
{
    internal class Point:IComparable<Point>
    {
        // properties
        public int x { get; set; }
        public int y { get; set; }

        // constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // methods
        public override string ToString()
        {
            return $"({x} , {y})";
        }

        public int CompareTo(Point? other)
        {
            if(other is null)
            {
                return 1;
            }
            if(this.x == other.x)
            {

                return this.y.CompareTo(other.y);
            }
            else
            {
                return this.x.CompareTo(other.x);
            }
        }

        //-------------------------------------------------------

        //    public int CompareTo(object? obj)
        //    {

        //        if(obj is Point p)
        //        {
        //            if(this.x == p.x)
        //            {
        //                return this.y.CompareTo(p.y);
        //            }
        //            else
        //            {
        //                return this.x.CompareTo(p.x);
        //            }

        //        }
        //        else
        //        {
        //            return 1;
        //        }



        //    }


        }
    }
