using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tools.FileGenerator
{
    public enum TypeFormat
    {
        Json,
        Pipes
    }

    public enum TypeCharacter
    {
        Normal,
        Uppercase,
        Lowercase
    }
    public interface IFileGenerator
    {
        public void Reset();
        public void SetContent(List<string> content);
        public void SetPath(string path);
        public void SetFormat(TypeFormat format);
        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal);


    }
}
