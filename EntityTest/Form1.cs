using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityTest
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }
        Entities db=new Entities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Pakize p=new Pakize();
            p.TARİH = DateTime.Now.ToString();
            db.Pakize.Add(p);
            db.SaveChanges();
            MessageBox.Show("Eklendi");
        }
    }
}
