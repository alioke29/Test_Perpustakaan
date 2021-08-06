using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace TestPerpustakaan_VS2019.Library.Utilities
{

    public class PasswordGeneratorV1
    {
        private string _elementTemplate = "(?=(?:.*?({type})){({count})})";

        private Dictionary<string, string> _elements = new Dictionary<string, string> {
            { "uppercase", "[A-Z]" },
            { "lowercase", "[a-z]" },
            { "number", @"\d" },
            { "special", @"\W" },
            { "alphanumeric", @"\w" }
        };

        private StringBuilder _sb = new StringBuilder();

        private string Construct(string what, int min, int max)
        {
            StringBuilder sb = new StringBuilder(_elementTemplate);
            string count = min.ToString();

            if (max == -1)
            {
                count += ",";
            }
            else if (max > 0)
            {
                count += "," + max.ToString();
            }

            return sb
                .Replace("({type})", what)
                .Replace("({count})", count)
                .ToString();
        }

        public PasswordGeneratorV1 ChangeRegexTemplate(string newTemplate)
        {
            _elementTemplate = newTemplate;
            return this;
        }

        public PasswordGeneratorV1 ChangeRegexElements(string name, string regex)
        {
            if (_elements.ContainsKey(name))
            {
                _elements[name] = regex;
            }
            else
            {
                _elements.Add(name, regex);
            }
            return this;
        }

        #region construction methods 

        public PasswordGeneratorV1 Number(int min = 1, int max = 0)
        {
            _sb.Append(Construct(_elements["number"], min, max));
            return this;
        }

        public PasswordGeneratorV1 UpperCase(int min = 1, int max = 0)
        {
            _sb.Append(Construct(_elements["uppercase"], min, max));
            return this;
        }

        public PasswordGeneratorV1 LowerCase(int min = 1, int max = 0)
        {
            _sb.Append(Construct(_elements["lowercase"], min, max));
            return this;
        }

        public PasswordGeneratorV1 SpecialCharacter(int min = 1, int max = 0)
        {
            _sb.Append(Construct(_elements["special"], min, max));
            return this;
        }

        public PasswordGeneratorV1 Total(int min, int max = 0)
        {
            string count = min.ToString() + ((max == 0) ? "" : "," + max.ToString());
            _sb.Append(".{" + count + "}");
            return this;
        }

        #endregion

        public string Compose()
        {
            return "(" + _sb.ToString() + ")";
        }



    }

}
