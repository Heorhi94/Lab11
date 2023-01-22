﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Person;
using WindowsFormsApp1.Triple;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        Triple<int> tripleINt;
        Triple<double> tripleDouble;
        Triple<Pers> triplePers;
        Triple<string> tripleString;
        public Main()
        {
            InitializeComponent();
        }

        private void types_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (types.SelectedIndex == 3)
            {
                labelSurnA.Visible = true;
                labelSurnB.Visible = true;
                labelSurnC.Visible = true;
                textSurnA.Visible = true;
                textSurnB.Visible = true;
                textSurnC.Visible = true;
                labelA.Text = "Name";
                labelB.Text = "Name";
                labelC.Text = "Name";
            }
            else
            {
                labelSurnA.Visible = false;
                labelSurnB.Visible = false;
                labelSurnC.Visible = false;
                textSurnA.Visible = false;
                textSurnB.Visible = false;
                textSurnC.Visible = false;
                labelA.Text = "A";
                labelB.Text = "B";
                labelC.Text = "C";
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if(types.SelectedIndex == 0)
            {
                tripleINt = new Triple<int>(Convert.ToInt32(textA.Text), Convert.ToInt32(textB.Text), Convert.ToInt32(textC.Text));
            }
            if (types.SelectedIndex == 1)
            {
                tripleDouble = new Triple<double>(Convert.ToDouble(textA.Text),Convert.ToDouble(textB.Text), Convert.ToDouble(textC.Text));
            }
            if(types.SelectedIndex == 2)
            {
                tripleString = new Triple<string>(textA.Text,textB.Text,textC.Text);
            }
            if (types.SelectedIndex == 3)
            {
                Pers A = new Pers(textA.Text, textSurnA.Text);
                Pers B = new Pers(textB.Text, textSurnB.Text);
                Pers C = new Pers(textC.Text, textSurnC.Text);
                triplePers = new Triple<Pers>(A, B, C);
            }
        }

        private void bDispalay_Click(object sender, EventArgs e)
        {
            if (types.SelectedIndex == 0)
            {
                textDisplay.Text = tripleINt.ToString();
            }
            if(types.SelectedIndex == 1)
            {
                textDisplay.Text =tripleDouble.ToString();
            }
            if (types.SelectedIndex == 2)
            {
                textDisplay.Text = tripleString.ToString();
            }
            if (types.SelectedIndex == 3)
            {
                textDisplay.Text = triplePers.ToString();
            }
        }

        private void bSort_Click(object sender, EventArgs e)
        {
            if(types.SelectedIndex == 0)
            {
                tripleINt.Sort();
            }
            if (types.SelectedIndex == 1)
            {
                tripleDouble.Sort();
            }
            if (types.SelectedIndex == 2)
            {
                tripleString.Sort();
            }
            if (types.SelectedIndex == 3)
            {
                triplePers.Sort();
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textA.Clear();
            textB.Clear();
            textC.Clear();
            textSurnA.Clear();
            textSurnB.Clear();
            textSurnC.Clear();
            textDisplay.Clear();
        }
    }
}
