namespace WindowsFormsApp1
{
    partial class FormTask
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCriticity = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelEnviroment = new System.Windows.Forms.Label();
            this.checkedEnviroment = new System.Windows.Forms.CheckedListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDuration = new System.Windows.Forms.Label();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelPercent = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 16);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(15, 49);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(212, 22);
            this.textTitle.TabIndex = 1;
            // 
            // textLocation
            // 
            this.textLocation.BackColor = System.Drawing.SystemColors.Menu;
            this.textLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLocation.Location = new System.Drawing.Point(246, 49);
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(208, 22);
            this.textLocation.TabIndex = 4;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(243, 30);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(58, 16);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 92);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(39, 16);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Type";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Incident",
            "Prototype",
            "Back",
            "Front",
            "BBDD"});
            this.comboBox1.Location = new System.Drawing.Point(15, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // labelCriticity
            // 
            this.labelCriticity.AutoSize = true;
            this.labelCriticity.Location = new System.Drawing.Point(153, 92);
            this.labelCriticity.Name = "labelCriticity";
            this.labelCriticity.Size = new System.Drawing.Size(49, 16);
            this.labelCriticity.TabIndex = 8;
            this.labelCriticity.Text = "Criticity";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Minor",
            "Medium",
            "Hight"});
            this.comboBox2.Location = new System.Drawing.Point(156, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // labelEnviroment
            // 
            this.labelEnviroment.AutoSize = true;
            this.labelEnviroment.Location = new System.Drawing.Point(303, 92);
            this.labelEnviroment.Name = "labelEnviroment";
            this.labelEnviroment.Size = new System.Drawing.Size(74, 16);
            this.labelEnviroment.TabIndex = 10;
            this.labelEnviroment.Text = "Enviroment";
            // 
            // checkedEnviroment
            // 
            this.checkedEnviroment.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedEnviroment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedEnviroment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.checkedEnviroment.FormattingEnabled = true;
            this.checkedEnviroment.Items.AddRange(new object[] {
            "Prod",
            "Preprod",
            "Demo"});
            this.checkedEnviroment.Location = new System.Drawing.Point(306, 111);
            this.checkedEnviroment.Name = "checkedEnviroment";
            this.checkedEnviroment.Size = new System.Drawing.Size(120, 68);
            this.checkedEnviroment.TabIndex = 11;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 185);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Description";
            // 
            // textDescription
            // 
            this.textDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textDescription.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textDescription.Location = new System.Drawing.Point(15, 215);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(439, 89);
            this.textDescription.TabIndex = 13;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 321);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 16);
            this.labelDate.TabIndex = 14;
            this.labelDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 340);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(233, 321);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(114, 16);
            this.labelDuration.TabIndex = 16;
            this.labelDuration.Text = "Duration (in hours)";
            // 
            // numericDuration
            // 
            this.numericDuration.DecimalPlaces = 2;
            this.numericDuration.Location = new System.Drawing.Point(236, 339);
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(218, 22);
            this.numericDuration.TabIndex = 17;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 375);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 16);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Status";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Planned"});
            this.comboBox3.Location = new System.Drawing.Point(15, 394);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(187, 24);
            this.comboBox3.TabIndex = 19;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(233, 375);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(112, 16);
            this.labelPercent.TabIndex = 20;
            this.labelPercent.Text = "Percent complete";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0%",
            "1%",
            "2%",
            "3%",
            "4%",
            "5%",
            "6%",
            "7%",
            "8%",
            "9%",
            "10%",
            "11%",
            "12%",
            "13%",
            "14%",
            "15%",
            "16%",
            "17%",
            "18%",
            "19%",
            "20%",
            "21%",
            "22%",
            "23%",
            "24%",
            "25%",
            "26%",
            "27%",
            "28%",
            "29%",
            "30%",
            "31%",
            "32%",
            "33%",
            "34%",
            "35%",
            "36%",
            "37%",
            "38%",
            "39%",
            "40%",
            "41%",
            "42%",
            "43%",
            "44%",
            "45%",
            "46%",
            "47%",
            "48%",
            "49%",
            "50%",
            "51%",
            "52%",
            "53%",
            "54%",
            "55%",
            "56%",
            "57%",
            "58%",
            "59%",
            "60%",
            "61%",
            "62%",
            "63%",
            "64%",
            "65%",
            "66%",
            "67%",
            "68%",
            "69%",
            "70%",
            "71%",
            "72%",
            "73%",
            "74%",
            "75%",
            "76%",
            "77%",
            "78%",
            "79%",
            "80%",
            "81%",
            "82%",
            "83%",
            "84%",
            "85%",
            "86%",
            "87%",
            "88%",
            "89%",
            "90%",
            "91%",
            "92%",
            "93%",
            "94%",
            "95%",
            "96%",
            "97%",
            "98%",
            "99%",
            "100%"});
            this.comboBox4.Location = new System.Drawing.Point(236, 394);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(218, 24);
            this.comboBox4.TabIndex = 21;
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Location = new System.Drawing.Point(15, 441);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(260, 20);
            this.checkEmail.TabIndex = 22;
            this.checkEmail.Text = "check here if you want to send an email";
            this.checkEmail.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(280, 499);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 32);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSubmit.Location = new System.Drawing.Point(366, 499);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(88, 32);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 543);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.checkedEnviroment);
            this.Controls.Add(this.labelEnviroment);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelCriticity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormTask";
            this.Text = "Create new task";
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCriticity;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelEnviroment;
        private System.Windows.Forms.CheckedListBox checkedEnviroment;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

