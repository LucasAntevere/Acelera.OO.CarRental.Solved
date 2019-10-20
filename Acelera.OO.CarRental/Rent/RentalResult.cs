using System.Collections.Generic;

namespace Acelera.OO.CarRental.Rent
{
    public class RentalResult
    {
        public RentalResult()
        {
            RentResults = new List<RentResult>();
        }

        public List<RentResult> RentResults { get; set; }
    }
}
