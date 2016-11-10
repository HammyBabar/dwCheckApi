using dwCheckApi.Models;
using System.Collections.Generic;

namespace dwCheckApi.Services 
{
    public interface IBookService
    {
        // Search and Get
        Book FindById(int id);
        IEnumerable<Book> Search(string searchKey);
        IEnumerable<Book> GetAll();

        // Create and Update
        void AddOrUpdate(Book item);

        // Update
        void Update(Book item);

        // Delete
        void Remove(int id);
    }
}
