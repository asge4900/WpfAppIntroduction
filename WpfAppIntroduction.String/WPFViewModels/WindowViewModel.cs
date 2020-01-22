using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        }

        #endregion

        #region Properties

        public string TextBox { get; set; }

        public string TextBox2 { get; set; }

        #endregion


        #region Commands

        public ICommand CountAllLinesCommand { get; set; }

        public ICommand CountAllVowelsCommand { get; set; }

        #endregion


        #region Methods

        private string TextFile()
        {
            return "Hej";
        }

        private void CountAllLines()
        {            

            var lineCount = File.ReadLines(@"..\Admiralen.txt").Count(line => !line.All(char.IsWhiteSpace));            

            using (var reader = File.OpenText(@"..\Admiralen.txt"))
            { 
                TextBox2 = reader.ReadToEnd();
            }

            TextBox = lineCount.ToString();            
        }

        private void CountAllVowels()
        {
            // Build a list of vowels up front:
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'æ', 'ø' };

            int total = 0;                          

            using (var reader = File.OpenText(@"..\Admiralen.txt"))
            {
                string test = reader.ReadToEnd();

                total = test.Count(c => vowels.Contains(c));
            }

            using (var reader = File.OpenText(@"..\Admiralen.txt"))
            {
                TextBox2 = reader.ReadToEnd();
            }

            TextBox = total.ToString();
        }

        #endregion
    }
}
