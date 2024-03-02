namespace WebApiWithController.Models
{
    public class BookingModel
    {
        public int Id { get; set; }

        public string? CarNo { get; set; }

        public string? DateOfBooking { get; set; }

        public string? FromLocation { get; set; }

        public string? ToLocation { get; set; }

        public string? CustomerName { get; set; }

        public string? MobileNumber { get; set; }
    }
}
