using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ты нахера на надпись нажал? Для кого кнопка сделана? ",
                "Вопросик",
                MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                "Ты дебил?",
                "Вопросик",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            if ( res == DialogResult.Yes)
            {
                MessageBox.Show(
                    "Ну хоть честно ответил",
                    "Молодец",
                    MessageBoxButtons.OK
                    );
            }else if (res == DialogResult.No)
            {
                MessageBox.Show(
                    "Ты чего это врешь?!",
                    "Ах, ты пиздобол",
                    MessageBoxButtons.OK
                    );
            }
            else if(res == DialogResult.Cancel)
            {
                MessageBox.Show(
                    "Не хочешь отвечать?",
                    "Э! Куда?!",
                    MessageBoxButtons.OK
                    );
            }
        }
    }
}
