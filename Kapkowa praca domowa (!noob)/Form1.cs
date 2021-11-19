using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;

namespace Kapkowa_praca_domowa___noob_
{
    public partial class Altair : Form
    {
        bool lewo, prawo;
        int predkoscGracza = 5;
        int punkty = 0;
        Random random = new Random();
        List<klocek> nubkuw = new List<klocek>();
        bool GameOver;
        int losowanieBonusuw = 0;
        int combo = 0;
        string sciezkaDoMuzyki;
        int predkoscMin;
        int predkoscMax;
        int ktoraSekunda;
        MediaPlayer muzyka = new MediaPlayer();
        Timer timerMuzyki = new Timer();
        Timer flash = new Timer();
        Timer progressMuzyki =  new Timer();
        bool flashTick;
        int ileTickow = 0;
        int ileFlashow = 0;
        int rzycko = 99;
        bool czyWin;
        int proby = 0;
        DiscordWebHook discord = new DiscordWebHook();

        public Altair()
        {
            InitializeComponent();
            Console.WriteLine(this.ClientSize.Width);
            wzowienie.Visible = false;
            przegranaLabel.Visible = false;
            skinyLabel.Visible = true;
            skinCzerwony.Visible = true;
            skinPomaranczowy.Visible = true;
            skinRóżowy.Visible = true;
            skinCyan.Visible = true;
            skinBialasa.Visible = true;
            winLabel.Visible = false;
            istrukcjaLabel.Visible = false;
            czyWin = false;
            sciezkaDoMuzyki = Path.Combine(Path.GetTempPath(), "muzyka.mp3");
            File.WriteAllBytes(sciezkaDoMuzyki, Properties.Resources.Kindrid___Altair);
            muzyka.Open(new Uri(sciezkaDoMuzyki));
            muzyka.Volume = 0.05;
            timerMuzyki = new Timer();
            timerMuzyki.Interval = 500;
            timerMuzyki.Tick += TimerMuzyki_Tick;
            flash.Interval = 100;
            flash.Tick += Flash_Tick;
            progressMuzyki.Interval = 1950;
            progressMuzyki.Tick += ProgressMuzyki_Tick;


        }

        private void ProgressMuzyki_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                (sender as Timer).Stop(); // Jeżeli progressBar się zapełni to przestań liczyć.
                czyWin = true;
                if (czyWin)
                {
                    wyslijWiadomoscDiscord(Environment.UserName + " wygrał z wynikiem " + punkty + " punktów." + "Życia: " + rzycko);
                    usuwanieNubkuw();
                    animacja.Stop();
                    winLabel.Visible = true;
                    istrukcjaLabel.Visible = true;
                }

            }
        }

        private void Flash_Tick(object sender, EventArgs e)
        {
            ileTickow++;
            if (!flashTick)
            {
                this.BackColor = System.Drawing.Color.White;
                flashTick = true;

            }
            else
            {
                this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                flashTick = false;
            }
            if (ileTickow == ileFlashow) 
            {
                ileTickow = 0;
                (sender as Timer).Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                lewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = false;
            }
        }

        private void animacja_Tick(object sender, EventArgs e)
        {
            if (lewo & Gracz.Left > 10)
            {
                Gracz.Left -= predkoscGracza;
            }
            if (prawo & Gracz.Left < 336)
            {
                Gracz.Left += predkoscGracza;
            }
            foreach (var item in nubkuw)
            {
                // Animation of the boxes
                item.picturebox.Top += item.predkosckloca;
                if (item.picturebox.Top > 667)
                {
                    ItemGoUp(item);
                    if (item.czyDobry)
                    {
                        combo = 0;
                        comboLabel.Text = "Combo: " + combo + "x";
                    }
                }
                //Colision box
                if (item.picturebox.Bounds.IntersectsWith(Gracz.Bounds))
                {
                    if (item.czyBonus)
                    {
                        ItemGoUp(item);
                        if (rzycko < 3)
                        {
                            rzycko++;
                        }
/*                        if (rzycko > 3 & !godMode.Checked)
                        {
                            rzycko = 3;
                        }*/
                        if (rzycko == 3)
                        {
                            zycko3.Value = 100;
                        }
                        if (rzycko == 2)
                        {
                            zycko2.Value = 100;
                        }
                        if (rzycko == 1)
                        {
                            zycko2.Value = 0;
                        }
                    }
                    else if (item.czyDobry)
                    {
                        combo++;
                        comboLabel.Text = "Combo: " + combo + "x";
                        punkty += 1 * combo;
                        punktyLabel.Text = "Punkty: " + punkty;
                        ItemGoUp(item);
                    }
                    else
                    {
                        ItemGoUp(item);
                        rzycko--;
                        if (rzycko == 3)
                        {
                            zycko3.Value = 100;
                        }
                        if (rzycko == 2)
                        {
                            zycko3.Value = 0;
                            zycko2.Value = 100;
                        }
                        if (rzycko == 1)
                        {
                            zycko2.Value = 0;
                        }
                        if (rzycko == 0)
                        {
                            zycko1.Value = 0;
                            animacja.Stop();
                            punktyLabel.Text = "Punkty: " + punkty;
                            istrukcjaLabel.Visible = true;
                            przegranaLabel.Visible = true;
                            godMode.Visible = true;
                            GameOver = true;
                            muzyka.Stop();
                        }

                    }


                }

            }
        }

        private void ItemGoUp(klocek item)
        {
            item.picturebox.Top = random.Next(-500, 0);
            item.picturebox.Left = random.Next(0, 346);
            item.predkosckloca = random.Next(predkoscMin, predkoscMax);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MMM PRZYCISKI
            if (e.KeyCode == Keys.Left)
            {
                lewo = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                prawo = true;
            }
            if (e.KeyCode == Keys.Space & GameOver)
            {
                czyWin = false;
                timerMuzyki.Stop();
                resetGry();
                muzyka.Play();
            }
            if (e.KeyCode == Keys.Escape & !GameOver)
            {
                animacja.Stop();
                wzowienie.Visible = true;
                skinyLabel.Visible = true;
                skinCzerwony.Visible = true;
                skinPomaranczowy.Visible = true;
                skinRóżowy.Visible = true;
                skinCyan.Visible = true;
                skinBialasa.Visible = true;
                muzyka.Pause();
            }
            if (e.KeyCode == Keys.Space & czyWin)
            {
                timerMuzyki.Stop();
                resetGry();
                muzyka.Play();
            }

        }

        private async void resetGry()
        {
            muzyka.Stop();
            proby++;
            animacja.Start();
            muzyka.Play();
            przegranaLabel.Visible = false;
            godMode.Visible = false;
            winLabel.Visible = false;
            istrukcjaLabel.Visible = false;
            progressMuzyki.Stop();
            progressBar1.Value = 0;
            progressMuzyki.Start();
            ileTickow = 0;
            predkoscGracza = 5;
            ktoraSekunda = 0;
            punkty = 0;
            probyLabel.Text = "Próby: " + proby;
            punktyLabel.Text = "Punkty: 0";
            comboLabel.Text = "Combo: 0x";
            GameOver = false;
            czyWin = false;

            godmod();
            usuwanieNubkuw();
            timerMuzyki.Start();
            zycko1.Value = 100;
            await Task.Delay(600);
            zycko2.Value = 100;
            await Task.Delay(600);
            zycko3.Value = 100;
        }

        private void TimerMuzyki_Tick(object sender, EventArgs e)
        {
            if (!GameOver)
            {
                ktoraSekunda++;
                if (ktoraSekunda == 1)
                {
                    predkoscMin = 2;
                    predkoscMax = 5;
                    dodawanieNubkow(5, 0, 1);
                }
                if (ktoraSekunda == 30)
                {
                    usuwanieNubkuw();
                    //FLASHE SA TUTAJ
                    ileFlashow = 10;
                    flash.Interval = 20;
                    flash.Start();
                    predkoscMin = 3;
                    predkoscMax = 5;
                    dodawanieNubkow(5, 3, 1);
                }
                if (ktoraSekunda == 60)
                {
                    usuwanieNubkuw();
                    predkoscMin = 9;
                    predkoscMax = 14;
                    dodawanieNubkow(7, 4, 1);
                }
                if (ktoraSekunda == 118)
                {
                    predkoscMin = 4;
                    predkoscMax = 6;
                }
                if (ktoraSekunda == 174)
                {
                    predkoscMin = 7;
                    predkoscMax = 9;
                }
                if (ktoraSekunda == 220)
                {
                    usuwanieNubkuw();
                    predkoscMin = 2;
                    predkoscMax = 3;
                    dodawanieNubkow(0, 0, 1);
                }
                if (ktoraSekunda == 240)
                {
                    usuwanieNubkuw();
                    predkoscGracza = 10;
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 3, 1);
                }
                if (ktoraSekunda == 255)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 256)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 257)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 258)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 270)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 271)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 272)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 273)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 284)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 285)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 286)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 287)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 300)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 15;
                    predkoscMax = 19;
                    dodawanieNubkow(15, 0, 1);
                }
                if (ktoraSekunda == 301)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 302)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 303)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 314)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 315)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 316)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 317)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 330)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 331)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 332)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 333)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 334)
                {
                    usuwanieNubkuw();
                    ileFlashow = 4;
                    flash.Interval = 500;
                    flash.Start();
                    predkoscMin = 9;
                    predkoscMax = 12;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 344)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 345)
                {
                    usuwanieNubkuw();
                    predkoscMin = 10;
                    predkoscMax = 14;
                    dodawanieNubkow(0, 10, 1);
                }
                if (ktoraSekunda == 346)
                {
                    usuwanieNubkuw();
                    predkoscMin = 12;
                    predkoscMax = 16;
                    dodawanieNubkow(6, 4, 1);
                }
                if (ktoraSekunda == 359)
                {
                    usuwanieNubkuw();
                    predkoscGracza = 5;
                    ileFlashow = 4;
                    flash.Interval = 50;
                    flash.Start();
                    predkoscMin = 3;
                    predkoscMax = 5;
                    dodawanieNubkow(5, 3, 1);
                }
            }
        }

        private void dodawanieNubkow(int dobre, int zle, int bonus)
        {
            for (int i = 0; i < dobre; i++)
            {
                klocek klocek = new klocek(random.Next(predkoscMin, predkoscMax), true, twuszboxa(1), false);
                nubkuw.Add(klocek);
            }
            for (int i = 0; i < zle; i++)
            {
                klocek klocek = new klocek(random.Next(predkoscMin, predkoscMax), false, twuszboxa(1), false);
                nubkuw.Add(klocek);
            }
            for (int i = 0; i < bonus; i++)
            {
                klocek klocek = new klocek(random.Next(predkoscMin, predkoscMax), true, twuszboxa(1), true);
                nubkuw.Add(klocek);
            }
        }

        private void usuwanieNubkuw()
        {
            foreach (var item in nubkuw)
            {
                this.Controls.Remove(item.picturebox);
            }
            nubkuw.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //WYŁĄCZENIE PAUZY
            animacja.Start();
            wzowienie.Visible = false;
            skinyLabel.Visible = false;
            skinCzerwony.Visible = false;
            skinPomaranczowy.Visible = false;
            skinRóżowy.Visible = false;
            skinCyan.Visible = false;
            skinBialasa.Visible = false;
            muzyka.Play();
        }

        private void skinCzerwony_Click(object sender, EventArgs e)
        {
            Gracz.BackColor = System.Drawing.Color.Red;
        }

        private void skinPomaranczowy_Click(object sender, EventArgs e)
        {
            Gracz.BackColor = System.Drawing.Color.Orange;
        }

        private void skinCyan_Click(object sender, EventArgs e)
        {
            Gracz.BackColor = System.Drawing.Color.Cyan;
        }

        private void skinRóżowy_Click(object sender, EventArgs e)
        {
            Gracz.BackColor = System.Drawing.Color.Fuchsia;
        }

        private void skinBialasa_Click(object sender, EventArgs e)
        {
            Gracz.BackColor = System.Drawing.Color.White;
        }

        private void zaczynamy_Click(object sender, EventArgs e)
        {

        }

        private void wyslijWiadomoscDiscord(string wiadomosc)
        {
            discord.discordValues.Clear();
            discord.ProfilePicture = "https://i1.sndcdn.com/artworks-000504612612-m44zip-t500x500.jpg";
            discord.UserName = "ALTAIR";
            discord.WebHook = "https://discord.com/api/webhooks/910634339291766785/C6p58iufheZzGEq3xoPIqxO840_IXvLOEsnH4XHj4DnbRZ67tcnPh98R0R1oftvQpnkT";
            discord.SendMessage(wiadomosc);
        }

        private void godMode_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void godmod()
        {
            if (godMode.Checked)
            {
                rzycko = 999;
            }
            else
            {
                rzycko = 3;
            }
        }

        private void zaczynamyGre(object sender, MouseEventArgs e)
        {
            resetGry();
            skinyLabel.Visible = false;
            skinCzerwony.Visible = false;
            skinPomaranczowy.Visible = false;
            skinRóżowy.Visible = false;
            skinCyan.Visible = false;
            skinBialasa.Visible = false;
            zaczynamy.Visible = false;
            muzyka.Play();
        }

        private PictureBox twuszboxa(int ile)
        {
            PictureBox pictureBox1 = new PictureBox();
            for (int i = 0; i < ile; i++)
            {
                //CO TO KUR JEST
                pictureBox1.Location = new Point(random.Next(0, 346), random.Next(0, 200));
                pictureBox1.BackColor = System.Drawing.Color.White;
                pictureBox1.Size = new Size(56, 56);
                pictureBox1.Top = random.Next(-500, 0);
                this.Controls.Add(pictureBox1);

            }
            return pictureBox1;
        }
    }
}