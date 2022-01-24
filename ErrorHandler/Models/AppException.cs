using System.Net;

namespace UsuarioAPI.Models
{
    public class AppException : Exception
    {
        public int? StatusCode { get; set; }





        public AppException() : base() { }

        public AppException(string message) : base(message) { }

        public AppException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = (int)statusCode;
        }

        public AppException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
