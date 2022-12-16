using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Fichier 2048_V01._1.Form1
//Auteur Valentin Maurer
//Date de création 14.11.2022
//Dernière modif 07.12.2022
//Description : Création d'un jeu similaire au 2048




namespace _2048_v0._1
{
    public partial class Form1 : Form
    {

        Label[,] lbl = new Label[4, 4]; //Tableau de 4 lignes 4 colonnes
        int[,] aJeu = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } }; //Initalise avec la valeur 0
        int deplacement = 0;


        //Fonction de renvoi des résultats et des tassements 
        private int[] renvoi(int a, int b, int c, int d, out int compteur)

        {
            int[] resultat = new int[4];
            compteur = 0;

            if (c == 0)
            {
                if (d != 0) compteur++;
                             
                c = d;
                d = 0;
                
            }
            if (b == 0) 
            {
                if (c != 0 || d != 0) compteur++;
                b = c;
                c = d;
                d = 0;
            }
            if (a == 0)
            {
                if ((b != 0) || (c != 0) || (d != 0)) compteur++;
                a = b;
                b = c;
                c = d;
                d = 0;
            }
            if (a == b && a != 0)
            {
                compteur++;
                a += b;
                b = c;
                c = d;
                d = 0;
            }
            if (b == c && b != 0)
            {
                compteur++;
                b += c;
                c = d;
                d = 0;
            }
            if (c == d && c != 0)
            {
                compteur++;
                c += d;
                d = 0;
            }

            //renvoie des valeurs selon la table

            resultat[0] = a;
            resultat[1] = b;
            resultat[2] = c;
            resultat[3] = d;

            return resultat;

        }
  
        //Initalise le tableau avec sa taille et ses différentes caractéristiques 
        public Form1()
        {
            InitializeComponent();

            for (int lig = 0; lig < 4; lig++)


                for (int col = 0; col < 4; col++)

                {
                    lbl[lig, col] = new Label(); //création du label
                    lbl[lig, col].Bounds = new Rectangle(110 + 100 * col, 180 + 100 * lig, 90, 90);
                    lbl[lig, col].TextAlign = ContentAlignment.MiddleCenter;
                    lbl[lig, col].Font = new Font("Arial", 20);
                    lbl[lig, col].BackColor = Color.FromArgb(0, 255, 255);
                    lbl[lig, col].Text = "-";
                    lbl[lig, col].ForeColor = Color.White;
                    Controls.Add(lbl[lig, col]); //Ajoute le bouton lblUnique
                }

            Label lblfond = new Label();
            lblfond.BackColor = Color.FromArgb(153, 255, 153);
            lblfond.Bounds = new Rectangle(100, 170, 410, 410);
            lblfond.SendToBack();
            Controls.Add(lblfond);
        }

        private void display() //Boucle pour afficher le contenu du tableau et établir les commandes 
        {
            for (int lig = 0; lig < 4; lig++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (aJeu[lig, col] > 0)
                    {
                        lbl[lig, col].Text = aJeu[lig, col].ToString();
                    }
                    else
                    {
                        lbl[lig, col].Text = "";
                    }
                    switch (aJeu[lig, col])
                    {
                        case 0:
                            lbl[lig, col].BackColor = Color.FromArgb(255, 255, 255); break;
                        case 2:
                            lbl[lig, col].BackColor = Color.FromArgb(204, 229, 255); break;
                        case 4:
                            lbl[lig, col].BackColor = Color.FromArgb(153, 204, 255); break;
                        case 8:
                            lbl[lig, col].BackColor = Color.FromArgb(51, 153, 255); break;
                        case 16:
                            lbl[lig, col].BackColor = Color.FromArgb(0, 128, 255); break;
                        case 32:
                            lbl[lig, col].BackColor = Color.FromArgb(0, 102, 204); break;
                        case 64:
                            lbl[lig, col].BackColor = Color.FromArgb(204, 153, 255); break;
                        case 128:
                            lbl[lig, col].BackColor = Color.FromArgb(178, 102, 255); break;
                        case 256:
                            lbl[lig, col].BackColor = Color.FromArgb(153, 51, 255); break;
                        case 512:
                            lbl[lig, col].BackColor = Color.FromArgb(127, 0, 255); break;
                        case 1024:
                            lbl[lig, col].BackColor = Color.FromArgb(102, 0, 204); break;
                        case 2048:
                            lbl[lig, col].BackColor = Color.FromArgb(255, 0, 0); break;
                        case 4096:
                            lbl[lig, col].BackColor = Color.FromArgb(204, 0, 0); break;
                        case 8092:
                            lbl[lig, col].BackColor = Color.FromArgb(153, 0, 0); break;

                    }
                }
            }

        }
        //Bouton fermer 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Initalisation du jeu avec 8 Valeurs afin de les tasser dans toute les directions. 
            aJeu[0, 0] = 2;
            aJeu[0, 1] = 2;
            aJeu[0, 2] = 0;
            aJeu[0, 3] = 0;
            aJeu[1, 0] = 2;
            aJeu[1, 1] = 2;
            aJeu[1, 2] = 0;
            aJeu[1, 3] = 0;
            aJeu[2, 0] = 4;
            aJeu[2, 1] = 8;
            aJeu[2, 2] = 0;
            aJeu[2, 3] = 0;
            aJeu[3, 0] = 2;
            aJeu[3, 1] = 2;
            aJeu[3, 2] = 0;
            aJeu[3, 3] = 0;
            display();

        }
        //Fonction test pour tassement 
        private void button1_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            int[] Tresult = renvoi(Int32.Parse(valeura.Text), Int32.Parse(valeurb.Text), Int32.Parse(valeurc.Text), Int32.Parse(valeurd.Text), out compteur);
            Rtasse.Text = Tresult[0].ToString() + " " + Tresult[1].ToString() + " " + Tresult[2].ToString() + " " + Tresult[3].ToString();
        }

        //Activer désactiver la fonction test
        private void activerDésactiverTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                button1.Enabled = false;
                valeura.Enabled = false;
                valeurb.Enabled = false;
                valeurc.Enabled = false;
                valeurd.Enabled = false;
                Rtasse.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                valeura.Enabled = true;
                valeurb.Enabled = true;
                valeurc.Enabled = true;
                valeurd.Enabled = true;
                Rtasse.Enabled = true;
            }
        }

        //Fonction et boucle pour attraper les touches + déplacer les résultats et afficher. + compteur
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int compteur = 0;
            int compteur2 = 0;

            switch (e.KeyCode)
            {
                case Keys.A:
                    for (int ligne = 0; ligne < 4; ligne++)
                    {
                        int[] Tresult = renvoi(aJeu[ligne,0], aJeu[ligne,1], aJeu[ligne, 2], aJeu[ligne,3], out compteur);
                        aJeu[ligne, 0] = Tresult[0];
                        aJeu[ligne, 1] = Tresult[1];
                        aJeu[ligne, 2] = Tresult[2];
                        aJeu[ligne, 3] = Tresult[3];
                        compteur2 += compteur;                      
                    }
                    break;
                case Keys.D:
                    for (int ligne = 0; ligne < 4; ligne++)
                    {
                        int[] Tresult = renvoi(aJeu[ligne, 3], aJeu[ligne, 2], aJeu[ligne, 1], aJeu[ligne, 0],out compteur);
                        aJeu[ligne, 3] = Tresult[0];
                        aJeu[ligne, 2] = Tresult[1];
                        aJeu[ligne, 1] = Tresult[2];
                        aJeu[ligne, 0] = Tresult[3];
                        compteur2 += compteur;
                    }
                    break;
                case Keys.S:
                    for (int colonne = 0; colonne < 4; colonne++)
                    {
                        int[] Tresult = renvoi(aJeu[3, colonne], aJeu[2, colonne], aJeu[1, colonne], aJeu[0, colonne],out compteur);
                        aJeu[3, colonne] = Tresult[0];
                        aJeu[2, colonne] = Tresult[1];
                        aJeu[1, colonne] = Tresult[2];
                        aJeu[0, colonne] = Tresult[3];
                        compteur2 += compteur;
                    }

                    break;
                case Keys.W:
                    for (int colonne = 0; colonne < 4; colonne++)
                    {
                        int[] Tresult = renvoi(aJeu[0, colonne], aJeu[1, colonne], aJeu[2, colonne], aJeu[3, colonne],out compteur);
                        aJeu[0, colonne] = Tresult[0];
                        aJeu[1, colonne] = Tresult[1];
                        aJeu[2, colonne] = Tresult[2];
                        aJeu[3, colonne] = Tresult[3];
                        compteur2 += compteur;
                    }
                    break;

            }

            //Création du tableau pour pouvoir randomiser l'affichage de 2^1 et 2^2


            //Possible génération random du nombre 
            //Positionner aléatoirement en début de partie 2^1
            //aJeu[RandomPos(), RandomPos()] = 2; // != 1 ? 2 : 4; // 3/4 chance pour avoir 2, 1/4 chance pour avoir 4

            private int RandomPos()
            {
                var rand = new Random();
                return rand.Next(4);
            }

            void addtile()
            {
                List<int> maliste = new List<int>();
                int compteur_liste = 0;

                for (int ligne = 0; ligne < 4; ligne++)
                {
                    for (int colonne = 0; colonne < 4; colonne++)
                    {
                        if (aJeu[ligne, colonne] != 0) maliste.Add(aJeu[ligne, colonne]);
                    }
                    compteur_liste++;
                }


               

                   
            }

            void btnRemplitListe_Click(object sender, EventArgs e)
            {
                //Ajouter à la liste tous les éléments non nuls du tableau

            }

            void btnAfficheListe_Click(object sender, EventArgs e)
            {
                //Afficher toute la liste mémoire dans la listbox (avec effacement au début)
                lstListe.Items.Clear();
                foreach (int i in maliste)
                    lstListe.Items.Add(i);
            }





            display();
            labelcompteur.Text = "Votre nombre de déplacement " + compteur2.ToString();
        }
    }
}