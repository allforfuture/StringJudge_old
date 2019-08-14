using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StringJudge
{
    public class Root
    {
        public Server server { get; set; }
        public Local local { get; set; }
    }

    public class Server
    {
        public string credential { get; set; }
        public string program { get; set; }
        public string folder { get; set; }
    }

    public class Local
    {
        public string program { get; set; }
        public List<string> preserveFile { get; set; }
        public List<string> preserveFolder { get; set; }
    }
}