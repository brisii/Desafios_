using System;
using System.Runtime.Serialization;

class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Restar(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public double Dividir(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByceroException("No se puede dividir por cero.");
        }
        return (double)num1 / num2;
    }
}

[Serializable]
internal class DivideByceroException : Exception
{
    public DivideByceroException()
    {
    }

    public DivideByceroException(string message) : base(message)
    {
    }

    public DivideByceroException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected DivideByceroException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
