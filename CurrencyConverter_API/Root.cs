using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CurrencyConverter_API.MainWindow;

namespace CurrencyConverter_API
{
    public class Root
    {
        public Rate rates { get; set; }
        public long timestamp;
        public string license;
    }
}
