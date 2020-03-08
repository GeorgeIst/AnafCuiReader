using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplicationTest01._03.Models
{
    public class CuiValidator
    {
        private CuiValidator()
        {
            throw new InvalidOperationException();
        }
        public static bool IsValid(string cui)
        {
            if (!string.IsNullOrEmpty(cui) && IsCifFormat(cui) && IsComplient(cui))
            {
                return true;
            }
            return false;
        }

        private static bool IsCifFormat(string cui)
        {
            Regex regex = new Regex(@"RO([0-9]{2,10})");
            if (regex.Match(cui).Success)
            {
                return true;
            }
            return false;
        }

        private static bool IsComplient(string cui)
        {
            long algNum = 753217532;

            long subCif = Convert.ToInt64(cui.Substring(2));

            long c1 = subCif % 10;

            long resultedCif = subCif / 10;

            long t = 0;
            while (resultedCif > 0)
            {
                t += (resultedCif % 10) * (algNum % 10);
                resultedCif = (resultedCif / 10);
                algNum = (algNum / 10);
            }

            long c2 = t * 10 % 11;

            if (c2 == 10)
            {
                c2 = 0;
            }

            if (c2 == c1)
            {
                return true;
            }

            return false;
        }
    }
      
}
