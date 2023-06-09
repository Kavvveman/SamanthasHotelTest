using SamanthasHotelTest.Dmbl;
using SamanthasHotelTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsTests
{
    internal class UserHelperTests
    {
        //public static string User()
        //{

        //}
        
        //public static string OverlappingBookingsExist(Booking booking, IBookingInterface repository)
        //{
        //    if (booking.IsActiveBooking == true)
        //        return string.Empty;

        //    var bookings = repository.GetActiveBookings(booking.BookingId);
        //    var overlappingBooking =
        //        bookings.FirstOrDefault(
        //            b =>
        //                booking.startDate < b.endDate &&
        //                b.endDate < booking.startDate);

        //    return overlappingBooking == null ? string.Empty : overlappingBooking.BookingId.ToString();
        //}

        //public interface IUnitOfWork
        //{
        //    IQueryable<T> Query<T>();
        //}

        //public class UnitOfWork : IUnitOfWork
        //{
        //    public IQueryable<T> Query<T>()
        //    {
        //        return new List<T>().AsQueryable();
        //    }
        //}
    }
}
