using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PomoTask.Controller
{
    class Timer
    {
        
        #region Propriedades >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private int min, seg, mili;

        private Label lblMili, lblMin, lblSegs;

        #endregion

        #region Contrutor >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public Timer(Label mili,Label segs,Label min)
        {
            this.lblMili = mili;
            this.lblSegs = segs;
            this.lblMin = min; 
        }

        #endregion

        #region Metodos Publicos >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        //Iniciar contagem 
        public void Iniciar()
        {
            this.reduzirMilis();
        }

        //Reiniciar Contagem
        public void reinciarRelogio()
        {
            lblMili.Text = "00";
            lblSegs.Text = "00";
            lblMin.Text = "25";
        }
        #endregion

        #region Metodos Privados >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        //Reduzir contagem em milisegundos
        private void reduzirMilis()
        {
            try
            {
                this.mili = Convert.ToInt16(lblMili.Text);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Erro ao converter segundos: " + exception);
            }
            if ((--this.mili) < 0)
            {
                lblMili.Text = "59";
                this.reduzirSegs();
            }
            else
            {
                lblMili.Text = (this.mili).ToString();
            }

        }
        
        //Reduzir contagem em segundos
        private void reduzirSegs()
        {
            try
            {
                this.seg = Convert.ToInt16(lblSegs.Text);
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Erro ao converter segundos: " + exception);
            }
            if ((--this.seg) < 0)
            {
                lblSegs.Text = "59";
                this.reduzirMins();
            }
            else
            {
                lblSegs.Text = (this.seg).ToString();
            }

        }

        //Reduzir contagem em minutos 
        private void reduzirMins()
        {
            try
            {
                this.min = Convert.ToInt16(lblMin.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro ao converter minutos: " + exception);
            }
            if ((--this.min) < 0)
            {
                lblMin.Text = "25";

            }
            else
            {
                lblMin.Text = (this.min).ToString();
            }
        }
        
        #endregion 


    }
}
