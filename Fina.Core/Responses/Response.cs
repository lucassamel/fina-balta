using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        private int _code = 200;

        public Response()
        {
            
        }
        public Response(TData? data, int code = 200, string? message = null)
        {
            
        }

        public TData? Data { get; set; }

        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}
