using System.IO;
using System.Linq;

namespace RealEstate.Core.Models
{
    public class PhotoSettings
    {
        public int MaxBytes { get; set; }
        public string[] AcceptedFileTypes { get; set; }

        public bool IsSupported(string fileName)
        {
            return AcceptedFileTypes.All(type => type != Path.GetExtension(fileName).ToLower());
        }
    }
}
