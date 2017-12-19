using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    class IniFile
    {
        IniFile oldSettings;
        string _path;
        Dictionary<string, string> _valueList;

        public IniFile(string Path)
        {
            _path = Path;
            
            _valueList = getValueList();
            oldSettings = this;

        }

        public Dictionary<string, string> ValueList
        {
            get
            {
                return _valueList;
            }
        }
        public override bool Equals(object obj)
        {
            IniFile objFile = obj as IniFile;
            foreach (KeyValuePair<string, string> kvp in _valueList)
            {
                if (_valueList[kvp.Key] != objFile.ValueList[kvp.Key]) return false;

            }

            return true;
        }
        private Dictionary<string, string> getValueList()
        {
            Dictionary<string, string> tmpDict = new Dictionary<string, string>();
            if (File.Exists(_path))
            {
                string text = System.IO.File.ReadAllText(_path);
                text = text.Replace("\r", "");
                text = text.Replace("[Settings]", "");
                text = text.Replace(" ", "");
                text = text.Replace("\n", "");
                string[] lines = text.Split(';');
                foreach (string line in lines)
                {
                    if (line.Length != 0)
                    {
                        string tmpLine = line;
                        tmpLine = line.Replace(" ", "");
                        string[] values = line.Split('=');
                        tmpDict.Add(values[0], values[1]);
                    }
                }
            }
            else
            {
                tmpDict.Add("userName", "");
                tmpDict.Add("serverAddress", "");
                SaveChanges(tmpDict);
            }

            return tmpDict;

        }

        public void ChangeValue(string valueName, string newValue)
        {
            _valueList[valueName] = newValue;
            if (CheckChanges())
                SaveChanges(_valueList);
        }
        private bool CheckChanges()
        {
            return Equals(oldSettings);

        }

        private void SaveChanges(Dictionary<string,string> _values)
        {
            using (StreamWriter sw = new StreamWriter(_path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("[Settings]");
            }
            foreach (KeyValuePair<string, string> kvp in _values)
            {
                using (StreamWriter sw = new StreamWriter(_path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(kvp.Key + " = " + kvp.Value + ";");
                }
            }
        }
    }

}
