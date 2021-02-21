using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HyoutaTools.unpack
{
	class Execute
	{
		public static int Extract(List<string> args)
		{
			if (args.Count != 2)
			{
				Console.WriteLine("Unpack DAT: DAT.TBL DAT.BIN");
				Console.WriteLine("Unpack MOV: MOV.TBL MOV.BIN");
				return -1;
			}

			string tblpath = args[0];
			string binpath = args[1];

			TBL tbl = new TBL();
			tbl.Load(System.IO.File.ReadAllBytes(tblpath));
			System.IO.FileStream fs = new System.IO.FileStream(binpath, System.IO.FileMode.Open);
			tbl.Extract(fs, binpath + ".ex");

			return 0;
		}
	}
}