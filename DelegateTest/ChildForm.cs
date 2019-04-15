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
     public partial class ChildForm : Form
     {
          public delegate void button_click(string text);

          public button_click button_Click;

          public ChildForm()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               button_Click("Delegate works");
          }
     }
}
