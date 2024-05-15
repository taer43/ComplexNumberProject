using System;

public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Перегрузка оператора сложения
    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Перегрузка оператора вычитания
    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Перегрузка оператора умножения
    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
        double imaginaryPart = c1.Real * c2.Imaginary + c2.Real * c1.Imaginary;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    // Перегрузка оператора деления
    public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
    {
        double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        double realPart = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator;
        double imaginaryPart = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    // Перегрузка оператора сравнения 
    public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
    {
        return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
    }

    public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
    {
        return !(c1 == c2);
    }

    // Метод преобразования в строку
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }

    // Статический метод для получения комплексного числа из строки
    public static ComplexNumber Parse(string input)
    {
        string[] parts = input.Split('+', 'i');
        double real = double.Parse(parts[0]);
        double imaginary = double.Parse(parts[1]);
        return new ComplexNumber(real, imaginary);
    }
}

