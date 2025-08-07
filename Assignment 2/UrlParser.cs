using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class UrlParser
    {
        public static void ParseUrl()
        {
            // read input URL
            string url = Console.ReadLine();

            // initialize parts
            string protocol = "";
            string server;
            string resource = "";

            // 1. extract protocol
            int protocolEnd = url.IndexOf("://");
            string remainder;
            if (protocolEnd != -1)
            {
                // protocol is text before "://"
                protocol = url.Substring(0, protocolEnd);
                // remainder is after "://"
                remainder = url.Substring(protocolEnd + 3);
            }
            else
            {
                // no protocol marker
                remainder = url;
            }

            // 2. extract server and resource
            int resourceStart = remainder.IndexOf('/');
            if (resourceStart != -1)
            {
                // server is text before first "/"
                server = remainder.Substring(0, resourceStart);
                // resource is text after "/"
                resource = remainder.Substring(resourceStart + 1);
            }
            else
            {
                // no resource part
                server = remainder;
            }

            // output results
            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server]   = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}
