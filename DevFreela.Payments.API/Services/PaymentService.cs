using DevFreela.Payments.API.Models;

namespace DevFreela.Payments.API.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
            return await Task.FromResult(true);
        }
    }
}