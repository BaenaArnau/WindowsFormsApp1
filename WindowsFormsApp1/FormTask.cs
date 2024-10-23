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
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
            InitializeDateTimePicker();
        }

        private void InitializeDateTimePicker()
        {
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = DateTime.Now;

            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            if (dateTimePicker1.CustomFormat == " ")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
                dateTimePicker1.Value = DateTime.Now; 
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dateTimePicker1.CustomFormat == " ")
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
                dateTimePicker1.Value = DateTime.Now;
            }
        }

        public void ClearDateTimePicker()
        {
            dateTimePicker1.CustomFormat = " ";
        }

    private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool titleIsNull = false, descriptionIsNull = false, oneEnvirementCheckNull = false;
            string message = "";

            if (string.IsNullOrWhiteSpace(textTitle.Text))
            {
                titleIsNull = true;
                message += "No has rellenado el campo obligatorio de Title \n";
            }
            if (string.IsNullOrWhiteSpace(textDescription.Text))
            {
                descriptionIsNull = true;
                message += "No has rellenado el campo obligatorio de Description \n";
            }
            if (string.IsNullOrWhiteSpace(checkedEnviroment.Text))
            {
                oneEnvirementCheckNull = true;
                message += "No has seleccionado ningun campo obligatorio de Envirement (min: 1) \n";
            }

            if (!titleIsNull && !descriptionIsNull && !oneEnvirementCheckNull)
            { 
                message = $@"Se ha enviado todo con exito:
    Titulo: {textTitle.Text}
    Descripcion: {textDescription.Text}
    Enviroment: ";

                foreach (var item in checkedEnviroment.CheckedItems)
                {
                    message += item.ToString() + ", "; 
                }
            }

            MessageBox.Show(message);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dateTimePicker1.CustomFormat = " ";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
