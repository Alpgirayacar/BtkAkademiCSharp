using BtjkAkademi.Services.CuponAPI.Cupon.Dto;

namespace BtjkAkademi.Services.CuponAPI.Repository
{
             public interface ICouponRepository
    {
        Task<CouponDto> GetCouponByCode(string couponCode);
    }
          
}
