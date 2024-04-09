using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netcore.Abstraction.StaticParams
{
    public static class StaticParams
    {
        public static string Secret
        {
            get;
            set;
        } = string.Empty;

        public static string Environment
        {
            get;
            set;
        } = string.Empty;

    }
}