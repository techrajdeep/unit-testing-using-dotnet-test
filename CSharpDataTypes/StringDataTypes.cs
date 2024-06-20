using System;

namespace CSharpDataType
{
    public class StringDataTypes
    {
        public string nickName{get; set;}
        public string fullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

    }
}

