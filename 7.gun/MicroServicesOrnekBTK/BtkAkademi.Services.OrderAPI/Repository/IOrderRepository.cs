using BtkAkademi.Services.OrderAPI.Models;

namespace BtkAkademi.Services.OrderAPI.Repository
{
       {
        Task<bool> AddOrder(OrderHeader orderHeader);
    Task UpdateOrderPaymentStatus(int orderHeaderId, bool paid);
}
          
}
