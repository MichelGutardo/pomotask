using System;
using System.Windows.Forms;
using System.Diagnostics;
using PomoTask.Controller;


namespace PomoTask.View
{
    public partial class frmRelogio : Form
    {
        private Controller.Timer ctrlTimer;

        public frmRelogio()
        {
            InitializeComponent();

            this.timer.Enabled = true;
            this.ctrlTimer = new Controller.Timer(lblMili, lblSegs, lblMin);
            this.ctrlTimer.reinciarRelogio();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            this.ctrlTimer.Iniciar();

        }

        

    }
}
