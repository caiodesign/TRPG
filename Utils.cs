using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG
{
    public static class Utils
    {
        const string EmptyString = "";

        public static string GetDescription(string job, string HeadTitle = EmptyString)
        {
            if (HeadTitle != string.Empty)
            {
                return String.Join(Environment.NewLine, HeadTitle, job);
            }

            return job;
        }
    }
}
