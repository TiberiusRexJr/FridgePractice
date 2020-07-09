using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks
using NAV_XAML_PRACTICE_2.Models;
/* other usings */
namespace NAV_XAML_PRACTICE_2.Services
{
    public class MockDataStore:IDataStore<Item>
    {
            readonly List<Item> items;

        public MockDataStore()
        {
            items=new List<Item>()
            {
                new Item{Id=new Guid.NewGuid().ToString(),Text="This is the first item",Description="Description"},
                
            }
        

        }
    }
    public async Task<bool> AddItemAsync(Item item)
    {
        items.Add(item);
        return await Task.FromResult(true);
    }
    public async Task<bool> UpdateItemAsync(Item item)
    {
        var oldItem=items.Where((Item arg)=>arg.Id==item.Id).FirstOrDefault();
        items.Remove(oldItem);
        items.Add(item);
        return await Task.FromResult(true);
    }
    public async Task<bool> DeleteAsync(string id)
    {
        var searchResult=items.Where((items arg)=>arg.id==id).FirstOrDefault();
        items.Remove(searchResult);
        return await Task.FromResult(true);
    }
    public async Task<IEnumerable<Item>> GetitemsAsync(bool forceRefresh=false)
    {
        /* List<IEnumerable> returnItemList=new List<IEnumerable>();
        foreach (var item in items)
        {
            returnItemList.Add(item);
        }
        return await Task<returnItemList>; */
        return await Task.FromResult(items);

    }
    public async Task<bool> GetAsyncItem(string id)
    {
        return Task.FromResult(items.FirstOrDefault(s=>s.id==id));
    }
}