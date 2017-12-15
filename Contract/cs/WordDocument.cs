using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Contract.DB;

namespace Contract
{
    class WordDocument
    {

        private Object _missingObj = System.Reflection.Missing.Value;
        private Object _trueObj = true;
        private Object _falseObj = false;


        private Word._Application _application;
        private Word._Document _document;

        private Object _templatePathObj;

        private Word.Range _currentRange = null;

        private Word.Table _table = null;
        public bool Closed
        {
            get
            {
                if (_application == null || _document == null) { return true; }
                else { return false; }
            }
        }

        // видимость на экране приложения Word, по умолчанию false, документ создается невидимым и его надо явно сделать видимым после выполения необходимых операций
        public bool Visible
        {
            get
            {
                if (Closed) { throw new Exception("Ошибка при попытке изменить видимость Microsoft Word. Программа или документ уже закрыты."); }
                return _application.Visible;

            }
            set
            {
                if (Closed) { throw new Exception("Ошибка при попытке изменить видимость Microsoft Word. Программа или документ уже закрыты."); }
                _application.Visible = value;
            }
            // завершение public bool Visible  
        }

        // количество страниц
        public int PagesCount
        {
            get
            {
                int pagesCount = 0;
                Word.WdStatistic pagesStatType = Word.WdStatistic.wdStatisticPages;
                pagesCount = _document.ComputeStatistics(pagesStatType, ref _missingObj);
                return pagesCount;
            }
        }

        public WordDocument()
        {

        }
        public WordDocument(string templatePath, bool startVisible)
        {
            //создаем обьект приложения word
            _application = new Word.Application();

            // создаем путь к файлу используя имя файла
            _templatePathObj = templatePath;

            // если вылетим не этом этапе, приложение останется открытым
            try
            {
                _document = _application.Documents.Add(ref _templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                this.Close();
                throw error;
            }
            Visible = startVisible;

        }
        public void Close()
        {

            if (_document != null)
            {
                _document.Close(ref _falseObj, ref _missingObj, ref _missingObj);
            }
            _application.Quit(ref _missingObj, ref _missingObj, ref _missingObj);
            _document = null;
            _application = null;
        }

        public WordDocument(string templatePath)
            : this(templatePath, false) { }


        public void ReplaceStr(object strToFind, object replaceStr)
        {
            ////List<Word.Range> strRange = FindRange(strToFind);
            //if (strRange.Count != 0)
            //    foreach(Word.Range wordRange in strRange)
            //        wordRange.Text = replaceStr.ToString();
        }

        private void ReplaceAllStr(object strToFind, object strToReplace)
        {
            List<Word.Range> ranges = new List<Word.Range>();
            Word.Range wordRange;
            bool rangeFound;
            object replaceTypeObj = Word.WdReplace.wdReplaceAll;
            // обходим все разделы документа
            for (int i = 1; i <= _document.Sections.Count; i++)
            {
               
                wordRange = _document.Sections[i].Range;

               

                Word.Find wordFindObj = wordRange.Find;
                object[] wordFindParameters = new object[15] { strToFind, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, _missingObj, strToReplace, replaceTypeObj, _missingObj, _missingObj, _missingObj, _missingObj };

                wordFindObj.GetType().InvokeMember("Execute", BindingFlags.InvokeMethod, null, wordFindObj, wordFindParameters);
            }


        }


        public void makeNewWordContract(Contract.DB.Contract currentContract)
        {
            _application = new Word.Application();

            // создаем путь к файлу используя имя файла
            _templatePathObj = @"D:\vsp\WordTemplates\№9contractTemplate.dot";

            try
            {
                _document = _application.Documents.Add(ref _templatePathObj, ref _missingObj, ref _missingObj, ref _missingObj);
            }
            catch (Exception error)
            {
                this.Close();
                throw error;
            }

            ReplaceAllStr("@@ContractNumber@@", currentContract.Number);
            ReplaceAllStr("@@ContractDate@@", currentContract.Date);
            ReplaceAllStr("@@ContractorPersonInCharge@@", currentContract.Contractors.PersonInCharge);
            ReplaceAllStr("@@ContractorBaseDocument@@", currentContract.Contractors.BaseDocument);

            ReplaceAllStr("@@ContractDateDay@@", currentContract.Date.Value.Day);
            ReplaceAllStr("@@ContractDateMonth@@", currentContract.Date.Value.Month);
            ReplaceAllStr("@@ContractDateYear@@", currentContract.Date.Value.Year);
            ReplaceAllStr("@@ContractorName@@", currentContract.Contractors.FullName);
            ReplaceAllStr("@@ContractSumm@@", currentContract.Summ);
            Visible = true;



        }
    }
}
