using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SamanthasHotelTest.BookingHelper;

namespace SamanthasHotelTest
{
    public interface IBookingInterface
    {
        IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null);
    }


    public class BookingRepository : IBookingInterface
    {
        public IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null)
        {
            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.IsActiveBooking == false);

            return bookings;
        }
    }
}




//namespace TestNinja.Mocking
//{
//    public interface IBookingRepository
//    {
//        IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null);
//    }

//    public class BookingRepository : IBookingRepository
//    {
//        public IQueryable<Booking> GetActiveBookings(int? excludedBookingId = null)
//        {
//            var unitOfWork = new UnitOfWork();
//            var bookings =
//                unitOfWork.Query<Booking>()
//                    .Where(
//                        b => b.Status != "Cancelled");

//            if (excludedBookingId.HasValue)
//                bookings = bookings.Where(b => b.Id != excludedBookingId.Value);

//            return bookings;
//        }
//    }
//}