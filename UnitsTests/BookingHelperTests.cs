using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SamanthasHotelTest.Dmbl;
using SamanthasHotelTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitsTests
{
    internal class BookingHelperTests
    {

        private Booking _existingBooking;
        private Mock<IBookingInterface> _repository;

        [SetUp]
        public void SetUp()
        {
            _existingBooking = new Booking
            {
                BookingId=1,
                UserID=2,
                startDate=DateTime.Now,
                endDate=DateTime.Now.AddDays(2),
                costOfBooking=120,
                CreatedOn=DateTime.Now,
                IsActiveBooking=true
            };

            _repository = new Mock<IBookingInterface>();
            _repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {
                _existingBooking

            }.AsQueryable());
        }

        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingBooking_ReturnEmptyString()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                UserID = 2,
                startDate = DateTime.Now,
                endDate = DateTime.Now.AddDays(2),
                costOfBooking = 120,
                CreatedOn = DateTime.Now,
                IsActiveBooking = true
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.Empty);
        }

        [Test]
        public void BookingStartsBeforeAndFinishesInTheMiddleOfAnExistingBooking_ReturnExistingBookingsReference()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = Before((DateTime)_existingBooking.startDate),
                endDate = After((DateTime)_existingBooking.endDate)
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.EqualTo(_existingBooking.BookingId));
        }

        [Test]
        public void BookingStartsBeforeAndFinishesAfterAnExistingBooking_ReturnExistingBookingsReference()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = Before((DateTime)_existingBooking.startDate),
                endDate = After((DateTime)_existingBooking.endDate)
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.EqualTo(_existingBooking.BookingId));
        }

        [Test]
        public void BookingStartsAndFinishesInTheMiddleOfAnExistingBooking_ReturnExistingBookingsReference()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = After((DateTime)_existingBooking.startDate),
                endDate = Before((DateTime)_existingBooking.endDate)
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.EqualTo(_existingBooking.BookingId));
        }

        [Test]
        public void BookingStartsInTheMiddleOfAnExistingBookingButFinishesAfter_ReturnExistingBookingsReference()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = After((DateTime)_existingBooking.startDate),
                endDate = After((DateTime)_existingBooking.endDate)
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.EqualTo(_existingBooking.BookingId));
        }

        [Test]
        public void BookingStartsAndFinishesAfterAnExistingBooking_ReturnEmptyString()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = After((DateTime)_existingBooking.startDate),
                endDate = After((DateTime)_existingBooking.endDate, days: 2)
            }, _repository.Object);

            NUnit.Framework.Assert.That(result, Is.Empty);
        }

        [Test]
        public void BookingsOverlapButNewBookingIsCancelled_ReturnEmptyString()
        {
            var result = BookingHelper.OverlappingBookingsExist(new Booking
            {
                BookingId = 1,
                startDate = After((DateTime)_existingBooking.startDate),
                endDate = After((DateTime)_existingBooking.endDate),
                IsActiveBooking = false
            }, _repository.Object); ;

            NUnit.Framework.Assert.That(result, Is.Empty);
        }

        private DateTime Before(DateTime dateTime, int days = 1)
        {
            return dateTime.AddDays(-days);
        }

        private DateTime After(DateTime dateTime, int days = 1)
        {
            return dateTime.AddDays(days);
        }

        private DateTime ArriveOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 14, 0, 0);
        }

        private DateTime DepartOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 10, 0, 0);
        }

    }
}
