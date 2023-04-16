namespace Restaurant.Service.Exceptions
{
    public class RestaurantException : Exception
    {
        public int Code { get; set; }

        public RestaurantException(int code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
