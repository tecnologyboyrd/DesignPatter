using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tools.FileGenerator
{
    public class FileGenerator
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }

        public void Save()
        {
            string result = string.Empty;

            result = Format == TypeFormat.Json ? GetJson() : GetPipes();

            if (Character == TypeCharacter.Lowercase) result = result.ToLower();

            if (Character == TypeCharacter.Uppercase) result = result.ToUpper();

            File.WriteAllText(Path,result);
        }

        private string GetJson() => JsonSerializer.Serialize(Content);

        private string GetPipes() => Content.Aggregate((stg, cur) => stg + "|" + cur);

    }
}
