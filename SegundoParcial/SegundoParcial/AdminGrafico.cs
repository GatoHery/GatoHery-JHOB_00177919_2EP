using System;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using Piechart = LiveCharts.WinForms.PieChart;

using System.Windows.Forms;
using LiveCharts.Wpf;

namespace SegundoParcial
{
    public partial class AdminGrafico : UserControl
    {
        private Piechart graficoPastel;
        
        public AdminGrafico()
        {
            InitializeComponent();
            
            graficoPastel = new Piechart();
            this.Controls.Add(graficoPastel);    
        }

        private void configurarGraficoPastel()
        {
            // Posicion (ubicacion) y tamanio
            graficoPastel.Top = 5;
            graficoPastel.Left = 5;
            graficoPastel.Width = 350;
            graficoPastel.Height = 250;

            var dt = ConexionBD.EjecutarConsulta("SELECT b.name AS Negocio, sum(cp.cant) AS pedidos " +
            "FROM BUSINESS b, " + 
            "(SELECT p.idBusiness, p.name, count(ap.idProduct) AS cant " +
            "FROM PRODUCT p, APPORDER ap " +
            "WHERE p.idProduct = ap.idProduct " +
            "GROUP BY p.idProduct " +
            "ORDER BY p.name ASC) AS cp " +
            "WHERE b.idBusiness = cp.idBusiness " +
            "GROUP BY b.idBusiness;");

            // Configuracion de series, leyenda y poblado de datos
            graficoPastel.Series = new SeriesCollection();

            foreach (DataRow dr in dt.Rows)
            {
                graficoPastel.Series.Add(new PieSeries {Title = $"{dr[0].ToString()}", 
                    Values = new ChartValues<int> {Convert.ToInt32(dr[1].ToString())}, DataLabels = true});
            }

            graficoPastel.LegendLocation = LegendLocation.Bottom;
        }

        private void AdminGrafico_Load_1(object sender, EventArgs e)
        {
            configurarGraficoPastel();
        }
    }
}