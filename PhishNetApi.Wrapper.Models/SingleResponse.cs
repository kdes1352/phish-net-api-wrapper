namespace PhishNetApi.Wrapper.Models
{
    public class SingleResponse<T> where T : ISingleData
    {
        public int Count { get; set; }

        public T Data { get; set; }
    }
}