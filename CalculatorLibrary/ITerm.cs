using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public interface ITerm
    {
        object Value { get; set; }
        TermValueType ValueType { get; set; }
    }
}