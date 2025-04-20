using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardOptimizer
{
	internal class Mission
	{
		private string name;
		private int id;
		private string[,] instructions;
		private bool is_enabled;
		private string start_time;
		public enum status { Success, Fail, Running, Stopped};
		private status st;

		public Mission(string name)
		{
			this.name = name;
		}

		public string getName()
		{
			return name;
		}

		public int getId()
		{
			return id;
		}

		public status getStatus()
		{
			return st;
		}

		public void start()
		{
			
		}

		public void stop()
		{
			
		}

		public void enableMission()
		{
			if()
			is_enabled = true;
		}

		public void disableMission()
		{
			if (getStatus() == status.Running)
				stop();
			is_enabled=false;
		}
	}
}
