using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;


namespace d4launcher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            comboBoxRes.Items.AddRange(Resolutions.getResolutions().ToArray());
            comboBoxRes.SelectedItem = comboBoxRes.Items[0];


            var ini = new IniFile("config.ini");
            var resStr = ini.Read("Resolution", "config");
            if (resStr.Length > 0)
            {
                var res = Resolution.FromIni(resStr);
                if (comboBoxRes.Items.Contains(res)) comboBoxRes.SelectedItem = res;
            }
            try
            {
                checkBoxFullscreen.Checked = !Boolean.Parse(ini.Read("window", "config"));
                checkBoxVsync.Checked = Boolean.Parse(ini.Read("Vsync", "config"));
                checkBoxShadows.Checked = Boolean.Parse(ini.Read("Shadow", "config"));
            } catch(Exception) { }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {
            var res = ((Resolution)comboBoxRes.SelectedItem);

            var ini = new IniFile("config.ini");
            ini.Write("Resolution", res.ToIni(), "config");
            ini.Write("window", (!checkBoxFullscreen.Checked).ToString(), "config");
            ini.Write("Vsync", checkBoxVsync.Checked.ToString(), "config");
            ini.Write("Shadow", checkBoxShadows.Checked.ToString(), "config");

            string args = res.ToArgs();
            if(checkBoxFullscreen.Checked) args += " -fullscreen";
            else args += " -windowed";
            if(!checkBoxVsync.Checked) args += " -novsync";
            Process.Start(@"Binaries\Win64\D4Game.exe", args);
            Close();
        }
    }

    public class Resolution
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Resolution(int w, int h)
        {
            Width = w;
            Height = h;
        }
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Resolution r = obj as Resolution;
            if ((System.Object)r == null)
            {
                return false;
            }

            return (Width == r.Width) && (Height == r.Height);
        }
        public override int GetHashCode()
        {
            return Width*10000+Height;
        }

        public override string ToString()
        {
            return String.Format("{0} x {1}", Width, Height);
        }

        public string ToIni()
        {
            return String.Format("{0}-{1}", Width, Height);
        }
        public static Resolution FromIni(string val)
        {
            var split = val.Split('-');
            int w = Int32.Parse(split[0]);
            int h = Int32.Parse(split[1]);
            return new Resolution(w,h);
        }

        public string ToArgs()
        {
            return String.Format("-resx={0} -resy={1}", Width, Height);
        }
    }

    class Resolutions
    {
        [DllImport("user32.dll")]
        static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        const int ENUM_CURRENT_SETTINGS = -1;
        const int ENUM_REGISTRY_SETTINGS = -2;

        [StructLayout(LayoutKind.Sequential)]
        struct DEVMODE
        {
            private const int CCHDEVICENAME = 0x20;
            private const int CCHFORMNAME = 0x20;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public ScreenOrientation dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }

        public static List<Resolution> getResolutions()
        {
            var ret = new List<Resolution>();
            var dm = new DEVMODE();
            int i = 0;
            while (EnumDisplaySettings(null, i, ref dm))
            {
                var res = new Resolution(dm.dmPelsWidth, dm.dmPelsHeight);
                if (!ret.Contains(res) && res.Height >= 720) ret.Add(res);
                i++;
            }
            return ret;
        }
    }

    class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
