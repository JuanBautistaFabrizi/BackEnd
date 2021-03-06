using System.Collections.Generic;
using System.Threading.Tasks;
using Infraestructura.Dtos;
using Infraestructura.Models;

namespace Infraestructura.Services
{
    public interface IItemService
    {
         Task<List<Item>> GetAllAsync();
         

         Task<Item> CreateAsync(NewItemDTO dto, User appUser);
         
         Task< List<Item>> GetAsync(string id);

         Task DeleteAsync(long id);

         Task UpdateAsync(long id, ItemDTO dto);

         Task<Item> Find(long id);

    }
}
       

         

         