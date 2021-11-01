using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using api_net5.Domain.Entities;

namespace api_net5.Infra.Interfaces 
{
	public interface IBaseRepository<T> where T : Base 
	{
		Task<T> Create(T obj);
		Task<T> Update(T obj);
		Task Remove(int id);
		Task<T> Get(int id);
		Task<List<T>> GetAll();
	}	
}

