using System;

namespace VleisurePartner.Web.Infrastructure.Typescript
{
    public class TSResponseTypeAttribute : Attribute
    {
        public Type ResponseType { get; set; }

        public TSResponseTypeAttribute(Type responseType)
        {
            ResponseType = responseType;
        }
    }
}