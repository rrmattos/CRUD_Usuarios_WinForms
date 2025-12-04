using CadastroUsuarioSimples.Models;
using CadastroUsuarioSimples.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarioSimples.Database
{
    public class UserRepository
    {
        private IDbConnection conn => AppState.Connection;

        public PageResult<User> Search(string filter, int page, int pageSize)
        {
            bool isMySql = conn.GetType().Name.Contains("MySql");

            string like = $"%{filter}%";
            int offset = (page - 1) * pageSize;

            string sqlCount = @"
                SELECT COUNT(*) FROM Users
                WHERE Nome LIKE @like
                OR Sobrenome LIKE @like
                OR Telefone LIKE @like
                OR Email LIKE @like;
            ";

            string sqlPage = isMySql 
                ? @"SELECT * FROM Users
                    WHERE Nome LIKE @like
                    OR Sobrenome LIKE @like
                    OR Telefone LIKE @like
                    OR Email LIKE @like
                    ORDER BY Nome ASC
                    LIMIT @offset, @pageSize;"
                : @"SELECT * FROM Users
                    WHERE Nome LIKE @like
                    OR Sobrenome LIKE @like
                    OR Telefone LIKE @like
                    OR Email LIKE @like
                    ORDER BY Nome ASC
                    LIMIT @pageSize OFFSET @offset;";

            int total = conn.ExecuteScalar<int>(sqlCount, new { like });

            var items = conn.Query<User>(
                sqlPage,
                new { like, offset, pageSize }
            );

            return new PageResult<User>
            {
                TotalItems = total,
                Page = page,
                PageSize = pageSize,
                Data = items.ToList()
            };
        }

        public Task<User> GetById(int id)
        {
            return conn.QueryFirstOrDefaultAsync<User>(
                "SELECT * FROM Users WHERE Id = @id",
                new { id }
            );
        }

        public async Task<bool> Insert(User user)
        {
            string sql = @"
            INSERT INTO Users
            (Nome, Sobrenome, Telefone, Email, Profissao, Endereco, DataCadastro)
            VALUES
            (@Nome, @Sobrenome, @Telefone, @Email, @Profissao, @Endereco, @DataCadastro);";

            return await conn.ExecuteAsync(sql, user) > 0;
        }

        public async Task<bool> Update(User user)
        {
            string sql = @"
            UPDATE Users SET
                Nome = @Nome,
                Sobrenome = @Sobrenome,
                Telefone = @Telefone,
                Email = @Email,
                Profissao = @Profissao,
                Endereco = @Endereco
            WHERE Id = @Id";

            return await conn.ExecuteAsync(sql, user) > 0;
        }

        public Task<bool> Delete(int id)
        {
            string sql = "DELETE FROM Users WHERE Id = @id";
            return conn.ExecuteAsync(sql, new { id }).ContinueWith(r => r.Result > 0);
        }
    }
}
