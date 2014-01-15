using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eiKanji
{
    static class IProc
    {
        static SearchView sv;

        public static SearchView Sv
        {
            get { return IProc.sv; }
            set { IProc.sv = value; }
        }

        public static void Activate(string key)
        {
            sv.SetKey(key);
        }
    }
}
