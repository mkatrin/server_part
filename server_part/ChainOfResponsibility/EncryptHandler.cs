using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace server_part.ChainOfResponsibility
{
    public class EncryptHandler: Handler
    {
        public override void handle_request(int request, ClientInfo client)
        {
            if (request == 3)   //  зашифровка
            {
                ;
            }
            else if (successor != null)
                successor.handle_request(request, client);
        }
    }
}
