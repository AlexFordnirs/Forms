using System;
using System.Drawing;
using System.Windows.Forms;

namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(int.Parse(Properties.Resources.WidthMain), int.Parse(Properties.Resources.HeigthMain));
            this.Text = Properties.Resources.MainFormName;
            this.BackColor = Color.Black;
            this.ForeColor = Color.Aqua;
            //
            // Init Elements
            //
            X = new TextBox();
            Y = new TextBox();
            SizeW = new TextBox();
            SizeH = new TextBox();
            NameInput = new TextBox();
            ColorText = new TextBox();
            NewModalBtn = new Button();
            NewNoneModalBtn = new Button();
            //
            // X , Y 
            //
            X.Location = new System.Drawing.Point(int.Parse(Properties.Resources.TextXLocX), int.Parse(Properties.Resources.TextXLocY));
            X.Text = Properties.Resources.XText;
            Y.Location = new System.Drawing.Point(int.Parse(Properties.Resources.TextYLocX), int.Parse(Properties.Resources.TextYLocY));
            Y.Text = Properties.Resources.YText;
            //
            // Width , Heigth
            //
            SizeW.Location = new Point(int.Parse(Properties.Resources.SizeWX), int.Parse(Properties.Resources.SizeWY));
            SizeW.Text = Properties.Resources.SizeWText;
            SizeH.Location = new Point(int.Parse(Properties.Resources.SizeHX), int.Parse(Properties.Resources.SizeHY));
            SizeH.Text = Properties.Resources.SizeHText;
            //
            // Name , Color
            //
            NameInput.Location = new Point(int.Parse(Properties.Resources.NameInputX), int.Parse(Properties.Resources.NameInputY));
            NameInput.Text = Properties.Resources.NameInputText;
            ColorText.Location = new Point(int.Parse(Properties.Resources.ColorTextX), int.Parse(Properties.Resources.ColorTextY));
            ColorText.Text = Properties.Resources.ColorTxt;
            //
            // ButtonNewForm
            //
            NewModalBtn.Location = new Point(int.Parse(Properties.Resources.ModalBtnX), int.Parse(Properties.Resources.ModalBtnY));
            NewModalBtn.Size = new Size(int.Parse(Properties.Resources.ModalBtnW), int.Parse(Properties.Resources.ModalBtnH));
            NewModalBtn.Text = Properties.Resources.ModalBtnText;
            //
            // ButtonNoneModalBtn
            //
            NewNoneModalBtn.Location = new Point(int.Parse(Properties.Resources.NoneModalBtnX), int.Parse(Properties.Resources.NoneModalBtnY));
            NewNoneModalBtn.Size = new Size(int.Parse(Properties.Resources.NoneModalBtnW), int.Parse(Properties.Resources.NoneModalBtnH));
            NewNoneModalBtn.Text = Properties.Resources.NoneModalBtnText;
            //
            // Clicks
            //
            NewModalBtn.MouseClick += NewModalFormClick;
            NewNoneModalBtn.MouseClick += NewNoneModalFormClick;
            //
            // Controls
            //
            Controls.Add(X);
            Controls.Add(Y);
            Controls.Add(SizeW);
            Controls.Add(SizeH);
            Controls.Add(NameInput);
            Controls.Add(ColorText);
            Controls.Add(NewModalBtn);
            Controls.Add(NewNoneModalBtn);

        }


        TextBox X, Y;
        TextBox SizeW, SizeH;
        TextBox NameInput, ColorText;

        Button NewModalBtn;
        Button NewNoneModalBtn;

        #endregion
    }
}

