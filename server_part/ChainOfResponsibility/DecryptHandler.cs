using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server_part.ChainOfResponsibility
{
    public class DecryptHandler: Handler
    {
        public override void handle_request(int request, ClientInfo client)
        {
            if (request == 1)   //  расшифровка
            {
                ;
            }
            else if (successor != null)
                successor.handle_request(request, client);
        }
    }
}
