using System.Management;

namespace PcPartFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetPCParts();
        }

        private void GetPCParts()
        {
            GetProcessor();
            GetGpu();
            GetMobo();
            GetMemory();
            GetDisks();
            
        }

        private void GetGpu()
        {
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_VideoController");
            ManagementObjectSearcher details = new ManagementObjectSearcher(query);
            ManagementObjectCollection baseObjects = details.Get();

            foreach (ManagementObject baseObject in baseObjects)
            {
                gpu_textBox.Text = (string)baseObject["Name"];
            }
        }
        private void GetMobo()
        {
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher details = new ManagementObjectSearcher(query);
            ManagementObjectCollection baseObjects = details.Get();

            foreach (ManagementObject baseObject in baseObjects)
            {
                mb_textBox.Text = (string)baseObject["Manufacturer"] + " " + (string)baseObject["Product"];
            }
        }

        private void GetMemory()
        {
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher details = new ManagementObjectSearcher(query);
            ManagementObjectCollection baseObjects = details.Get();

            foreach (ManagementObject baseObject in baseObjects)
            {
                ram_textBox.Text = (string)baseObject["Manufacturer"] + " " + (UInt16)baseObject["DataWidth"] + "GB " + (UInt32)baseObject["Speed"] + "mhz";
            }
        }

        private void GetProcessor()
        {
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_Processor");
            ManagementObjectSearcher details = new ManagementObjectSearcher(query);
            ManagementObjectCollection baseObjects = details.Get();

            foreach (ManagementObject baseObject in baseObjects)
            {
                cpu_textBox.Text = ((string)baseObject["Name"]).Trim();
            }
        }

        private void GetDisks()
        {
            SelectQuery query = new SelectQuery("SELECT * FROM Win32_DiskDrive");
            ManagementObjectSearcher details = new ManagementObjectSearcher(query);
            ManagementObjectCollection baseObjects = details.Get();

            foreach (ManagementObject baseObject in baseObjects)
            {
                wil_textbox.Text = (string)baseObject["Model"];
            }
        }

    }
}