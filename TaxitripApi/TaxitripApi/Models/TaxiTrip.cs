using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxitripApi.Models
{
    public class TaxiTrip
    {
        public int vendor_id { get; set; } 
        public DateTime tpep_pickup_datetime { get; set; }
        public DateTime tpep_dropoff_datetime { get; set; }
        public int passenger_count { get; set; }
        public decimal trip_distance { get; set; }
        public string pickup_longitude { get; set; }
        public string pickup_latitude { get; set; }
        public int rate_code_id { get; set; }
        public char store_and_fwd_flag { get; set; }
        public string dropoff_longitude { get; set; }
        public string dropoff_latitude { get; set; }
        public decimal payment_type { get; set; }
        public decimal fare_amount { get; set; }
        public decimal extra { get; set; }
        public decimal mta_tax { get; set; }
        public decimal tip_amount { get; set; }
        public decimal tolls_amount { get; set; }
        public decimal improvement_surcharge { get; set; }
        public decimal total_amount { get; set; }
    }
}
