using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        private FormTask formTask;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnviar.Text = listDiasSemana.SelectedItem.ToString();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            buttonEnviar.Text = textNombre.Text;
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            formTask = new FormTask();  
            formTask.ShowDialog();
        }
    }
}
