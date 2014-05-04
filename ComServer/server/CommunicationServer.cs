using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace server
{
    class CommunicationServer
    {
        private static CommunicationServer instance = null;

        private CommunicationServer()
        {
        }

        public static CommunicationServer getInstance()
        {
            if (instance == null)
            {
                instance = new CommunicationServer();
            }

            return instance;
        } 
        ser
    }
}
