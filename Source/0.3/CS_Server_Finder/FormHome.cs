// Counter Strike Server Finder 0.3
// © Ismael Heredia , Argentina , 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;

namespace CS_Server_Finder
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            buscar_now();
        }

        public void buscar_now()
        {
            SoundPlayer sound = new SoundPlayer(CS_Server_Finder.Properties.Resources.click);
            sound.Play();

            List<string> lista_nombres = new List<string> { };
            List<string> lista_cantidad_jugadores = new List<string> { };
            List<string> lista_mapas = new List<string> { };
            List<string> lista_ips = new List<string> { };

            lvServersFound.Items.Clear();
            lbServersFound.Items.Clear();

            status.Text = "[+] Searching  - Please Wait -";
            this.Refresh();

            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";

            string codigofuente1 = "";
            string codigofuente2 = "";
            string codigofuente3 = "";

            if (cmbType.Text == "Search By Current Map")
            {

                codigofuente1 = web.DownloadString("http://www.gametracker.com/search/cs/?search_by=map&query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=1");
                codigofuente2 = web.DownloadString("http://www.gametracker.com/search/cs/?search_by=map&query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=2");
                codigofuente3 = web.DownloadString("http://www.gametracker.com/search/cs/?search_by=map&query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=3");

            }
            else
            {

                codigofuente1 = web.DownloadString("http://www.gametracker.com/search/cs/?query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=1");
                codigofuente2 = web.DownloadString("http://www.gametracker.com/search/cs/?query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=2");
                codigofuente3 = web.DownloadString("http://www.gametracker.com/search/cs/?query=" + txtSearch.Text + "&sort=c_numplayers&order=DESC&searchipp=50&searchpge=3");

            }
                    
            string codigofuente = codigofuente1 + codigofuente2 + codigofuente3;

            Match search1 = Regex.Match(codigofuente, "<a class=\"c03serverlink\" href=\"(.*)\">\\s*(.*)\\s*</a>", RegexOptions.IgnoreCase);
            while (search1.Success)
            {
                string nombre = search1.Groups[2].Value;
                string ip = "";
                string ip_cortar = search1.Groups[1].Value;

                nombre = nombre.Replace("&bull;", "");
                nombre = nombre.Replace("&gt;", "");
                nombre = nombre.Replace("&lt;", "");
                nombre = nombre.Replace("&requo;", "");
                nombre = nombre.Replace("&raquo;", "");
                nombre = nombre.Replace("&laquo;", "");
                nombre = nombre.Replace("&copy;", "");
                nombre = nombre.Replace("&reg;", "");
                nombre = nombre.Replace("&#039;", "");
                nombre = nombre.Replace("&trade;", "");
                nombre = nombre.Replace("&hearts;", "");

                lista_nombres.Add(nombre);

                Match cortando = Regex.Match(ip_cortar, "/server_info/(.*)/", RegexOptions.IgnoreCase);
                if (cortando.Success)
                {
                    ip = cortando.Groups[1].Value;
                }
                lista_ips.Add(ip);

                search1 = search1.NextMatch();
            }

            Match search2 = Regex.Match(codigofuente, "<td class=\"c04\">\\s*(.*)\\s*</td>", RegexOptions.IgnoreCase);
            while (search2.Success)
            {
                string cantidad = search2.Groups[1].Value;
                lista_cantidad_jugadores.Add(cantidad);
                search2 = search2.NextMatch();
            }

            Match search3 = Regex.Match(codigofuente, "<td class=\"c08\">\\s*(.*)\\s*</td>", RegexOptions.IgnoreCase);
            while (search3.Success)
            {
                string mapa = search3.Groups[1].Value;
                lista_mapas.Add(mapa);
                search3 = search3.NextMatch();
            }

            for (int i = 0; i <= lista_nombres.Count - 1; i++)
            {
                lbServersFound.Items.Add(lista_ips[i]);
                ListViewItem agregar = new ListViewItem();
                agregar.Text = lista_nombres[i];
                agregar.SubItems.Add(lista_cantidad_jugadores[i]);
                agregar.SubItems.Add(lista_mapas[i]);

                lvServersFound.Items.Add(agregar);

            }

            gbServersFound.Text = "Servers Found [" + lbServersFound.Items.Count + "]";

            if (lbServersFound.Items.Count == 0)
            {
                MessageBox.Show("Not Found");
            }

            status.Text = "[+] Finished";
            this.Refresh();

            SoundPlayer sound2 = new SoundPlayer(CS_Server_Finder.Properties.Resources.scanfin);
            sound2.Play();
        }

        private void copyIPToClipBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ipconpuerto = lbServersFound.Items[lvServersFound.FocusedItem.Index].ToString();
                Clipboard.Clear();
                Clipboard.SetText(ipconpuerto);
                SoundPlayer sound = new SoundPlayer(CS_Server_Finder.Properties.Resources.click);
                sound.Play();
            }
            catch
            {
                //
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(CS_Server_Finder.Properties.Resources.formcreate);
            sound.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gametracker.com");
        }



    }
}
