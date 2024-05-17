namespace PI_Laba_4_Payment
{
    public class Payment
    {
        public string ContractorName { get; protected set; }
        public int PaymentAmount { get; protected set; }

        public Payment(string? name, int amount)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя должно быть указано!");
            }
            else
            {
                ContractorName = name;
                PaymentAmount = amount;
            }
        }

    }
}
