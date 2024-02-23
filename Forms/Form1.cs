using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {

        string Errors = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void NewModalFormClick(object sender, MouseEventArgs e)
        {
            Form Form2 = new Form();
            NameInput.BackColor = Color.White;
            X.BackColor = Color.White;
            Y.BackColor = Color.White;
            SizeW.BackColor = Color.White;
            SizeH.BackColor = Color.White;
            Errors = "";
            try
            {
                if (NameInput.Text == Properties.Resources.NameInputText)
                {
                    throw new InvalidOperationException("Incorrect Name");
                }
                else
                {
                    Form2.Text = NameInput.Text;
                    NameInput.BackColor = Color.White;
                }
                Form2.Size = new Size(int.Parse(SizeW.Text), int.Parse(SizeH.Text));
                Form2.Location = new Point(int.Parse(X.Text), int.Parse(Y.Text));

                Color color;
                try
                {
                    color = Color.FromName(ColorText.Text);
                    Form2.BackColor = color == null ? Color.Red : color;
                    ColorText.BackColor = Color.White;
                    Form2.FormBorderStyle = FormBorderStyle.Fixed3D;
                    Form2.ShowDialog();
                }
                catch (Exception ex)
                {
                    Errors += "Incorrect Color" + Environment.NewLine;
                    ColorText.BackColor = Color.Red;
                    MessageBox.Show(Errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                bool isInt;
                int res;

                if (NameInput.Text == "" || NameInput.Text == Properties.Resources.NameInputText)
                {
                    NameInput.BackColor = Color.Red;
                    Errors += "Incorrect Name" + Environment.NewLine;
                }
                else
                {
                    NameInput.BackColor = Color.White;
                }
                isInt = Int32.TryParse(SizeW.Text, out res);
                if (SizeW.Text == "" || SizeW.Text == Properties.Resources.SizeWText || isInt == false)
                {
                    SizeW.BackColor = Color.Red;
                    Errors += "Incorrect Width" + Environment.NewLine;
                }
                else
                {
                    SizeW.BackColor = Color.White;
                }
                isInt = Int32.TryParse(SizeH.Text, out res);
                if (SizeH.Text == "" || SizeH.Text == Properties.Resources.SizeHText || isInt == false)
                {
                    SizeH.BackColor = Color.Red;
                    Errors += "Incorrect Heigth" + Environment.NewLine;
                }
                else
                {
                    SizeH.BackColor = Color.White;
                }
                isInt = Int32.TryParse(X.Text, out res);
                if (X.Text == "" || X.Text == Properties.Resources.XText || isInt == false)
                {
                    X.BackColor = Color.Red;
                    Errors += "Incorrect X" + Environment.NewLine;
                }
                else
                {
                    X.BackColor = Color.White;
                }
                isInt = Int32.TryParse(Y.Text, out res);
                if (Y.Text == "" || Y.Text == Properties.Resources.YText || isInt == false)
                {
                    Y.BackColor = Color.Red;
                    Errors += "Incorrect Y" + Environment.NewLine;
                }
                else
                {
                    Y.BackColor = Color.White;
                }
                if (ColorText.Text == "" || ColorText.Text == Properties.Resources.ColorTxt)
                {
                    ColorText.BackColor = Color.Red;
                    Errors += "Incorrect Color";
                }
                else
                {
                    ColorText.BackColor = Color.White;
                }
                MessageBox.Show(Errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            GC.Collect();
        }
        private void NewNoneModalFormClick(object sender, MouseEventArgs e)
        {
            Form Form2 = new Form();
            NameInput.BackColor = Color.White;
            X.BackColor = Color.White;
            Y.BackColor = Color.White;
            SizeW.BackColor = Color.White;
            SizeH.BackColor = Color.White;
            Errors = "";
            try
            {
                if (NameInput.Text == Properties.Resources.NameInputText)
                {
                    throw new InvalidOperationException("Incorrect Name");
                }
                else
                {
                    Form2.Text = NameInput.Text;
                    NameInput.BackColor = Color.White;
                }
                Form2.Size = new Size(int.Parse(SizeW.Text), int.Parse(SizeH.Text));
                Form2.Location = new Point(int.Parse(X.Text), int.Parse(Y.Text));

                Color color;
                try
                {
                    color = Color.FromName(ColorText.Text);
                    Form2.BackColor = color == null ? Color.Red : color;
                    ColorText.BackColor = Color.White;
                    Form2.FormBorderStyle = FormBorderStyle.Fixed3D;
                    Form2.Show();
                }
                catch (Exception ex)
                {
                    Errors += "Incorrect Color" + Environment.NewLine;
                    ColorText.BackColor = Color.Red;
                    MessageBox.Show(Errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {
                bool isInt;
                int res;

                if (NameInput.Text == "" || NameInput.Text == Properties.Resources.NameInputText)
                {
                    NameInput.BackColor = Color.Red;
                    Errors += "Incorrect Name" + Environment.NewLine;
                }
                else
                {
                    NameInput.BackColor = Color.White;
                }
                isInt = Int32.TryParse(SizeW.Text, out res);
                if (SizeW.Text == "" || SizeW.Text == Properties.Resources.SizeWText || isInt == false)
                {
                    SizeW.BackColor = Color.Red;
                    Errors += "Incorrect Width" + Environment.NewLine;
                }
                else
                {
                    SizeW.BackColor = Color.White;
                }
                isInt = Int32.TryParse(SizeH.Text, out res);
                if (SizeH.Text == "" || SizeH.Text == Properties.Resources.SizeHText || isInt == false)
                {
                    SizeH.BackColor = Color.Red;
                    Errors += "Incorrect Heigth" + Environment.NewLine;
                }
                else
                {
                    SizeH.BackColor = Color.White;
                }
                isInt = Int32.TryParse(X.Text, out res);
                if (X.Text == "" || X.Text == Properties.Resources.XText || isInt == false)
                {
                    X.BackColor = Color.Red;
                    Errors += "Incorrect X" + Environment.NewLine;
                }
                else
                {
                    X.BackColor = Color.White;
                }
                isInt = Int32.TryParse(Y.Text, out res);
                if (Y.Text == "" || Y.Text == Properties.Resources.YText || isInt == false)
                {
                    Y.BackColor = Color.Red;
                    Errors += "Incorrect Y" + Environment.NewLine;
                }
                else
                {
                    Y.BackColor = Color.White;
                }
                if (ColorText.Text == "" || ColorText.Text == Properties.Resources.ColorTxt)
                {
                    ColorText.BackColor = Color.Red;
                    Errors += "Incorrect Color";
                }
                else
                {
                    ColorText.BackColor = Color.White;
                }
                MessageBox.Show(Errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            GC.Collect();
        }
    }
}
