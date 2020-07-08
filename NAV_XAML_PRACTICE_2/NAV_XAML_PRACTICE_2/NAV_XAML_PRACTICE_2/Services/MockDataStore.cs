using System;
using System.Collections.Generic;

namespace NAV_XAML_PRACTICE_2.Services
{
    public class MockDataStore:IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
            {
                    items=new List<Item>()
                    {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item{ Id=Guid.NewGuid().ToString(),Text="Second Item", Description="This is another item"},


                    };
            }
            public async Task<bool> AddItemAsync(Item item)
            {
                items.Add(item);
                return await Task.FromResult(true);
            }
        

    }
}