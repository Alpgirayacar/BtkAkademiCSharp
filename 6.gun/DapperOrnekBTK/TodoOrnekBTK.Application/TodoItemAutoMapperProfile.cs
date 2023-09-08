using AutoMapper;
using DapperOrnekBTK.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoOrnekBTK.Application;

namespace DapperOrnekBTK.Application
{
    public class TodoItemAutoMapperProfile : Profile
    {
        public TodoItemAutoMapperProfile()
        {
            CreateMap<TodoItem, TodoItemDto>();

            CreateMap<CreateUpdateTodoItemDto, TodoItem>();
        }
    }
}
