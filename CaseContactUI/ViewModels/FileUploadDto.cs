using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.ViewModels
{
    public class FileUploadDto
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string ContainerName { get; set; }
        public string BlobName { get; set; }
        public string FileType { get; set; }

    }
}
