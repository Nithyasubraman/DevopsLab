using Microsoft.AspNetCore.Mvc;
using WebApiWithController.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiWithController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static List<BookingModel> bookinglist = new List<BookingModel>{ };

        // GET: api/<bookingController>
        [HttpGet]
        public IEnumerable<BookingModel> Getbookinglist()
        {
            return bookinglist;
        }

        [HttpPost]
        public IActionResult Postbookinglist(BookingModel booking)
        {
            bookinglist.Add(booking);
            return Ok(booking);
        }       
    }
}





//FROM mcr.microsoft.com / dotnet / sdk:8.0 AS build-env
//WORKDIR /App
//# Copy everything
//COPY . ./
//# Restore as distinct layers
//RUN dotnet restore
//# Build and publish a release
//RUN dotnet publish -c Release -o out
//# Build runtime image
//FROM mcr.microsoft.com/dotnet/aspnet:8.0
//WORKDIR / App
//COPY--from = build - env / App /out .
//ENTRYPOINT["dotnet", "WebApiWithController.dll"]
