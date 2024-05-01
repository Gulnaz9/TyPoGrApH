using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TyPoGrApH
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            string str = MainRTextBox.Text;
            if(string.IsNullOrEmpty(str))
            {
                MessageBox.Show("Введите текст, который хотите изменить");
            }
            else
            {
                str = Methods.ReplacePlusMinus(str);
                str = Methods.ReplaceToOneSpace(str);
                str = Methods.ReplaceQuotes(str);
                str = Methods.ReplaceDots(str);
                str = Methods.WorkWithCharsAndSpaces(str);

                str = Methods.ReplaceHashtage(str);
                str = Methods.ReplaceToNearChar(str);
                str = Methods.MakeAbsurd(str);

                MainRTextBox.Text = str;
            }
        }

    }
}
