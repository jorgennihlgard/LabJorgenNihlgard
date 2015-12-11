using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    struct MyDoubleType
    {
        public double DoubleValue { get; set; }

        public MyDoubleType(double doubleValue)
        {
            DoubleValue = doubleValue;
        }


        public static MyDoubleType operator +(MyDoubleType myDoubleType, double myDouble)
        {
            myDoubleType.DoubleValue += myDouble;
            return myDoubleType;
        }

        public static double operator +(double myDouble, MyDoubleType myDoubleType)
        {
            myDouble += myDoubleType.DoubleValue;
            return myDouble;
        }
        public static MyDoubleType operator -(MyDoubleType myDoubleType, double myDouble)
        {
            myDoubleType.DoubleValue -= myDouble;
            return myDoubleType;
        }

        public static double operator -(double myDouble, MyDoubleType myDoubleType)
        {
            myDouble -= myDoubleType.DoubleValue;
            return myDouble;
        }

        public static MyDoubleType operator *(MyDoubleType myDoubleType, double myDouble)
        {
            myDoubleType.DoubleValue *= myDouble;
            return myDoubleType;
        }

        public static double operator *(double myDouble, MyDoubleType myDoubleType)
        {
            myDouble *= myDoubleType.DoubleValue;
            return myDouble;
        }

        public static MyDoubleType operator /(MyDoubleType myDoubleType, double myDouble)
        {
            myDoubleType.DoubleValue /= myDouble;
            return myDoubleType;
        }

        public static double operator /(double myDouble, MyDoubleType myDoubleType)
        {
            myDouble /= myDoubleType.DoubleValue;
            return myDouble;
        }

        public static bool operator ==(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if(myDoubleType.DoubleValue == myDoubleType1.DoubleValue)
            {
                return true;
            }
           
                return false;
            
      
        }

        public static bool operator !=(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if(myDoubleType.DoubleValue != myDoubleType1.DoubleValue)
            {
                return true;
            }
          
                return false;
            
            

        }

        public static bool operator <(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if (myDoubleType.DoubleValue < myDoubleType1.DoubleValue)
            {
                return true;
            }
           
                return false;
            
        }

        public static bool operator >(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if (myDoubleType.DoubleValue > myDoubleType1.DoubleValue)
            {
                return true;
            }
           
            return false;
        }

        public static bool operator <=(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if (myDoubleType.DoubleValue <= myDoubleType1.DoubleValue)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(MyDoubleType myDoubleType, MyDoubleType myDoubleType1)
        {
            if (myDoubleType.DoubleValue >= myDoubleType1.DoubleValue)
            {
                return true;
            }
            return false;
        }
        
        public override string ToString()
        {
            return ($"Doublevalue: {DoubleValue}");
        }
    }
}
