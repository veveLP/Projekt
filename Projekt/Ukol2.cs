﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            /*
            Při spuštění programu vygenerujte do ListBox 10 celých čísel z intervalu 0..10 včetně.
            Umožněte uživateli vícenásobný výběr položky (ve vlastnostech ListBox –
            SelectionMode:MultiExtended).
            Při každé změně výběru položek v ListBox bude v label1 zapsán počet všech vybraných
            položek a v label2 součet všech vybraných položek.
             
             */
            InitializeComponent();
        }

        private void Ukol2_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            for (int i = 0; i < 10; i++) listBox1.Items.Add(rng.Next(0, 10));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItems.Count.ToString());
            int total = 0;
            foreach (var a in listBox1.SelectedItems)
            { 
                total += int.Parse(a.ToString());
            }
           label2.Text = (total.ToString()); 
        }
    }
}
