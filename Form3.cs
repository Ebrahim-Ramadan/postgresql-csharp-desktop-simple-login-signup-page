using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db
{
    public partial class Form3 : Form
    {
        private Form1 form1Instance;
        public Form3(string jwt_string, Form1 form1)
        {
            InitializeComponent();
            jwt_generated.Text = jwt_string;
            form1Instance = form1;
            form1Instance.CloseForm1();
            //closing form1 (hidden) once this form is initialized
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void jwt_generated_Click(object sender, EventArgs e)
        {
            jwt_generated.AutoSize = false;
            jwt_generated.AutoEllipsis = true;
            jwt_generated.MaximumSize = new Size(50, 0); //wrapping

        }
    }
}
