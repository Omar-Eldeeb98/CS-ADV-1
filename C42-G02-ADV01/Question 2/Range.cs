using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV01.Question_2
{
    internal class Range<T> where T : IComparable<T>
    {

        // properties
        public T startValue { get; set; }
        public T endValue { get; set; }


      

        // constructors
        public Range(T startValue, T endValue )
        {
            if(startValue.CompareTo(endValue) > 0)
            {
                Console.WriteLine("start value should less then end value.");
            }
          
            this.startValue = startValue;
            this.endValue = endValue;
        }


        // methods

        public bool isInRange(T value)
        {
            return startValue.CompareTo(value) <= 0 && endValue.CompareTo(value) >= 0;
        }


        public override string ToString()
        {
            return $"Range: [{startValue} - {endValue}] ";
        }


        // method to return the length of the range
       public T Length()
        {
            dynamic start = this.startValue;
            dynamic end = this.endValue;
            return end - start;
        }

    }
}
