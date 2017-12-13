using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contract
{
    class DocumentFormsContainer
    {
        Dictionary<string, Form> pages;

        public Dictionary<string, Form> Pages
        {
            get
            {
                return pages;
            }           
        }

        public DocumentFormsContainer()
        {
            pages = new Dictionary<string, Form>();
        }

        public bool ContainsPage(string key)
        {
            
            return pages.ContainsKey(key);

        }
        public Form addPage(KeyValuePair<string, Form> kvp)
        {
            if (!pages.ContainsKey(kvp.Key))
            {
                pages.Add(kvp.Key, kvp.Value);
                return kvp.Value;
            }
            return pages[kvp.Key];
        }

        public void removePage(Form page)
        {
            if (pages.ContainsValue(page))
                pages.Remove(pages.First(x => x.Value == page).Key);
        }

    }
}
