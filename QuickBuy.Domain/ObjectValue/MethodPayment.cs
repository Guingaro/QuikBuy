using QuickBuy.Domain.Enuns;

namespace QuickBuy.Domain.ObjectValue
{
    public class MethodPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsUndefined { get { return Id == (int)MethodPaymentEnum.Undefined;  } }
        public bool IsBillet { get { return Id == (int)MethodPaymentEnum.Billet;  } }
        public bool IsCredtCart { get { return Id == (int)MethodPaymentEnum.CredtCard;  } }
        public bool IsDeposit { get { return Id == (int)MethodPaymentEnum.Deposit;  } }
    }
}
