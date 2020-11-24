namespace PhishNetApi.Wrapper.Models
{
    using System.Collections.Generic;

    public class Response<T> where T : IData
    {
        public int Count { get; set; }

        public List<T> Data { get; set; }
    }
}