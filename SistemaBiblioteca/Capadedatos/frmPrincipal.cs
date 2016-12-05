using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capadedatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Models.ContextoBiblioteca())
                {
                    if (!db.Database.Exists())
                    {
                        db.Database.CreateIfNotExists();
                        MessageBox.Show("Se creo la base de datos exitosamente!!");
                    }
                    else
                    {
                        MessageBox.Show("Conectado a la Base de datos!!");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
