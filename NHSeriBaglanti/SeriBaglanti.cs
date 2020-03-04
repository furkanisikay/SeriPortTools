using Optimizasyon;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace NHSeriBaglanti
{
    public partial class SeriBaglanti : UserControl
    {
        public SeriBaglanti()
        {
            InitializeComponent();
        }

        public event SerialDataReceivedEventHandler VeriAlindi;
        public event EventHandler<SeriPortArgs> PortAcildi;
        public event EventHandler<SeriPortArgs> PortKapatildi;

        private SerialPort serialPort;
        public SerialPort SerialPort
        {
            get { return serialPort; }
            set
            {
                serialPort = value;
                serialPort.DataReceived += SerialPort_DataReceived;
                UpdateSerialPort();
                UpdateBaundrate();
            }
        }

        private void UpdateSerialPort(bool hataGoster = false)
        {
            string port = Delegates.Text.Get(cmbPorts);
            if (!string.IsNullOrEmpty(port))
            {
                try { serialPort.PortName = port; }
                catch (Exception ex)
                {
                    if (hataGoster)
                    {
                        MessageBox.Show("Port ismi ayarlanırken bir hata oluştu!\nHata Açıklaması : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateBaundrate(bool hataGoster = false)
        {
            if (Delegates.SelectedIndex.Get(cmbBaundrate) != -1)
            {
                int baundrate = -1;
                if (int.TryParse(Delegates.Text.Get(cmbBaundrate), out baundrate))
                {
                    try { serialPort.BaudRate = baundrate; }
                    catch (Exception ex)
                    {
                        if (hataGoster)
                        {
                            MessageBox.Show("Baundrate ayarlanırken bir hata oluştu!\nHata Açıklaması : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnBaglanti_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort == null)
                {
                    lblDurum.Text = "SerialPort nesnesi null olamaz";
                }
                else
                {
                    if (cmbPorts.SelectedIndex != -1)
                    {
                        if (btnBaglanti.Text == "Bağlan")
                        {
                            try
                            {
                                Delegates.Enabled.Set(btnBaglanti, false);
                                serialPort.Open();
                                Delegates.BackColor.Set(pboxBaglanti, Color.Green);
                                Delegates.Text.Set(btnBaglanti, "Bağlantıyı Kes");
                                Delegates.Text.Set(lblDurum, "Açık");
                                Delegates.ForeColor.Set(lblDurum, Color.Green);
                                PortAcildi?.Invoke(sender, GetUpdatedArgs());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Port Açılırken bir hata oluştu!\nHata Açıklaması : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                Delegates.Enabled.Set(btnBaglanti, true);
                            }
                        }
                        else
                        {
                            try
                            {
                                Delegates.Enabled.Set(btnBaglanti, false);
                                Delegates.BackColor.Set(pboxBaglanti, Color.Red);
                                serialPort.Close();
                                PortlarıYenile();
                                Delegates.Text.Set(btnBaglanti, "Bağlan");
                                Delegates.Text.Set(lblDurum, "Kapalı");
                                Delegates.ForeColor.Set(lblDurum, Color.Red);
                                PortKapatildi?.Invoke(sender, GetUpdatedArgs());
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Port kapatılırken bir hata oluştu!\nHata Açıklaması : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                Delegates.Enabled.Set(btnBaglanti, true);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bağlantı portu seçilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu!\nHata Mesajı:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PortlarıYenile()
        {
            Optimizasyon.Optimizasyon.Delagate(cmbPorts, () => { cmbPorts.Items.Clear(); cmbPorts.Items.AddRange(SerialPort.GetPortNames()); });
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (VeriAlindi != null)
            {
                VeriAlindi.Invoke(sender, e);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            try
            {
                PortlarıYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu!\nHata Mesajı:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeriBaglanti_Load(object sender, EventArgs e)
        {

        }

        private void cmbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSerialPort(true);
        }

        private void cmbBaundrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBaundrate(true);
        }

        private SeriPortArgs GetUpdatedArgs()
        {
            return new SeriPortArgs(Delegates.Text.Get(cmbPorts), int.Parse(Delegates.Text.Get(cmbBaundrate)));
        }
    }
}
