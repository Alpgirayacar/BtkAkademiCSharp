using System.ComponentModel.DataAnnotations;

namespace BtjkAkademi.Services.CuponAPI.Cupon
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public double DiscountAmount { get; set; }
    }
}
