using NHTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriPortTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tmrVeriGonder.Interval = (int)Delegates.Value.Get(numericUpDown1);
        }

        private void chckTekrarla_CheckedChanged(object sender, EventArgs e)
        {
            grpTekrarla.Enabled = Delegates.Checked.Get(chckTekrarla);
            tmrVeriGonder.Enabled = Delegates.Checked.Get(chckTekrarla);
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Port açık değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Delegates.Text.Get(rtxtGonder)))
            {
                MessageBox.Show("Gönderilecek veri boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Optimizasyon.ArkaplandaCalistir(() => VeriyiGonder());
        }

        private void tmrVeriGonder_Tick(object sender, EventArgs e)
        {
            Optimizasyon.ArkaplandaCalistir(() => VeriyiGonder());
        }

        private void VeriyiGonder(bool hataGoster = false)
        {
            if (serialPort1.IsOpen)
            {
                string veri = Delegates.Text.Get(rtxtGonder);
                if (Delegates.Checked.Get(chckUseRandom))
                {
                    Random rand = new Random();
                    int min = Convert.ToInt32(Delegates.Value.Get(nudRandMin));
                    int max = Convert.ToInt32(Delegates.Value.Get(nudRandMax));
                    int index = veri.IndexOf("<rand/>");
                    while (index >= 0)
                    {
                        string veribasi = veri.Substring(0, index );
                        veribasi += rand.Next(min, max);
                        veribasi += veri.Substring(index+7);
                        veri = veribasi;
                        index = veri.IndexOf("<rand/>");
                    }
                }
                if (!string.IsNullOrEmpty(veri))
                {
                    try
                    {
                        serialPort1.Write(veri);
                        AppendText(rtxtGonderilen, veri);
                    }
                    catch (Exception ex)
                    {
                        if (hataGoster)
                        {
                            MessageBox.Show("Veri gönderilirken bir hata oluştu!\nHata Mesajı:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    };
                }
            }
        }

        private void AppendText(RichTextBox rtxt, string text)
        {
            Optimizasyon.Delagate(rtxt, () => { rtxt.AppendText(string.Format("{0} - {1}\n", DateTime.Now.ToLongTimeString(), text)); });
        }

        private void seriBaglanti1_PortAcildi(object sender, NHSeriBaglanti.SeriPortArgs e)
        {
            Delegates.Enabled.Set(grpVeriGonder, true);
        }

        private void seriBaglanti1_PortKapatildi(object sender, NHSeriBaglanti.SeriPortArgs e)
        {
            Delegates.Checked.Set(chckTekrarla, false);
            Delegates.Enabled.Set(grpVeriGonder, false);
        }

        private void seriBaglanti1_VeriAlindi(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = ((SerialPort)sender).ReadExisting();
            AppendText(rtxtAlınan, data);
        }

        private void chckUseRandom_CheckedChanged(object sender, EventArgs e)
        {
            bool _checked = Delegates.Checked.Get(chckUseRandom);
            grpRandom.Enabled = _checked;
        }

        private void btnAlnTemizle_Click(object sender, EventArgs e)
        {
            Optimizasyon.Delagate(rtxtAlınan, () => { rtxtAlınan.Clear(); });
        }

        private void btnGondTemizle_Click(object sender, EventArgs e)
        {
            Optimizasyon.Delagate(rtxtGonderilen, () => { rtxtGonderilen.Clear(); });
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Optimizasyon.Delagate(seriBaglanti1, () => { seriBaglanti1.PortlarıYenile(); });
            
        }
    }
}
