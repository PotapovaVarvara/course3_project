using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class DicomFileNamingHelper
    {

        public static string GetDicomFileNameWithExt(Guid dicomFileId)
        {
            var imageName = $"img_{dicomFileId}.DCM";

            return imageName;
        }
    }
}
