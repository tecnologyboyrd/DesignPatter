using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.FileGenerator
{
    public class FileGeneratorBuilder : IFileGenerator
    {
        private FileGenerator _fileGenerator;

        public FileGeneratorBuilder() => Reset();

        public void Reset()=> _fileGenerator = new FileGenerator();

        public void SetCharacter(TypeCharacter character) => _fileGenerator.Character = character;

        public void SetContent(List<string> content) => _fileGenerator.Content = content;

        public void SetFormat(TypeFormat format) => _fileGenerator.Format = format;

        public void SetPath(string path) => _fileGenerator.Path = path;

        public FileGenerator GetFileGenerator() => _fileGenerator;
    }
}
