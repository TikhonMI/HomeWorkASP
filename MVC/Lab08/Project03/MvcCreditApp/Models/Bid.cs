using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Bid
    {
        // ID заявки Lab5.1(2)4
        public virtual int BidId { get; set; }
        // Имя заявителя Lab5.1(2)4
        //
        [DisplayName("Имя заявителя")]
        //
        public virtual string Name { get; set; }
        // Название кредита Lab5.1(2)4
        //
        [DisplayName("Название кредита")]
        //
        public virtual string CreditHead { get; set; }
        // Дата подачи заявки Lab5.1(2)4
        //
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        //
        public virtual DateTime bidDate { get; set; }
    }
}
