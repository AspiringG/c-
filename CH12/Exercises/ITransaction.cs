using System;

namespace Exercises
{
    public interface ITransaction
        {
            void Process();
            void GenerateReceipt();
        }
}