using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
     public partial class MainForm : Form
     {
          private ChildForm ChildForm;

          public MainForm()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               ChildForm = new ChildForm();
               ChildForm.button_Click += Changetext;
               ChildForm.ShowDialog();
          }

          public void Changetext(string text)
          {
               this.textBox1.Text = text;
          }
     }
}
