using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardOptimizer
{
	internal class MissionManager
	{
		public Mission[] missions;

		public void init(Mission[] missions)
		{
			this.missions = missions;
		}
	}
}
