using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sevillaMath;
using SQLite;

namespace sevillaMath
{
    public class BDService
    {
        private readonly SQLiteAsyncConnection _database;

        public BDService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<BDUsuario>().Wait();
        }

        public Task<int> GuardarUsuarioAsync(BDUsuario usuario)
        {
            return _database.InsertAsync(usuario);
        }

        public Task<List<BDUsuario>> ObtenerUsuariosAsync()
        {
            return _database.Table<BDUsuario>().ToListAsync();
        }

        public Task<BDUsuario> ObtenerUsuarioAsync(string nombreUsuario)
        {
            return _database.Table<BDUsuario>()
                            .Where(u => u.NombreUsuario == nombreUsuario)
                            .FirstOrDefaultAsync();
        }
    }
}
