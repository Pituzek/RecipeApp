using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RecipeApp.Core;

namespace RecipeApp.Client
{
    public partial class RecipeApp : Form
    {
        public RecipeApp()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e) //bylo button1_Click?
        {
            //MessageBox.Show("Hello world");
            SourceRichTextBox.Text = ReadConctentsFromFileBrowser();
        }

        private static string ReadConctentsFromFileBrowser()
        {
            // Prepare for browsing files
            using (var dialog = new OpenFileDialog())
            {
                // browse files... if file was confirmed
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // read the contents of that file
                    var stream = dialog.OpenFile();
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }

                // happens if cancelled
                return String.Empty;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            var isConvertToSiUnits = SiUnitsRadioButton.Checked;
            var input = SourceRichTextBox.Text;
            string converted;
            if (isConvertToSiUnits)
            {
                converted = RecipeConverter.ConvertToSiUnits(input);
            }
            else
            {
                converted = RecipeConverter.ConvertToCookingUnits(input);
            }
            
            ResultRichTextBox.Text = converted;
        }
    }
}
