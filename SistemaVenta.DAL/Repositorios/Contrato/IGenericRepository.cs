using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SistemaVenta.DAL.Repositorios.Contrato
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        //metodos que van a trabajar con nuestros modelos CRUD

        //trabajar de manera asincrona
        //esto es para obtener un modelo
        Task<TModel> Obtener(Expression<Func<TModel, bool>> filtro);
        //recibir un nuevo modelo para crear
        Task<TModel> Crear(TModel modelo);

        Task<bool> Editar(TModel modelo);
        Task<bool> Eliminar(TModel modelo);
        //devuelve la consulta del modelo
        Task<IQueryable<TModel>> Consultar(Expression<Func<TModel, bool>> filtro = null);


    }
}
