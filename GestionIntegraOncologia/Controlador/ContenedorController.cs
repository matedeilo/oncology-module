using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ContenedorController
    {
        private ContenedorDA objContenedor = null;
        public ContenedorController()
        {
            objContenedor = new ContenedorDA();
        }

        public List<ContenedorEntity> GetContenedores()
        {
            return objContenedor.GetContenedores();
        }
    }
}
