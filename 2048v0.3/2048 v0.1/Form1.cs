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
//Dernière modif 19.12.2022
//Description : Création d'un jeu similaire au 2048




namespace _2048_v0._1
{
    public partial class Form1 : Form
    {
        //Tableau de 4 lignes 4 colonnes
        Label[,] lbl = new Label[4, 4];

        //Initalise avec la valeur 0
        int[,] aJeu = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        //Déclaration en bool pour fonction gagner 
        bool gagner = false;

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
                    lbl[lig, col].Bounds = new Rectangle(775 + 100 * col, 315 + 100 * lig, 90, 90);
                    lbl[lig, col].TextAlign = ContentAlignment.MiddleCenter;
                    lbl[lig, col].Font = new Font("Arial", 20);
                    lbl[lig, col].BackColor = Color.FromArgb(0, 255, 255);
                    lbl[lig, col].Text = "-";
                    lbl[lig, col].ForeColor = Color.White;
                    Controls.Add(lbl[lig, col]); //Ajoute le bouton lblUnique
                }

            Label lblfond = new Label();
            lblfond.BackColor = Color.Black;
            lblfond.Bounds = new Rectangle(755, 293, 431, 431); //la moitié de l'écran -205
            lblfond.SendToBack();
            Controls.Add(lblfond);
        }

        //Boucle pour afficher le contenu du tableau et établir les commandes 
        private void display()
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
        //Fonction check list
        List<int> checklist()
        {
            List<int> maliste = new List<int>();
            for (int ligne = 0; ligne < 4; ligne++)
            {
                for (int colonne = 0; colonne < 4; colonne++)
                {
                    if (aJeu[ligne, colonne] == 0) maliste.Add(ligne * 4 + colonne);
                }
            }
            return maliste;
        }

        //Fonctione pour ajouter une tuile supplémentaire lors d'un déplacement
        void addtile()
        {
            List<int> maliste = new List<int>();
            var rand = new Random();
            maliste = checklist();

            //Créer le random

            int randoml = rand.Next(maliste.Count);
            int randomv = rand.Next(4);

            if (randomv == 0)
            {
                aJeu[maliste[randoml] / 4, maliste[randoml] % 4] = 4;
            }
            else
            {
                aJeu[maliste[randoml] / 4, maliste[randoml] % 4] = 2;
            }
        }

        //Bouton fermer 
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Initalisation du jeu avec 2 Valeurs de 2 afin de commencer la partie 
            addtile();
            addtile();


            //Initialisation du jeu avec 2x1024 et tableau quasi plein pour test par M.Chavey. 
            aJeu[0, 0] = 8;
            aJeu[0, 1] = 16;
            aJeu[0, 2] = 8;
            aJeu[0, 3] = 16;
            aJeu[1, 0] = 32;
            aJeu[1, 1] = 64;
            aJeu[1, 2] = 128;
            aJeu[1, 3] = 128;
            aJeu[2, 0] = 4;
            aJeu[2, 1] = 8;
            aJeu[2, 2] = 512;
            aJeu[2, 3] = 32;
            aJeu[3, 0] = 64;
            aJeu[3, 1] = 128;
            aJeu[3, 2] = 1024;
            aJeu[3, 3] = 1024;

            display();

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
                        int[] Tresult = renvoi(aJeu[ligne, 0], aJeu[ligne, 1], aJeu[ligne, 2], aJeu[ligne, 3], out compteur);
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
                        int[] Tresult = renvoi(aJeu[ligne, 3], aJeu[ligne, 2], aJeu[ligne, 1], aJeu[ligne, 0], out compteur);
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
                        int[] Tresult = renvoi(aJeu[3, colonne], aJeu[2, colonne], aJeu[1, colonne], aJeu[0, colonne], out compteur);
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
                        int[] Tresult = renvoi(aJeu[0, colonne], aJeu[1, colonne], aJeu[2, colonne], aJeu[3, colonne], out compteur);
                        aJeu[0, colonne] = Tresult[0];
                        aJeu[1, colonne] = Tresult[1];
                        aJeu[2, colonne] = Tresult[2];
                        aJeu[3, colonne] = Tresult[3];
                        compteur2 += compteur;

                    }
                    break;
            }
            if (compteur2 != 0)
            {
                addtile();
            }
            display();

            //Bool true, pour avoir le message box qui ne s'affiche qu'à la première itération de "2048"
            //Aide par Maïkol pour la compréhension du système de BOOL (écriture de la fonction perso)
            if (!gagner)
            {
                for (int ligne = 0; ligne < 4; ligne++)
                {
                    for (int colonne = 0; colonne < 4; colonne++)
                    {
                        if (aJeu[ligne, colonne] == 2048)
                        {
                            MessageBox.Show("BRAVO VOUS AVEZ GAGNE");
                            gagner = true;
                        }
                    }
                }
            }
            //Appelle fonction perdu et affichage du message perdu, check du tableau si valeur == 0 et qu'aucun déplacement n'est possible 
            //Aide pour la fonction perdu par Mathieu. Et débug par Maïkol 

            int perdu1 = 0;
            List<int> listeperdu = checklist();

            if (listeperdu.Count == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (perdu(aJeu[0, i], aJeu[1, i], aJeu[2, i], aJeu[3, i]))
                    {
                        perdu1++;
                    }
                    if (perdu(aJeu[i, 0], aJeu[i, 1], aJeu[i, 2], aJeu[i, 3]))
                    {
                        perdu1++;
                    }
                }
                if (perdu1 == 0)
                {
                    MessageBox.Show("VOUS AVEZ PERDU");
                }

            }

            //Label pour afficher le nombre de déplacement 
            labelcompteur.Text = "Votre nombre de déplacement " + compteur2.ToString();

        }
        //Fonction perdu, return true ou false selon conditions 
        bool perdu(int a, int b, int c, int d)

        {
            int compteur = 0;
            if (a == b && a != 0)
            {
                compteur++;

            }
            if (b == c && b != 0)
            {
                compteur++;

            }
            if (c == d && c != 0)
            {
                compteur++;
            }
            if (compteur == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Credit du jeu
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ce jeu a été crée par Valentin Maurer dans le cadre du CPNV");
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Version du jeu
        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 0.3");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Bouton nouvelle partie. Clear le tableau puis placer 2 nouvelles tuiles 
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int ligne = 0; ligne < 4; ligne++)
            {
                for (int colonne = 0; colonne < 4; colonne++)
                {
                    aJeu[ligne, colonne] = 0;
                }
            }
            addtile();
            addtile();
            display();
        }
    }
}