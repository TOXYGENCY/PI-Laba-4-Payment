using System.Security.Cryptography;

namespace PI_Laba_4_Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payment> PaymentList = new List<Payment>
            {
                new Payment("Agent1", 100000),
                new Payment("Agent1", 210002),
                new Payment("Agent1", 99870),
                new Payment("Agent2", 1500),
                new Payment("Agent4", 9455),
            };
            Console.WriteLine("Введите имя контрагента для вычисления общей суммы платежей: ");
            var selector = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(selector))
            {
                throw new ArgumentException("Имя должно быть указано!");
            }
            else
            {
                var LINQ = from payment in PaymentList
                           where payment.ContractorName == selector
                           select payment.PaymentAmount;
                var TotalAgentSum = LINQ.Sum();

                Console.WriteLine(TotalAgentSum);
            }
        }
    }
}