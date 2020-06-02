using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs;

namespace pl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"pru.pl" };
            PlEngine.Initialize(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PlQuery cargar = new PlQuery("cargar('pru.bd')");
            cargar.NextSolution();
            Console.WriteLine(si1.Checked);
            if(si1.Checked==true)
            {
                if (si5.Checked == true)
                {
                    PlQuery consulta = new PlQuery("recetade(M,espasmos)");
                    foreach (PlQueryVariables z in consulta.SolutionVariables)
                    {
                        if (z["M"].ToString().Equals("moquillo"))
                        {
                            listBox1.Items.Add("Su perro presenta:\tMoquillo");
                            listBox1.Items.Add("Tratamiento: El veterinario le puede prescribir el uso de ");
                            listBox1.Items.Add("antibióticos de amplio espectro, antipiréticos, analgésicos,");
                            listBox1.Items.Add(" anticonvulsivos, soluciones electrolíticas.");
                            listBox1.Items.Add("");
                        }
                    }
                }
            }
            if (si2.Checked == true)
            {
                if (si4.Checked == true)
                {
                    PlQuery consulta = new PlQuery("recetade(M,duerme)");
                    foreach (PlQueryVariables z in consulta.SolutionVariables)
                    {
                        if (z["M"].ToString().Equals("edad"))
                        {
                            listBox1.Items.Add("Su perro presenta:\tEdad avanzada");
                            listBox1.Items.Add("Tratamiento: Alimentar e hidratar muy bien a el can.");
                            listBox1.Items.Add("");
                        }
                    }
                }
            }
            if (si3.Checked == true)
            {
                if (si10.Checked == true)
                {
                    PlQuery consulta = new PlQuery("recetade(M,diarrea)");
                    foreach (PlQueryVariables z in consulta.SolutionVariables)
                        if (z["M"].ToString().Equals("infeccion"))
                        {
                            listBox1.Items.Add("Su perro presenta:\tInfeccion");
                            listBox1.Items.Add("Tratamiento: Se le proportcionaran ciertos antibioticos.");
                            listBox1.Items.Add("");
                        }
                }
            }
            
            
            if (si6.Checked == true)
            {
                PlQuery consulta = new PlQuery("recetade(M,caidapel)");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    if (z["M"].ToString().Equals("infeccion"))
                    {
                        listBox1.Items.Add("Su perro presenta:\tBacterias");
                        listBox1.Items.Add("Tratamiento: Se le proportcionaran ciertos antibioticos.");
                        listBox1.Items.Add("y debe tener cuidado de que el perro no lastime la herida.");
                        listBox1.Items.Add("");
                    }
            }
            if (si7.Checked == true)
            {
                PlQuery consulta = new PlQuery("recetade(M,tos)");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    if (z["M"].ToString().Equals("clima"))
                    {
                        listBox1.Items.Add("Su perro presenta:\tTos seca");
                        listBox1.Items.Add("Tratamiento: resguardelo en su hogar, ya que el clima.");
                        listBox1.Items.Add("es una causa muy comun de esta tos en los perros.");
                        listBox1.Items.Add("");
                    }
            }
            if (si8.Checked == true)
            {
                if (si10.Checked == true)
                {
                    PlQuery consulta = new PlQuery("recetade(M,diarrea)");
                    foreach (PlQueryVariables z in consulta.SolutionVariables)
                        if (z["M"].ToString().Equals("clima"))
                        {
                            listBox1.Items.Add("Su perro presenta:\tParvovirus");
                            listBox1.Items.Add("Tratamiento: Usar antieméticos como la metoclopramida.");
                            listBox1.Items.Add("en infusión, podria necesitar una transfusión sanguínea.");
                            listBox1.Items.Add("");
                        }
                }
            }
            if (si9.Checked == true)
            {
                PlQuery consulta = new PlQuery("recetade(M,espuma)");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    if (z["M"].ToString().Equals("rabia"))
                    {
                        listBox1.Items.Add("Su perro presenta:\tRabia");
                        listBox1.Items.Add("Tratamiento: llévelo con su veterinario cuanto antes.");
                        listBox1.Items.Add("");
                    }
            }
            
            
            /*
            listBox1.Items.Clear();
            PlQuery cargar = new PlQuery("cargar('pru.bd')");
            cargar.NextSolution();
            
            if(checkBox1.Checked==true)
            {
                PlQuery consulta = new PlQuery("recetade(M,"+ valor + ")");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    listBox1.Items.Add(z["M"].ToString());
            }
            if (checkBox2.Checked == true)
            {
                PlQuery consulta = new PlQuery("atiende_especialista(E," + valor + ")");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    listBox1.Items.Add(z["E"].ToString());
            }
            if (checkBox3.Checked == true)
            {
                PlQuery consulta = new PlQuery("mereseta(Es,M," + valor + ")");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    listBox1.Items.Add(z["Es"].ToString());
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    listBox1.Items.Add(z["M"].ToString());
            }
            */
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
