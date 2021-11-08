using API.Dtos;
using AutoMapper;
using Core.Entities.OrderAggregate;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class OrderItemUrlResolver : IValueResolver<OrderItem, ItemDto, string> 
    {
        private readonly IConfiguration config;

        public OrderItemUrlResolver(IConfiguration config)
        {
            this.config = config;
        }

        public string Resolve(OrderItem source, ItemDto destination, string destMember, ResolutionContext context)
        {
            if(string.IsNullOrEmpty(source.ItemOrdered.ProductUrl))
            {
                return config["ApiUrl"] + source.ItemOrdered.ProductUrl;
            }
            return null;
        }
    }
}
