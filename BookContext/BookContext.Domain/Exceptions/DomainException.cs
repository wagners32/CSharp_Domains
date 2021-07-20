using System;
using System.Runtime.Serialization;

namespace BookContext.Domain.Exceptions
{
    [Serializable]
    public class DomainException : Exception
    {
        public DomainException(string mensagem) : base(mensagem)
        {
            
        }

        public DomainException() : base()
        {
            
        }

        protected DomainException(SerializationInfo info, StreamingContext context ) : base(info, context)
        {
            
        }
        
    }
}