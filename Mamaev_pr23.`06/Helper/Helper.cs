using Mamaev_pr23._06.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamaev_pr23._06.Helper
{
    internal class Helper
    {
        private static Entities _context;

        public static Entities GetContext()
        {
            if (_context == null)
                _context = new Entities();

            return _context;
        }
    }
}
