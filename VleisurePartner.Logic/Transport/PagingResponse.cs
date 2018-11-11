using System.Collections.Generic;

namespace MedHealth.Logic.Transport
{
    public class PagingResponse<TResponseType> where TResponseType : class
    {
        //Because we are using a service from User Management, it customed json serializion. So, we must flow it.
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IEnumerable<TResponseType> data { get; set; }
        public string error { get; set; }
    }
}
