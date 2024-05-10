using System.Windows.Forms;

namespace Lab8._3.EventsGeneration
{
	public partial class ChartForm : Form
	{
		private double[] _frequencies;

        public ChartForm(double[] frequencies)
        {
			InitializeComponent();

			_frequencies = frequencies;

			for (var i = 1; i <= _frequencies.Length; i++)
			{
				mainChart.Series[0].Points.AddXY(i, _frequencies[i - 1]);
			}
        }
    }
}
