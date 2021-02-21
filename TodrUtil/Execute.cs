using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HyoutaTools.mapjis
{
	class Execute
	{
		public static int InitPseudoShiftJis(List<string> args)
		{
			if (args.Count != 1)
			{
				Console.WriteLine("Map JIS characters: DestinyRemake.exe mapjis 000014");
				return -1;
			}

			string binpath = args[0];

/*			Write code to take file "000014" and out put a table
 			TBL tbl = new TBL();
			tbl.Load(System.IO.File.ReadAllBytes(tblpath));
			System.IO.FileStream fs = new System.IO.FileStream(binpath, System.IO.FileMode.Open);
			tbl.Extract(fs, binpath + ".ex");*/

			return 0;
		}
	}
}