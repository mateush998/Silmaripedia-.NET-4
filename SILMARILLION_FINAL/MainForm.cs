using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Silmarillion
{
    public partial class MainForm : Form
    {
        

        protected Dictionary<string, string> characters = new Dictionary<string, string>()
        {
            {"Aerin", "aerin"},
            {"Anarion", "anarion"},
            {"Barahir", "barahir"},
            {"Beleg Cuthalion", "beleg"},
            {"Beren", "beren"},
            {"Bilbo Baggins", "bilbo"},
            {"Brandir", "brandir"},
            {"Caranthir", "caranthir"},
            {"Cirdan", "cirdan"},
            {"Dorlas", "dorlas"},
            {"Earendil", "earendil"},
            {"Elendil", "elendil"},
            {"Elrond", "elrond"},
            {"Eol", "eol"},
            {"Eru Lluvatar", "eru"},
            {"Finduilas (córka Orodethra},", "finduilas"},
            {"Fingon", "fingon"},
            {"Finrod", "finrod"},
            {"Frodo Baggins", "frodo"},
            {"Galadriela", "galadriela"},
            {"Gandalf", "gandalf"},
            {"Glaurung", "glaurung"},
            {"Glorfindel", "glorfindel"},
            {"Gothmog", "gothmog"},
            {"Huor", "huor"},
            {"Hurin Thalion", "hurin"},
            {"Idril Celebrindal", "idril"},
            {"Indis", "indis"},
            {"Luthien", "luthien"},
            {"Maglor", "maglor"},
            {"Manwe", "manwe"},
            {"Meliana", "meliana"},
            {"Mim", "mim"},
            {"Miriel", "miriel"},
            {"Morgoth", "morgoth"},
            {"Morwena Eledhwen", "morwena"},
            {"Nienor", "nienor"},
            {"Orodreth (elf),", "orodreth"},
            {"Radagast", "radagast"},
            {"Saruman", "saruman"},
            {"Sauron", "sauron"},
            {"Thingol", "thingol"},
            {"Tuor", "tuor"},
            {"Turgon (elf),", "turgon"},
            {"Turin Turambar", "turin"},
            {"Urwena Lalaith", "lalaith"},
        };

        protected bool characterSelectedManually = true;
       // string contents = File.ReadAllText(@"DATA_BIN\LOG.txt");

       

        public MainForm()
        {
          
            InitializeComponent();
           

            string contents = File.ReadAllText(@"DATA_BIN\LOG.txt");
            switch (contents)
            {
                case "0":
                    (new HelloForm()).Show();
                    
                    break;
            }
            

            this.FormClosed += new FormClosedEventHandler(delegate (object sender, FormClosedEventArgs e) { Application.Exit(); });
            
            foreach (KeyValuePair<string, string> kv in characters)
            {
                lista.Items.Add(kv.Key);
            }
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            Stream otworz;

            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((otworz = dialog.OpenFile()) != null)
                {
                    opis.Text = File.ReadAllText(dialog.FileName);
                }
            }
        }

        private void resetuj_img1_Click(object sender, EventArgs e)
        {
            opis.Text = "";
            postac.Text = "Okno zostało wyczyszczone...";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(postac.Text))
            {
                postac.Text = "Wpisz jakąś postać...";
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCharacter = characters[(string)lista.SelectedItem];

            opis.Text = (new StreamReader(@"DATA_BIN\ch_d\s_" + selectedCharacter + ".txt")).ReadToEnd();

            if (imageShowYes.Checked && characterSelectedManually)
            {
                (new ImageForm()).LoadImage(selectedCharacter, (string)lista.SelectedItem).Show();
            }

            characterSelectedManually = true;
        }

        private void postac_MouseClick(object sender, MouseEventArgs e)
        {
            postac.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        private void szukaj1_Click_1(object sender, EventArgs e)
        {
            string query = postac.Text.ToLower();

            lista.Items.Clear();

            foreach (KeyValuePair<string, string> kv in characters)
            {
                if (kv.Key.ToLower().Contains(query))
                {
                    lista.Items.Add(kv.Key);
                }
            }

            if (lista.Items.Count > 0)
            {
                characterSelectedManually = false;
                lista.SelectedIndex = 0;
                return;
            }

            switch (query)
            {
                case "kutas":
                    postac.Text = "Proszę Państwa, mamy tu śmieszka!";
                    opis.Text = "Człowieku, tu mogą być dzieci! Poza tym... co Ci chodzi po głowie? ;)";
                    break;

                case "chuj":
                    postac.Text = "Baton Ty ch...";
                    opis.Text = "Marzysz o nim, co nie? :3";
                    break;

                case "cipa":
                    postac.Text = "Ale z pani głupia...";
                    opis.Text = "Wulgarnie!";
                    break;

                case "fiut":
                    postac.Text = "Przepraszam czy to panu tak śmierdzi?";
                    opis.Text = "Weź się nim zajmij jak tak o nim myślisz :P";
                    break;

                case "huj":
                    postac.Text = "Piszę się przez 'ch'...";
                    opis.Text = "Żebyś chociaż przeklinać po polsku potrafił drogie dziecie...";
                    break;

                case "pizda":
                    postac.Text = "Pi*** nad głową!";
                    opis.Text = "Chyba musisz być bardzo niespełniony człowieku... ;)";
                    break;

                case "kurwa":
                    postac.Text = "Ej synek!";
                    opis.Text = "Takimi epitetami to sobie do kolegów rzucaj, tutaj kulturka ma być!";
                    break;

                case "jebać":
                    postac.Text = "Jebać po... chociaż w sumie... :/";
                    opis.Text = "Masz bogaty zasób słownictwa, Popek musi być z Ciebie dumny ;)";
                    break;

                case "pierdolić":
                    postac.Text = "Pięknie!";
                    opis.Text = "Ale masz chcice, co? :D";
                    break;

                case "pedał":
                    postac.Text = "Pan jesteś zwykły ped...";
                    opis.Text = "Pedał to jest część od roweru, trochę szacunku do innych ;)";
                    break;

                case "dupa":
                    postac.Text = "Pierwsze Ci to wpadło do głowy, co? ;)";
                    opis.Text = "A teraz drogie dzieci pocałujcie misia w dupę.";
                    break;

                case "kupa":
                    postac.Text = "Dupa, kupa... ludzie... :P";
                    opis.Text = "Kupę sobie strzelę z rana (…) kupa, kupa, kupa śmierdzi, bardzo śmierdzi…";
                    break;

                case "gówno":
                    postac.Text = "Kupa, tylko brzydziej...";
                    opis.Text = "Gówno nie jest złe – miliony much nie mogą się mylić";
                    break;

                case "mateusz":
                    postac.Text = "To ja!!!";
                    opis.Text = "Jest twórcą tego programu :) Mateusz bardzo dziękuję Ci za to, że korzystasz z jego aplikacji :*";
                    (new tenkju()).Show();
                    break;

                case "adrianna":
                    postac.Text = "Adrianna... :3";
                    opis.BackColor = Color.Maroon;
                    opis.ForeColor = Color.Linen;
                    pictureBox1.Image = Bitmap.FromFile(@"DATA_BIN\ch_i\collect\bin\love1.gif");
                    opis.Text = "Piękna dziewczyna... i kochana... i w ogóle... :3 <3 Skarbie jeżeli to czytasz wiedz, że Cię bardzo kocham! <3 :3";
                    break;

                case "mariusz":
                    postac.Text = "Najlepszy Przyjaciel!";
                    opis.Text = "Świetny przyjaciel, kumpel i brat (maruda)!";
                    break;

                case "maciej":
                    postac.Text = "Maciej z zadupia!";
                    opis.Text = "Śmierdzi, pierdzi, ma długie tłuste włosy, ale za to nie ma drugiego tak kochanego brata na całym świecie. To najlepszy brat na całym świecie!!!";
                    break;

                case "beata":
                    postac.Text = "Moja mama!";
                    opis.Text = "Moja kochana mamusia! Bardzo ją kocham! Zawsze gotowa do pomocy, zawsze pomocna. Święta kobieta :)";
                    break;

                case "mieczysław":
                    postac.Text = "Mój tate!";
                    opis.Text = "Twardy człowiek, niezłomny. Potrafi dosadnie powiedzieć co mu leży na sercu i dowalić tak, że aż się w człowieku gotuje, ale to w gruncie bardzo miły starszy Pan :D Bardzo go kocham :)";
                    break;

                case "":
                    postac.Text = "Brak!";
                    opis.Text = "Nie wpisano żadnej postaci i nie wiem czego szukać :(";
                    break;
            }

        }

        private void resetuj1_Click(object sender, EventArgs e)
        {
            postac.Text = "";
            szukaj1_Click_1(this, new EventArgs());
            opis.Text = (new StreamReader(@"DATA_BIN\ch_d\s_default.txt")).ReadToEnd();
        }

        private void zapisz1_Click(object sender, EventArgs e)
        {
            SaveFileDialog zapisuj_dziadu = new SaveFileDialog();

            zapisuj_dziadu.DefaultExt = "*.rtf";
            zapisuj_dziadu.Filter = "Pliki .rtf|*.rtf";

            if (zapisuj_dziadu.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               zapisuj_dziadu.FileName.Length > 0)
            {
                opis.SaveFile(zapisuj_dziadu.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(postac.Text))
            {
                postac.Text = "Wpisz jakąś postać...";
            }
        }

        private void opis_MouseClick(object sender, MouseEventArgs e)
        {
            Form1_Click(sender, new EventArgs());
        }

        private void postac_KeyUp(object sender, KeyEventArgs e)
        {
            szukaj1_Click_1(this, new EventArgs());
        }

        private void imageShowNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void imageShowYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
