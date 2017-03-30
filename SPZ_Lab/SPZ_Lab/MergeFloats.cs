using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_Lab
{
    public partial class MergeFloats : Form
    {

        #region Variables

        private List<double> _firstFileNumbers;
        private List<double> _secondFileNumbers;


        #endregion

        public MergeFloats()
        {
            InitializeComponent();
        }

        private void OpenFirstFileButton_Click(object sender, EventArgs e)
        {
            _firstFileNumbers = new List<double>();
            InitializeLoading(_firstFileNumbers, FirstFileName, FirstFileText);
            InitMergedValues();
        }

        private void OpenSecondFileButton_Click(object sender, EventArgs e)
        {
            _secondFileNumbers = new List<double>();
            InitializeLoading(_secondFileNumbers, SecondFileName, SecondFileText);
            InitMergedValues();
        }

        #region Helpers

        private void InitMergedValues()
        {
            if (null == _firstFileNumbers || null == _secondFileNumbers)
            {
               return; 
            }  

            List<double> merged = new List<double>();
            merged.AddRange(_firstFileNumbers);
            merged.AddRange(_secondFileNumbers);

            merged.Sort();
            MergedValues.Text = String.Empty;
            foreach (var val in merged)
            {
                MergedValues.Text += val + " ";
            }
        }

        private void ReadValuesFromFile(List<double> array, Label fileName)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string text;
                string[] bits;

                using (TextReader reader = File.OpenText(FD.FileName))
                {
                    text = reader.ReadToEnd();
                    char[] separators = new[] {' ', '\r' , '\n' , '\t'};
                    bits = text.Split(separators);
                }

                int errors = 0;
                foreach (var val in bits)
                {
                    try
                    {
                        double num = Convert.ToDouble(val, CultureInfo.InvariantCulture);
                        array.Add(num);
                    }
                    catch (Exception exception)
                    {
                        errors++;
                    }
                }

                fileName.Text = FD.FileName;
                if (array.Count == 0 && errors == 0)
                {
                    MessageBox.Show($"There are no any float number at {FD.FileName}");
                    fileName.Text = String.Empty;
                }

                if (errors > 0)
                {
                    MessageBox.Show($"There are {errors} errors when parse file.");
                }
            }
        }

        private void InitializeLoading(List<double> array, Label fileName, TextBox textToShow)
        {
            ReadValuesFromFile(array, fileName);

            textToShow.Text = string.Empty;
            if (null == array)
            {
                return;
            }
            foreach (var val in array)
            {
                textToShow.Text += val + " ";
            }
        }

        #endregion

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MergedValues?.Text))
            {
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveDialog.Title = "Save text file";

            if (saveDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                string filename = saveDialog.FileName;
                System.IO.File.WriteAllText(filename, MergedValues.Text);
                MessageBox.Show("File successfully saved");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
