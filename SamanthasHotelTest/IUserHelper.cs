using SamanthasHotelTest.Dmbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SamanthasHotelTest.BookingHelper;
using static SamanthasHotelTest.UserRepository;

namespace SamanthasHotelTest
{
    internal interface IUserHelper
    {
        IQueryable<User> InserUser(int? ExistingIdNumber);
    }

    public class UserRepository : IUserHelper
    {
        public UserRepository()
        {
        }

        public IQueryable<Booking> InserUser(int ExistingIdNumber)
        {
            var unitOfWork = new UnitOfWork();
            var UsersExistsByIdn =
                unitOfWork.Query<User>()
                    .Where(
                        b => b.Idnumber == ExistingIdNumber.ToString());

            if (!String.IsNullOrEmpty(UsersExistsByIdn.ToString()))
            {

            }
              //  bookings = bookings.Where(b => b.Id != excludedBookingId.Value);
            return (IQueryable<Booking>)UsersExistsByIdn;
        }

        IQueryable<User> IUserHelper.InserUser(int? ExistingIdNumber)
        {
            throw new NotImplementedException();
        }
    }
}
