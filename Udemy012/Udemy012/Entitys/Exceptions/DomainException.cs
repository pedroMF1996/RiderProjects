using System;

namespace Udemy012.Entitys.Exceptions
{
    public class DomainException:ApplicationException
    {
        public DomainException(string msg):base(msg){}
    }
}