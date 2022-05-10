using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class RecordFileHelper
    {

        public static string GetRelativeFilePath(string fileName)
        {
            var filePath = $"../../../Data/{fileName}";

            return filePath;

        }
    }
}
