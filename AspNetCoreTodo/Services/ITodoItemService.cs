using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models; // This is used to reference the Todo class in models.

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}