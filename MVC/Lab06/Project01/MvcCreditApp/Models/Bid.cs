namespace MvcCreditApp.Models
{
    public class Bid
    {
        // ID заявки Lab5.1(2)4
        public virtual int BidId { get; set; }
        // Имя заявителя Lab5.1(2)4
        public virtual string Name { get; set; }
        // Название кредита Lab5.1(2)4
        public virtual string CreditHead { get; set; }
        // Дата подачи заявки Lab5.1(2)4
        public virtual DateTime bidDate { get; set; }
    }
}
