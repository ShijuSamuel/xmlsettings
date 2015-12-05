using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xmlsettings
{
    class Settings
    {
        public string SourceConnection { get; private set; }
        public string DestinationConnection { get; private set; }
        public string DestinationTable { get; private set; }
        public string PreExceute { get; private set; }
        public string PostExecute { get; private set; }

        public string Label { get; private set; }

        public string Query { get; private set; }

        public Settings (string label, string sourceconnection, 
                            string destinationconnection, string destinationtable, 
                            string preexecute, string postexecute, string query)
        {
            Label = label;
            SourceConnection = sourceconnection;
            DestinationConnection = destinationconnection;
            DestinationTable = destinationconnection;
            PreExceute = preexecute;
            PostExecute = postexecute;
            Query = query;
        }

        public override string ToString()
        {
            return Label;
        }

    }
}
