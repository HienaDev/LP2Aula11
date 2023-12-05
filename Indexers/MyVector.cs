using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Indexers
{
    public struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }

        public float Magnitude { get => MathF.Sqrt(X * X + Y * Y); }
        
        public MyVector(float x, float y)
        {
            X = x;
            Y = y;

            
        }

        public float this[int index]
        {
            get
            {
                if(index == 0) { return X; }
                else if (index == 1) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if(index == 0) { X = value; }
                else if (index == 1) { Y = value; }
                else { throw new IndexOutOfRangeException(); }
            }
        }

        public float this[string index]
        {
            get
            {
                if(index.ToLower() == "x" ||
                    index.ToLower() == "a" ||
                    index.ToLower() == "0" ) { return X; }
                else if (index.ToLower() == "y" ||
                    index.ToLower() == "b" ||
                    index.ToLower() == "1" ) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if(index.ToLower() == "x" ||
                    index.ToLower() == "a" ||
                    index.ToLower() == "0" ) {  X = value;  }
                else if (index.ToLower() == "y" ||
                    index.ToLower() == "b" ||
                    index.ToLower() == "1" ) { Y = value; }
                else { throw new IndexOutOfRangeException(); }
            }
        }

        public static MyVector operator +(MyVector v1, MyVector v2)
        {
            return (new MyVector(v1.X + v2.X, v1.Y + v2.Y));
        }

        public static MyVector operator -(MyVector v1, MyVector v2)
        {
            return (new MyVector(v1.X - v2.X, v1.Y - v2.Y));
        }

        public static bool operator >(MyVector v1, MyVector v2)
        {
            return (v1.Magnitude > v2.Magnitude);
        }

        public static bool operator <(MyVector v1, MyVector v2)
        {
            return (v1.Magnitude < v2.Magnitude);
        }

        public static bool operator >=(MyVector v1, MyVector v2)
        {
            return (v1.Magnitude >= v2.Magnitude);
        }

        public static bool operator <=(MyVector v1, MyVector v2)
        {
            return (v1.Magnitude <= v2.Magnitude);
        }

        public override string ToString()
        {
            return ($"({X}, {Y})");
        }

    }
}