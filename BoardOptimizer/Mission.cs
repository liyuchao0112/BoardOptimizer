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
		public string[] Actions;
		public bool is_enabled;
		public string Triggertime;
		public enum status {Success, Fail, Running, Stopped};
		public status st;
	}
}
