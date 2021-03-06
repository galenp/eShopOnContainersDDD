﻿using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commands;
using Infrastructure.ServiceStack;
using ServiceStack;

namespace eShop.Ordering.Order.Services
{
    [Api("Ordering")]
    [Route("/order", "POST")]
    public class DraftOrder : DomainCommand
    {
        public Guid OrderId { get; set; }
        
        public Guid BasketId { get; set; }

        public Guid BillingAddressId { get; set; }
        public Guid ShippingAddressId { get; set; }
        public Guid PaymentMethodId { get; set; }
    }
}
