using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tarea6_7.Data;

namespace Tarea6_7.Servicios
{
    public interface IServicioTesoros
    {
        Task<List<Tesoros>> GetAllTesoros (Guid UsuarioId);
        Task<Tesoros> GetTesoros(Guid Tid);
        Task<bool> SetTesoros (Tesoros T);
        Task<Coordenadas> GetCoordenadas (Guid Tid);
        Task<List<Coordenadas>> GetAllCoordenadas (Guid UsuarioId);
    }

    public class ServicioTesoros : IServicioTesoros
    {

        private readonly ApplicationDbContext db ;
        public ServicioTesoros(ApplicationDbContext _dbContext){
            db = _dbContext;
        }
        public Task<List<Coordenadas>> GetAllCoordenadas(Guid UsuarioId)
        {
            List<Coordenadas> coordenadas = db.Coordenadas
            .Where( c => c.UsuarioId.Equals(UsuarioId)).ToList<Coordenadas>();
            return Task.FromResult(coordenadas);
        }

        public async Task<List<Tesoros>> GetAllTesoros(Guid _UsuarioId)
        {
            List<Tesoros> tesoros = await db.Tesoros
            .Where( t => t.UsuarioId.Equals(_UsuarioId))
            .ToListAsync<Tesoros>();
            return await Task.FromResult(tesoros);
        }

        public Task<Coordenadas> GetCoordenadas(Guid Tid)
        {
            Coordenadas coordenadas = db.Coordenadas
            .Where( c => c.Tid.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(coordenadas);
        }

        public Task<Tesoros> GetTesoros(Guid Tid)
        {
            Tesoros tesoros = db.Tesoros
            .Where( t => t.Id.Equals(Tid)).FirstOrDefault();
            return Task.FromResult(tesoros);
        }

        public Task<bool> SetTesoros(Tesoros T)
        {
            bool status = false;
            try{
                db.Tesoros.Add(T);
                db.SaveChanges();
                status = true;
            }catch(Exception e)
            {
                status = false;
                Console.WriteLine(e.Message);
            }
            return Task.FromResult(status);
        }
    }
}