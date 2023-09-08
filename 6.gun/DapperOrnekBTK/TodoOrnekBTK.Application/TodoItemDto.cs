using DapperOrnekBTK.Domain;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TodoOrnekBTK.Application
{
    public class TodoItemDto
    {
        public Guid Id { get; set; }

        [Required]
        [NotNull]
        public string Title { get; set; }

        [Required]
        [NotNull]
        public string Description { get; set; }

        public TodoStatus Status { get; set; }
    }

}