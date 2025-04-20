using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace BoardOptimizer
{
	internal static class FileOperation
	{
		public static void jsonToFile<Object>(Object x, string fp)
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.IncludeFields = true;
			string jsonString = JsonSerializer.Serialize(x, options);
			File.WriteAllText(fp, jsonString);
		}	
	}
}
