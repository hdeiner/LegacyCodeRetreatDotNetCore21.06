using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Messenger
{
    public class Message
    {
        public String configFileName;

        public Message(String configFileName)
        {
            this.configFileName = configFileName;
        }

        public String GetConfigProperty(String name)
        {
            String value = null;

            Regex matchPropertyName = new Regex(@"^(" + name + @"\=)(.*)$");

            String line = "";
            FileStream fileStream = new FileStream(configFileName, FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                do
                {
                    line = reader.ReadLine();
                    Match match = matchPropertyName.Match(line);
                    if (match.Success)
                    {
                        value = match.Groups[2].Value;
                    }
                } while ((line != null) && (value == null));
            }
            return value;
        }
    }

}