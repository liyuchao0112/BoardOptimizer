using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardOptimizer
{
	internal class Mission
	{
		public string name;
		public int id;
		public string[,] instructions;
		public bool is_enabled;
		public string start_time;
		public enum status { Success, Fail, Running, Stopped};
		public status st;
	}
}
