using System;
using Task10;



public class Program
{
    public static void Main(string[] args)
    {

    //Task1

    double[,] matrix = new double[2, 2];

    Console.WriteLine("Let's fill the matrix");

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            double x;
            var input = Console.ReadLine();
            if (input != "" || input != " ")
            {
                if (double.TryParse(input, out matrix[i, j]))
                {

                }
                else
                {
                    Console.WriteLine("Please enter valid input to cast to double");
                    j--;
                }
            }
            else
            {
                Console.WriteLine("Input can't be empty ");
                j--;
            }
        }
    }

    PrintMatrix(matrix);
    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();

    void PrintMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }


    double[,] matrix2 = new double[,] { { 1, 1 }, { 1, 1 } };
    double[,] matrix3 = new double[,] { { 1, 2, 3 }, { 1, 2, 3 } };



    void AddMatrices(double[,] matrix, double[,] matrix2)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] += matrix2[i, j];
            }
        }
    }


    void SubstractMatrices(double[,] matrix, double[,] matrix2)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] -= matrix2[i, j];
            }
        }
    }

    double[,] result = new double[matrix.GetLength(0), matrix3.GetLength(1)];
    void Multiplymatrices(double[,] matrix, double[,] matrix2)
    {
        if (matrix.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Can't multiply matrices");
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    double x = 0;
                    for (int l = 0; l < matrix.GetLength(0); l++)
                    {
                        x += matrix[i, l] * matrix2[l, j];
                    }

                    result[i, j] = x;
                }

            }
        }
    }


    void MatrixReflection(double[,] matrix)
    {
        double det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        Console.WriteLine("Determinant = " + det);
        double x = matrix[0, 0];
        matrix[0, 0] = matrix[1, 1];
        matrix[1, 1] = x;
        double y = matrix[0, 1];
        matrix[0, 1] *= matrix[1, 0] < 0 ? -1 : 1;
        matrix[1,0] *= y < 0 ? -1 : 1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] *= (1 / det); 
            }
        }

    

    }


    bool IsEqual(double[,] matrix1, double[,] matrix2)
    {
        if(matrix1.GetLength(0) != matrix2.GetLength(0))
        {
            return false;
        }
        else if(matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return false;
        }
        else
        {
            for (int i = 0;i < matrix1.GetLength(0); i++)
            {
                for (int j = 0  ; j < matrix1.GetLength(1);j++)
                {
                    if (matrix1[i,j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }


    string ToString(double[,] matrix)
    {
        string str = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j =0 ; j < matrix.GetLength(1); j++)
            {
                str += "   " + matrix[i, j];
            }
        }
        return str;
    }



    AddMatrices(matrix, matrix2);
    Console.WriteLine("Add Matrices");
    PrintMatrix(matrix);


    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();

    SubstractMatrices(matrix, matrix2);

    Console.WriteLine("Substract Matrices");
    PrintMatrix(matrix);
    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();


    Console.WriteLine("Multuply Matrices");
    Multiplymatrices(matrix, matrix3);
    PrintMatrix(result);
    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();

    Console.WriteLine("Matrix reflection");
    MatrixReflection(matrix);
    PrintMatrix(matrix);


    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();

    Console.WriteLine("Compare Matrices if they are equal:");
    Console.WriteLine(IsEqual(matrix, result));


    Console.WriteLine();
    Console.WriteLine("//////////////////");
    Console.WriteLine();

    Console.WriteLine("Show matrix converted to string");
    Console.WriteLine(ToString(matrix));

    Console.ReadLine();




// Task02

        Console.WriteLine("Enter data for the first triangle");
        double[] tr1 = new double[3];
        tr1 = GetUserInput();

        Triangle triangle1 = new Triangle(tr1[0], tr1[1], tr1[2]);
        Console.WriteLine("Area of triangle1 is " + triangle1.GetArea());
        Console.WriteLine("Perimeter of triangle1 is " + triangle1.GetPerimeter());

        Console.WriteLine("Enter data for the second triangle");
        double[] tr2 = new double[3];
        tr2 = GetUserInput();

        Triangle triangle2 = new Triangle(tr2[0], tr2[1], tr2[2]);
        Console.WriteLine("Area of triangle2 is " + triangle2.GetArea());
        Console.WriteLine("Perimeter of triangle2 is " + triangle2.GetPerimeter());
        Console.WriteLine((triangle1 == triangle2) ? "their areas are equal" : "Their Areas are not equal");


        double d;

        while (true)
        {
            Console.WriteLine("Enter the side length for the equilateral triangle: ");
            var input = Console.ReadLine();

            if (input != "")
            {
                if (double.TryParse(input, out d))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only digits");
                }
            }
            else
            {
                Console.WriteLine("Please enter number");
            }
        }

        Triangle triangle3 = (Triangle)d;
        Console.WriteLine("Area of triangle3 is " + triangle3.GetArea());
        Console.WriteLine("Perimeter of triangle3 is " + triangle3.GetPerimeter());

        Console.ReadLine();



        double[] GetUserInput()
        {
            double[] arr = new double[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                if (double.TryParse(Console.ReadLine(), out arr[i]))
                {

                }
                else
                {
                    Console.WriteLine("Please type only numbers");
                    i--;
                }
            }
            return arr;
        }
    }
}