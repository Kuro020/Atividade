using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ClienteMateus cliente = new ClienteMateus();
            cliente.Show();
        }

        private void btnCarro_Click(object sender, EventArgs e)
        {
            CarroMateus carro = new CarroMateus();
            carro.Show();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketMateus ticket = new TicketMateus();
            ticket.Show();
        }
    }
}
