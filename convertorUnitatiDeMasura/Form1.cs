using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertorUnitatiDeMasura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public SistemDeMasura si = new SistemDeMasura();

        private void button1_Click(object sender, EventArgs e)
        {
            si.denumireSistemDeMasura = "Sistem International";

            marimeFizica metru = new marimeFizica();
            metru.marimeaFizicaMasurata = "metru";
            metru.informatii = "distanta";
            metru.explicatie = "se masoara distanta in metrii";
            metru.indicativMarimeFizica = "m";
            metru.simbol = "m";

            unitatedemasura tmp = new unitatedemasura();
            
            tmp.denumireUnitateDeMasura = "unitate";
            tmp.valoareUnitateDeMasura = 1.0f;
            tmp.explicatie = "unitate metru";
            tmp.indicativUnitateDeMasura = "u";
            tmp.marimeaFizica = metru;

           
            si.listadeunitatidemasura.Add(tmp);

            unitatedemasura tmp2 = new unitatedemasura();
            tmp2.denumireUnitateDeMasura = "deca";
            tmp2.valoareUnitateDeMasura = 10.0f;
            tmp2.explicatie = "deca metru";
            tmp2.indicativUnitateDeMasura = "D";
            tmp2.marimeaFizica = metru;

            si.listadeunitatidemasura.Add(tmp2);

            //de adaugat in SisyemDeMasura;

            Text = (si.listadeunitatidemasura[0].valoareUnitateDeMasura / si.listadeunitatidemasura[1].valoareUnitateDeMasura).ToString();
            Text += " = ";
            Text += si.listadeunitatidemasura[0].valoareUnitateDeMasura.ToString();
            Text += " : ";
            Text += si.listadeunitatidemasura[1].valoareUnitateDeMasura.ToString();

        }
    }
}
