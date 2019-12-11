using System;
using System.Windows.Forms;

namespace 全加密GUI
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002B92 File Offset: 0x00000D92
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new main());
		}
	}
}
