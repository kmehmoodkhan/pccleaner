using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace PCCleaner
{
    public static class ApplicationSettings
    {
        public static Color SelectedButtonColor
        {
            get
            {
                return Color.FromArgb(66, 131, 222);
            }
        }

        public static Color NormalButtonColor
        {
            get
            {
                return Color.FromArgb(103, 103, 103);
            }
        }

        public static string SystemInformation
        {
            get
            {
                var reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");

                string productName = (string)reg.GetValue("ProductName");

                productName += " " + WindowsArchitecture+"\n";
                productName += ProcessorName;
                productName += ", " + RamSize;
                productName += ", " + GraphicsInfo;

                return productName;
            }
        }

        public static string WindowsArchitecture
        {
            get
            {
                string architecture = string.Empty;

                if (Environment.Is64BitOperatingSystem)
                {
                    architecture = "64-bit";
                }
                else
                {
                    architecture = "32-bit";
                }
                return architecture;
            }
        }

        public static string ProcessorName
        {
            get
            {
                ManagementObjectSearcher mosProcessor = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                string Procname = null;

                foreach (ManagementObject moProcessor in mosProcessor.Get())
                {
                    if (moProcessor["name"] != null)
                    {
                        Procname = moProcessor["name"].ToString();
                    }
                }
                return Procname;
            }
        }

        public static string RamSize
        {
            get
            {
                string ramSize = string.Empty;
                string Query = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);
                foreach (ManagementObject WniPART in searcher.Get())
                {
                    UInt32 SizeinKB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value);
                    UInt32 SizeinMB = SizeinKB / 1024;
                    UInt32 SizeinGB = SizeinMB / 1024;
                    ramSize = SizeinGB.ToString() + ".0GB RAM";
                }
                return ramSize;
            }
        }

        public static string GraphicsInfo
        {
            get
            {

                ManagementObjectSearcher searcher= new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

                string graphicsCard = string.Empty;
                foreach (ManagementObject mo in searcher.Get())
                {
                    foreach (PropertyData property in mo.Properties)
                    {
                        if (property.Name == "Description")
                        {
                            graphicsCard = property.Value.ToString();
                        }
                    }
                }
                return graphicsCard;
            }
        }
    }
}
