using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace 全加密GUI
{
	// Token: 0x02000002 RID: 2
	internal class INIClass
	{
		// Token: 0x06000001 RID: 1
		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

		// Token: 0x06000002 RID: 2
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public INIClass(string INIPath)
		{
			this.inipath = INIPath;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002062 File Offset: 0x00000262
		public void IniWriteValue(string Section, string Key, string Value)
		{
			INIClass.WritePrivateProfileString(Section, Key, Value, this.inipath);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002074 File Offset: 0x00000274
		public string IniReadValue(string Section, string Key)
		{
			StringBuilder stringBuilder = new StringBuilder(500);
			int privateProfileString = INIClass.GetPrivateProfileString(Section, Key, "", stringBuilder, 500, this.inipath);
			return stringBuilder.ToString();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020B0 File Offset: 0x000002B0
		public bool ExistINIFile()
		{
			return File.Exists(this.inipath);
		}

		// Token: 0x04000001 RID: 1
		public string inipath;
	}
}
