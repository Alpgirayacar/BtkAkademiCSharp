﻿using Dapper;
using DapperOrnekBTK.Domain;
using DapperOrnekBTK.Domain.Repository;
using System.Data.SqlClient;

namespace DapperOrnekBTK.Infrastructure
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly string _connectionString = "Server=(localdb)\\okul;Database=TodoDapperBTK;Trusted_Connection=true";

        public async Task<List<TodoItem>> GetListAsync()
        {
            await using var connection = new SqlConnection(_connectionString);

            return (await connection.QueryAsync<TodoItem>("SELECT * FROM dbo.TodoItems"))
                .AsList();
        }

        public async Task<TodoItem> GetAsync(Guid id)
        {
            await using var connection = new SqlConnection(_connectionString);
            return await connection.QueryFirstAsync<TodoItem>($"SELECT * FROM dbo.TodoItems WHERE = '{id}'");
        }

        public async Task<TodoItem> InsertAsync(TodoItem todoItem)
        {
            await using var connection = new SqlConnection(_connectionString);
            var query = $"INSERT INTO dbo.TodoItems VALUES ('{todoItem.Id}', '{todoItem.Title}', '{todoItem.Description}', {(int)todoItem.Status})";
            await connection.ExecuteAsync(query);
            return todoItem;
        }

        public async Task<TodoItem> UpdateAsync(Guid id, TodoItem todoItem)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync($"UPDATE dbo.TodoItems SET {nameof(TodoItem.Title)} = '{todoItem.Title}', {nameof(TodoItem.Description)} = '{todoItem.Description}', {nameof(TodoItem.Status)} = {(int)todoItem.Status} WHERE Id = '{id}'");
            return todoItem;
        }

        public async Task DeleteAsync(Guid id)
        {
            await using var connection = new SqlConnection(_connectionString);
            await connection.ExecuteAsync($"DELETE FROM dbo.TodoItems WHERE Id = '{id}'");
        }
    }
}