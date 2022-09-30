using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OnlineBookStoreAPI.Data;
using OnlineBookStoreAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStoreAPI.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BookStoreContext _dbContext;
        private readonly IMapper _mapper;

        public OrderRepository(BookStoreContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<int> AddOrderAsync(OrderDTO countryDTO)
        {
            throw new NotImplementedException();

        }

        Task<int> IOrderRepository.DeleteOrderAsync(int countryId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDTO>> GetAllOrdersAsync()
        {
            var orders = await _dbContext.Orders.ToListAsync();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        Task<OrderDTO> IOrderRepository.GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<int> IOrderRepository.UpdateOrderAsync(int countryId, OrderDTO countryDTO)
        {
            throw new NotImplementedException();
        }
    }
}
