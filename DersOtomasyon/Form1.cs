using BusinessLayer.Concrete;
using Entities.Concrete;

namespace DersOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DpManager dpManager = new DpManager();
        private void button1_Click(object sender, EventArgs e)
        {
            dpManager.GetAll();
        }

        
    }
}