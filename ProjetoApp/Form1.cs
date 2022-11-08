using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Recupera dados do Banco de Dados:
            var lst = new Entities1().Grafico.ToList();

            //Nome das Colunas
            string[] columns = { "Valor A", "Valor B" };
            double[] values = new double[2];

            foreach (var item in lst)
            {
                values[0] = item.QtdA;
                values[1] = item.QtdB;
            }
            
            //Gerar Gráfico
            chart1.Series.Add("Teste");
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(columns, values);
        }
    }
}