using Npgsql;
using Dapper;

public class ListService
{
    private string _connectionString = "Server=127.0.0.1;Port=5432;Database=List;User Id=postgres;Password=sqlj123;";
    public List<GetListDto> GetLists()
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM TodoLists";
            var result = conn.Query<GetListDto>(sql).ToList();
            return result;
        }
    }

    public int AddList(ListDto list)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            string sql = $"INSERT INTO TodoLists (TaskName, Status) Values ('{list.TaskName}', '{(int)list.Status}')";
            var result = conn.Execute(sql);
            return result;
        }
    }

    public int UpdateList(ListDto list)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            string sql = $"UPDATE TodoLists Set TaskName = '{list.TaskName}', Status = '{list.Status}' Where id = {list.id}";
            var result = conn.Execute(sql);
            return result;
        }
    }
    
     public int DeleteList(int id)
    {
        using (var conn = new NpgsqlConnection(_connectionString))
        {
            var sql = $"Delete from TodoLists Where id = {id}";
            var result = conn.Execute(sql);
            return result;
        }
    }
}

