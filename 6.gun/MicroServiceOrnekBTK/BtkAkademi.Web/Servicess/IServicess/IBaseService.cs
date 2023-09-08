using BtkAkademi.Web.Models;

namespace BtkAkademi.Web.Servicess.IServicess
{

    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
