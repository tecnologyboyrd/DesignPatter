using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.FileGenerator
{
    public class FileDirector
    {
        private IFileGenerator _fileGenerator;

        public FileDirector(IFileGenerator fileGenerator)
        {
            SetFileGenerator(fileGenerator);
        }

        public void SetFileGenerator(IFileGenerator fileGenerator)=> _fileGenerator = fileGenerator;

        public void GenerateSimpleJsonFile(List<string> content, string path)
        {
            _fileGenerator.Reset();
            _fileGenerator.SetContent(content);
            _fileGenerator.SetPath(path);
            _fileGenerator.SetFormat(TypeFormat.Json);           
        }

        public void GenerateSimplePipesFile(List<string> content, string path)
        {
            _fileGenerator.Reset();
            _fileGenerator.SetContent(content);
            _fileGenerator.SetPath(path);
            _fileGenerator.SetFormat(TypeFormat.Pipes);
            _fileGenerator.SetCharacter(TypeCharacter.Uppercase);
        }


    }
}
