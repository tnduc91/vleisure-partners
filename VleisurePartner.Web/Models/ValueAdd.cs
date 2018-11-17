using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VleisurePartner.Web.Infrastructure.Typescript;
namespace VleisurePartner.Web.Models
{
    public class ValueAdd : ITypeProxy
    {
        public int Id { get; set; }
        public int Description { get; set; }
    }
}