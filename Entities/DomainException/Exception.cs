using System;

namespace Conta_Excecoes.Entities.DomainException
{
    class Exception : ApplicationException
    {
        public Exception(string message) : base (message)
        {
        }
    }
}
