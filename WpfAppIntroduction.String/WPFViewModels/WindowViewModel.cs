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

        }

        #endregion

        #region Properties



        #endregion


        #region Commands

        public ICommand CountAllLinesCommand { get; set; }
        
        #endregion


        #region Methods

        public int CountAllLines()
        {
            var lineCount = 0;
            using (var reader = File.OpenText(@"Admiralen.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }

        #endregion
    }
}
