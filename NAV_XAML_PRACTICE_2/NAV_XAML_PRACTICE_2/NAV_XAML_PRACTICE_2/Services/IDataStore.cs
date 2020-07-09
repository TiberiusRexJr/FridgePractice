using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace NAV_XAML_PRACTICE_2.Services
{
    public interface IDataStore
    {
        //c
        Task<bool> AsyncSaveDataItem(T item);
        
        //r
        Task<bool> AsyncGetDataItem(String id);
        //u
        Task<bool> AsyncUpdateDataItem(T item);
        //d
        Task<bool> AsyncDeleteDataItem(String id);

        //r multiple
        Task<IEnumerable<T>> AsyncGetDataItems(bool forceRefresh=false);
    }
}