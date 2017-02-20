using DataAccess;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{
    public class ProtocoloController
    {
        private ProtocoloDA objProtocolo = null;
        public ProtocoloController()
        {
            objProtocolo = new ProtocoloDA();
        }

        public Protocolo FindbyID(int id)
        {
            return objProtocolo.FindbyID(id);
        }

    }
}
