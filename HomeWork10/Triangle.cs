using System;
using Task10;

namespace Task10
{
    public class Triangle
    {
        private double _side1, _side2, _baseSide;
        private double _area, _perimeter;

        public Triangle(double side1, double side2, double baseSide)
        {
            if (CheckValidTriangle(side1, side2, baseSide))
            {
                this._side1 = side1;
                this._side2 = side2;
                this._baseSide = baseSide;
            }
            else
            {
                throw new Exception("Invalid triangle dimensions.");
            }

        }
        

        public double GetArea()
        {
            double s = (_side1 + _side2 + _baseSide) / 2;

            _area = (Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _baseSide)));

            return _area;
            
        }

        public double GetPerimeter()
        {
            _perimeter = _side1 + _side2 + _baseSide;
            return _perimeter;
        }

        public bool CheckValidTriangle(double side1, double side2, double baseSide)
        {
            if (side1 + side2 <= baseSide || side1 + baseSide <= side2 || side2 + baseSide <= side1)
            {
                return false;
            }
            return true;
        }


        public static bool operator == (Triangle triangle1, Triangle triangle2)
        {
            return triangle1._area == triangle2._area;
        }
        public static bool operator != (Triangle triangle1, Triangle triangle2)
        {
            return (triangle1._area != triangle2._area);
        }
        public static bool operator > (Triangle triangle1, Triangle triangle2)
        {
            return triangle1._area > triangle2._area;
        }
        public static bool operator < (Triangle triangle1, Triangle triangle2)
        {
            return triangle1._area < triangle2._area;
        }
        public static Triangle operator + (Triangle triangle1, Triangle triangle2)
        {
            double newArea = triangle1._area + triangle2._area;
            double side11;
            double side22;
            double baseSide33;
            //baseSide33 * (side11 / 2) = newArea;
            //baseSide33 * baseSide33 +side11 * side11 = side22 * side22;

            return new Triangle(11, 11, 11);

        }

        public static explicit operator Triangle(double d)
        {
            return new Triangle(d, d, d);
        }
    }
}

