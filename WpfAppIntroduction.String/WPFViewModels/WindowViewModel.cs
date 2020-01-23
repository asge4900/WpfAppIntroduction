using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfAppIntroduction.String
{
    public class WindowViewModel : BaseViewModel
    {
        #region Constructor

        public WindowViewModel()
        {
            CountAllLinesCommand = new RelayCommand(CountAllLines);            
            CountAllVowelsCommand = new RelayCommand(CountAllVowels);
            RemoveAllVowelsCommand = new RelayCommand(RemoveAllVowels);

            TextBoxMain = GetTestString();
        }

        #endregion

        #region Properties

        public string TextBoxMain { get; set; }

        public string TextBoxResult { get; set; }

        public string SearchText { get; set; }

        #endregion


        #region Commands

        public ICommand CountAllLinesCommand { get; set; }

        public ICommand CountAllVowelsCommand { get; set; }

        public ICommand RemoveAllVowelsCommand { get; set; }

        public ICommand MarkAndCountWordCommand { get; set; }

        #endregion


        #region Command Methods       

        private void CountAllLines()
        {
            //var lineCount = File.ReadLines(@"..\Admiralen.txt").Count(line => !line.All(char.IsWhiteSpace));
            
            // Remove empty line
            var resultString = Regex.Replace(TextBoxMain, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);

            // Count lines
            var lineCount = resultString.Split('\n').Length;
            
            TextBoxResult = lineCount.ToString();            
        }

        private void CountAllVowels()
        {
            // Build a list of vowels up front:
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å' };          

            int total = TextBoxMain.ToLower().Count(c => vowels.Contains(c));                               

            TextBoxResult = total.ToString();
        }

        private void RemoveAllVowels()
        {
            // Build a list of vowels up front:
            var vowels = new HashSet<char> {'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y', 'Æ', 'æ', 'Ø', 'ø', 'Å', 'å' }; 

            string text = new string(TextBoxMain.Where(c => !vowels.Contains(c)).ToArray());

            TextBoxResult = text;
        }

        private void MarkAndCountWord()
        {
            
            int count = 0;
            string textToSearch = TextBoxMain;
            int i = textToSearch.IndexOf(SearchText);
            while (i != -1)
            {
                textToSearch = textToSearch.Insert(i, "#>");
                count++;
                i = textToSearch.IndexOf(SearchText, i + 3);
            }
            textToSearch = $"Ordet {SearchText} blev fundet {count} gange og er blevet markeret med #>\n\n{textToSearch}";            
        }

        #endregion

        #region Methods

        private string GetTestString()
        {
            string s = string.Empty;

            using (var reader = File.OpenText(@"..\Admiralen.txt"))
            {
                s = reader.ReadToEnd();
            }

            return s;
        }

        #endregion
    }
}
