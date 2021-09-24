using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UsuarioController
    {
        public void CrearUsuario(string usuario, string password)
        {
            UsuarioModelo u = new UsuarioModelo();

            if(u.Autenticado == true){
                u.NombreUsuario = usuario;
                u.Password = password;
                u.Crear();
            }
        }
    }
}
