using flappy_bird.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;




namespace flappy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int velocitaOstacoli = 10;
        int ostacoliSuperati = 0;
        List<Ostacolo> ostacoli = new List<Ostacolo>();
        int larghezzaTubi = 50;
        int altezzaTubi = 170;
        int spazioTraTubi = 144;
        int score = 0;
        bool salto = false;
        bool fineGioco = false;
        bool inizio = false;
        bool ostacoloRimosso = true;
        bool continuare = false;
        bool sceltaFatta = false;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            Terreno.BringToFront();
            foreach (Control c in Pnl.Controls)
            {
                c.MouseDown += GestioneClick_click;
            }
            Pnl.MouseDown += new MouseEventHandler(GestioneClick_click);
            for (int i = 0; i < 3; i++)
            {
                NuovoOstacolo((pg.Top + pg.Width) + (200 * i));
            }
        }

        void MuoviOstacoli()
        {
            if (!fineGioco)
            {
                foreach (Ostacolo ostacolo in ostacoli)
                {
                    ostacolo.Giu.Left -= velocitaOstacoli;
                    ostacolo.Su.Left -= velocitaOstacoli;
                }
                //Aggiunge nuovi ostacoli
                if ((Pnl.Width - (ostacoli[ostacoli.Count - 1].Giu.Left + ostacoli[ostacoli.Count - 1].Giu.Width)) > 200)
                {
                    NuovoOstacolo(Pnl.Width - larghezzaTubi);
                    //Aumenta la velocita degli ostacoli
                    ostacoliSuperati++;
                    if (ostacoliSuperati >= 5 && !(velocitaOstacoli == 50))
                    {
                        velocitaOstacoli++;
                        ostacoliSuperati = 0;
                    }
                }
            }
        }

        private void NuovoOstacolo(int x)
        {

            int numeroCasuale = 0;
            
            if(ostacoli.Count>0)
            do
                numeroCasuale = rnd.Next(-altezzaTubi + 50, Pnl.Left);
            //controlla che l'ostacolo corrente non sia troppo simile rispetto al precedente
            while (ostacoli[ostacoli.Count-1].Giu.Top + 15 > numeroCasuale && ostacoli[ostacoli.Count - 1].Giu.Top - 15 < numeroCasuale);

            //PictureBox pcbGiu = new PictureBox();
            //pcbGiu.SetBounds(x, numeroCasuale, larghezzaTubi, altezzaTubi);
            //pcbGiu.SizeMode = PictureBoxSizeMode.StretchImage;
            //pcbGiu.BackColor = Color.Transparent;
            //pcbGiu.Image = Resources.TuboGiu;
            
            var bounds = new Rectangle(x, numeroCasuale, larghezzaTubi, altezzaTubi);            
            var pcbGiu = CreaImmagineOstacolo(bounds, Resources.TuboGiu);
            Pnl.Controls.Add(pcbGiu);

            //PictureBox pcbSu = new PictureBox();
            //pcbSu.SetBounds(x, altezzaTubi + numeroCasuale + 144, larghezzaTubi, Pnl.Height - Terreno.Height - numeroCasuale - spazioTraTubi);
            //pcbSu.SizeMode = PictureBoxSizeMode.StretchImage;
            //pcbSu.BackColor = Color.Transparent;
            //pcbSu.Image = Resources.TuboSu;
            var altezza = Pnl.Height - Terreno.Height - numeroCasuale - spazioTraTubi;
            bounds = new Rectangle(x, altezzaTubi + numeroCasuale + 144, larghezzaTubi, altezza);
            var pcbSu = CreaImmagineOstacolo(bounds, Resources.TuboSu);
            Pnl.Controls.Add(pcbSu);

            Ostacolo os = new Ostacolo();
            os.Giu = pcbGiu;
            os.Su = pcbSu;
            ostacoli.Add(os);
            pcbGiu.MouseDown += new MouseEventHandler(GestioneClick_click);
            pcbSu.MouseDown += new MouseEventHandler(GestioneClick_click);
        }

        PictureBox CreaImmagineOstacolo(Rectangle r, Image img)
        {
            PictureBox pic = new PictureBox();
            pic.Bounds = r;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BackColor = Color.Transparent;
            pic.Image = img;
            return pic;
        }


        private void timer_Tick(object sender, EventArgs e)
        {

            GestioneSalto();

            if (inizio)
                MuoviOstacoli();

            if (ControlloCollisioni() && !fineGioco)
            {
                fineGioco = true;
            }
            if (fineGioco)
            {
                //Animazione finale
                if (pg.Top >= Terreno.Top)
                {
                    pnl_Lost.Visible = true;
                    if (continuare && sceltaFatta)
                    {
                        Reset();
                        sceltaFatta = false;
                    }
                    else if (!continuare && sceltaFatta)
                    {
                        this.Close();
                        sceltaFatta = false;
                    }
                }
            }
            ModificaPunteggio();
        }

        void GestioneSalto()
        {
            if (fineGioco)
            {
                pg.Image = Resources.BirdDownEnd;
                pg.Top += 10;
            }
            else
            if (salto)
            {
                pg.Image = Resources.BirdUp;
                pg.Top -= 20;
                salto = false;
            }
            else if (!salto && inizio)
            {
                pg.Top += 10;
                pg.Image = Resources.BirdDown;
            }
        }

        void Reset()
        {
            foreach (Ostacolo a in ostacoli)
            {
                Pnl.Controls.Remove(a.Giu);
                Pnl.Controls.Remove(a.Su);
            }
            pg.Top = 219;
            pg.Left = 81;
            ostacoli.Clear();
            score = 0;
            ScoreTxt.Text = score.ToString();
            fineGioco = false;
            pnl_Lost.Visible = false;
            inizio = false;
            pg.Image = Resources.Bird;
            for (int i = 0; i < 3; i++)
            {
                NuovoOstacolo((pg.Top + pg.Width) + (200 * i));
            }
        }

        void ModificaPunteggio()
        {

            for (int i = 0; i < ostacoli.Count; i++)
            {
                //OstacoloRimosso previene che questa condizione sia sempre vera finche l'ostacolo è superato e non viene rimosso 
                if (pg.Left >= ostacoli[i].Giu.Left + ostacoli[i].Giu.Width && ostacoloRimosso)
                {
                    score++;
                    ScoreTxt.Text = score.ToString();
                    ostacoloRimosso = false;
                }
                if (Pnl.Left >= ostacoli[i].Giu.Left + ostacoli[i].Giu.Width)
                {
                    Pnl.Controls.Remove(ostacoli[i].Giu);
                    Pnl.Controls.Remove(ostacoli[i].Su);
                    ostacoli.RemoveAt(i);
                    ostacoloRimosso = true;
                    return;
                }
            }
        }

        private bool ControlloCollisioni()
        {
            if (pg.Bounds.IntersectsWith(Terreno.Bounds))
                return true;
            if (pg.Top <= Pnl.Top)
                return true;
            foreach (Ostacolo ostacolo in ostacoli)
            {             
                    if (pg.Bounds.IntersectsWith(ostacolo.Su.Bounds) || pg.Bounds.IntersectsWith(ostacolo.Giu.Bounds))
                    {
                        return true;
                    }             
            }
            return false;
        }

        private void GestioneClick_click(object sender, MouseEventArgs e)
        {
            salto = true;
            if (!inizio)
                inizio = true;
        }

        private void ContinuareSi_Click(object sender, EventArgs e)
        {
            sceltaFatta = true;
            continuare = true;
        }

        private void ContinuareNo_Click(object sender, EventArgs e)
        {
            sceltaFatta = true;
            continuare = false;
        }

       
    }
}
