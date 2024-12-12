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
            _database.CreateTableAsync<FormularioIntento>().Wait();
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

        public async Task<BDUsuario> ObtenerUsuarioPorNombreAsync(string nombreUsuario)
        {
            return await _database.Table<BDUsuario>()
                                  .Where(u => u.NombreUsuario == nombreUsuario)
                                  .FirstOrDefaultAsync();
        }

        public async Task GuardarIntentoAsync(FormularioIntento intento)
        {
            var existente = await _database.Table<FormularioIntento>()
                                            .FirstOrDefaultAsync(i => i.NombreUsuario == intento.NombreUsuario && i.TemaId == intento.TemaId);

            if (existente == null)
            {
                await _database.InsertAsync(intento);
            }
            else
            {
                existente.NumeroIntentos++;
                existente.FechaIntento = DateTime.Now;
                existente.Puntuacion = intento.Puntuacion;
                existente.PasoFormulario = intento.Puntuacion >= 60;
                await _database.UpdateAsync(existente);
            }

        }

        public async Task<FormularioIntento> ObtenerIntentoPorUsuarioYTemaAsync(string nombreUsuario, int temaId)
        {
            return await _database.Table<FormularioIntento>()
                                  .FirstOrDefaultAsync(i => i.NombreUsuario == nombreUsuario && i.TemaId == temaId);
        }

        public async Task<List<FormularioIntento>> ObtenerIntentosPorUsuarioAsync(string nombreUsuario)
        {
            return await _database.Table<FormularioIntento>()
                                  .Where(i => i.NombreUsuario == nombreUsuario)
                                  .ToListAsync();
        }
    }
}