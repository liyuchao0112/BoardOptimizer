using System.Text.Json;

namespace BoardOptimizer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Mission mission = new Mission("Mission Accomplshed");
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.IncludeFields = true;
			textBox1.Text=JsonSerializer.Serialize(mission,options);
			FileOperation.jsonToFile(mission, "./mission.json");
		}
	}
}
