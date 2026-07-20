using System;

namespace Exercise
{
    public interface ITransaction
        {
            void Process();
            void GenerateReceipt();
        }
}