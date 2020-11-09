using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaLaskuriForm
{
    public partial class PizzaLaskuri : Form
    {
        pizzaResepti pizzaResepti = new pizzaResepti();
        lastenResepti lastenResepti = new lastenResepti();
        perheResepti perheResepti = new perheResepti();

        public double resultJauhotLasten;
        public double resultVesiLasten;
        public double resultSuolaLasten;
        public double resultHiivaLasten;
        public double resultJauhotNormaali;
        public double resultVesiNormaali;
        public double resultSuolaNormaali;
        public double resultHiivaNormaali;
        public double resultJauhotPerhe;
        public double resultVesiPerhe;
        public double resultSuolaPerhe;
        public double resultHiivaPerhe;
        


        public PizzaLaskuri()
        {
            InitializeComponent();
        }

        public void lastenBox_TextChanged(object sender, EventArgs e)
        {
            double lastenPizzaCount = 0;
            if (string.IsNullOrEmpty(lastenBox.Text))
            {
            }
            else if (!double.TryParse(lastenBox.Text, out lastenPizzaCount))
            {
                MessageBox.Show("Error. You must enter valid numbers. Please correct.");
                lastenBox.Select(0, lastenBox.Text.Length);
            }
             else
            {
                resultJauhotLasten = lastenPizzaCount * lastenResepti.Jauhot / 1000;
                resultVesiLasten = lastenPizzaCount * lastenResepti.Vesi / 1000;
                resultSuolaLasten = lastenPizzaCount * lastenResepti.Suola;
                resultHiivaLasten = lastenPizzaCount * lastenResepti.Hiiva;
            }

        }

        public void normaaliBox_TextChanged(object sender, EventArgs e)
        {
            double normalPizzaCount = 0;
           
            if (string.IsNullOrEmpty(normaaliBox.Text))
            {
            }
            else if (!double.TryParse(normaaliBox.Text, out normalPizzaCount))
            {
                MessageBox.Show("Error. You must enter valid numbers. Please correct.");
                lastenBox.Select(0, normaaliBox.Text.Length);//   
            }
            
            else
            {
                resultJauhotNormaali = normalPizzaCount * pizzaResepti.Jauhot / 1000;
                resultVesiNormaali = normalPizzaCount * pizzaResepti.Vesi / 1000;
                resultSuolaNormaali = normalPizzaCount * pizzaResepti.Suola;
                resultHiivaNormaali = normalPizzaCount * pizzaResepti.Hiiva;
            }  
        }

        public void perheBox_TextChanged(object sender, EventArgs e)
        {
            double perhePizzaCount = 0;
            if (string.IsNullOrEmpty(perheBox.Text))
            {
            }
            else if (!double.TryParse(perheBox.Text, out perhePizzaCount))
            {
                MessageBox.Show("Error. You must enter valid numbers. Please correct.");
                lastenBox.Select(0, perheBox.Text.Length);
            }
            else
            {
                resultJauhotPerhe = perhePizzaCount * perheResepti.Jauhot / 1000;
                resultVesiPerhe = perhePizzaCount * perheResepti.Vesi / 1000;
                resultSuolaPerhe = perhePizzaCount * perheResepti.Suola;
                resultHiivaPerhe = perhePizzaCount * perheResepti.Hiiva;
            }  
        }

        public void resultLastenPizza_Click(object sender, EventArgs e)
        {
           
            if (lastenBox.Text == "")
            {
                MessageBox.Show("Please, fill the box 1");  
            } else 
            {
                resultJauhoaBox.Text = resultJauhotLasten.ToString();
                resultVesiBox.Text = resultVesiLasten.ToString();
                resultSuolaBox.Text = resultSuolaLasten.ToString();
                resultHiivaBox.Text = resultHiivaLasten.ToString();
            }
        }
        private void ResultNormPizza_Click(object sender, EventArgs e)
        {
            if (normaaliBox.Text == "")
            {
                MessageBox.Show("Please, fill the box 2");
            } else
            {
                resultJauhoaBox.Text = resultJauhotNormaali.ToString();
                resultVesiBox.Text = resultVesiNormaali.ToString();
                resultSuolaBox.Text = resultSuolaNormaali.ToString();
                resultHiivaBox.Text = resultHiivaNormaali.ToString();
            }
        }
        

        private void ResultPerhePizza_Click(object sender, EventArgs e)
        {
            if (perheBox.Text == "")
            {
                MessageBox.Show("Please, fill the box 3");
            } else
            {
                resultJauhoaBox.Text = resultJauhotPerhe.ToString();
                resultVesiBox.Text = resultVesiPerhe.ToString();
                resultSuolaBox.Text = resultSuolaPerhe.ToString();
                resultHiivaBox.Text = resultHiivaPerhe.ToString();
            } 
        }

      
        public void kokoReseptiButton_Click(object sender, EventArgs e)
        {
            
            if (lastenBox.Text == "")
            {
                resultJauhotLasten = 0;
                resultVesiLasten = 0;
                resultSuolaLasten = 0;
                resultHiivaLasten = 0;
            }
            if (normaaliBox.Text == "")
            {
                resultJauhotNormaali = 0;
                resultVesiNormaali = 0;
                resultSuolaNormaali = 0;
                resultHiivaNormaali = 0;
            }
            if (perheBox.Text == "")
            {
                resultJauhotPerhe = 0;
                resultVesiPerhe = 0;
                resultSuolaPerhe = 0;
                resultHiivaPerhe = 0;
             }

            double jauhotTotal = resultJauhotLasten + resultJauhotNormaali + resultJauhotPerhe;
            double vesiTotal = resultVesiLasten + resultVesiNormaali + resultVesiPerhe;
            double suolaTotal = resultSuolaLasten + resultSuolaNormaali + resultSuolaPerhe;
            double hiivaTotal = resultHiivaLasten + resultHiivaNormaali + resultHiivaPerhe;
           
            {
                resultJauhoaBox.Text = jauhotTotal.ToString();
                resultVesiBox.Text = vesiTotal.ToString();
                resultSuolaBox.Text = suolaTotal.ToString();
                resultHiivaBox.Text = hiivaTotal.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
