using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    internal class Islemler
    {
        
        public static void clearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is RichTextBox richTextBox)
                {
                    richTextBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; 
                    comboBox.Text = string.Empty; 
                }
                else if (control is TabControl tabControl)
                {
                    foreach (TabPage tabPage in tabControl.TabPages)
                    {
                        foreach (Control tabControlChild in tabPage.Controls)
                        {
                            if (tabControlChild is TextBox tabTextBox)
                            {
                                tabTextBox.Clear();
                            }
                            else if (tabControlChild is ComboBox tabComboBox)
                            {
                                tabComboBox.SelectedIndex = -1;
                                tabComboBox.Text = string.Empty;
                            }
                        }
                    }
                }
            }
        }
    }
}
