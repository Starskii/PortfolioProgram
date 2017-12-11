using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class ProjectExecutables
    {
        private string _filePath;
        private FileName _fileName;
        private string _fileDescription;

        public string FileDescription
        {
            get { return _fileDescription; }
            set { _fileDescription = value; }
        }
        public FileName FileName
        { 
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        public ProjectExecutables()
        {

        }

    }
}
