namespace MvcCreditApp.Models
{
    public class Credit
    {
        // ID кредита Lab5.1(2)2
        public virtual int CreditId { get; set; }
        // Название
        public virtual string Head { get; set; }
        // Период, на который выдается кредит Lab5.1(2)2
        public virtual int Period { get; set; }
        // Максимальная сумма кредита Lab5.1(2)2
        public virtual int Sum { get; set; }
        // Процентная ставка Lab5.1(2)2
        public virtual int Procent { get; set; }
    }
}
