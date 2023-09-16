using apiTasks.Data;
using apiTasks.Modelos;
using apiTasks.Repositorio.IRepositorio;

namespace apiTasks.Repositorio
{
    public class UserRepositorio : IUserRepositorio
    {

        private readonly ApplicationDbContext _bd;

        public UserRepositorio(ApplicationDbContext bd)
        {
            _bd = bd;
        }
        public bool ExisteUsuarioId(int idUser)
        {
            return _bd.User.Any(u => u.idUser == idUser);
        }
    }
}
