using QuickBuy.Domain.ObjectValue;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public DateTime? DateForecastDelivery { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public int MethodPaymentId { get; set; }
        public MethodPayment MethodPayment { get; set; }
        public ICollection<OderItem> OderItems { get; set; }
    }
}
