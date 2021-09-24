using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UsuarioModelo
    {
        public string NombreUsuario;
        public string Password;
        public bool Autenticado;


        public void Autenticar()
        {
            if (NombreUsuario == "admin" && Password == "123456")
                this.Autenticado = true;
            else
                throw new Exception("Credenciales invalidas");

        }

        public void Crear()
        {
            if (NombreUsuario == "admin" || NombreUsuario == "jperez")
                throw new Exception("El usuario ya existe");
        }


         
    }
}
