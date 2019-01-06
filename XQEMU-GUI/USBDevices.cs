using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text.RegularExpressions;

namespace xqemu_gui
{
    class USBDevices
    {
        static private Dictionary<string, string> controllerIDs = new Dictionary<string, string>
        {
            {"USB\\VID_045E&PID_0202", "XBox Controller"},
            {"USB\\VID_045E&PID_0285", "XBox Controller S"},
            {"USB\\VID_045E&PID_0288", "XBox Controller S Hub"},
            {"USB\\VID_045E&PID_0289", "XBox Controller S"},
            {"USB\\VID_045E&PID_0291", "Xbox 360 Wireless Receiver for Windows"},
            {"USB\\VID_045E&PID_028E", "XBox360 Controller"},
            {"USB\\VID_045E&PID_028F", "XBox360 Controller"},
            {"USB\\VID_045E&PID_02A1", "XBox 360 Wireless Adapter"},
            {"USB\\VID_045E&PID_02D1", "XBox One Controller"},
            {"USB\\VID_045E&PID_02DD", "XBox One Controller (Firmware 2015)"},
            {"USB\\VID_045E&PID_02E3", "XBox 360 Elite controller"},
            {"USB\\VID_045E&PID_02E6", "Wireless XBox Controller Dongle"},
            {"USB\\VID_045E&PID_02EA", "Xbox One S Controller"},
            {"USB\\VID_045E&PID_02FD", "Xbox One S Controller [Bluetooth]"},
            {"USB\\VID_045E&PID_0719", "XBox 360 Wireless Controller via Play & Charge Kit"},
            {"USB\\VID_054C&PID_05C4", "DS4 Controller"}
        };

        public void Print()
        {
            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                Debug.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description);
            }

            Console.Read();
        }

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_PnPEntity"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                Regex deviceCheck = new Regex(@"(USB\\VID_[0-9a-zA-Z]{4}&PID_[0-9a-zA-Z]{4})");
                Match match = deviceCheck.Match((string)device["DeviceID"]);
                if (!match.Success) continue;
                if (!controllerIDs.ContainsKey(match.Groups[0].Value)) continue;
                Debug.WriteLine("-----------------------------------------------------------");
                Debug.WriteLine("DeviceInfos");
                Debug.WriteLine("-----------------------------------------------------------");
                foreach (var test in device.Properties)
                {
                    Debug.WriteLine("{0}: {1}", test.Name, device[test.Name]);
                }
                devices.Add(new USBDeviceInfo(
                    (string)device.GetPropertyValue("DeviceID"),
                    (string)device.GetPropertyValue("PNPDeviceID"),
                    (string)device.GetPropertyValue("Description"),
                    (string)device.GetPropertyValue("Caption"),
                    (string)device.GetPropertyValue("Name")
                ));
            }

            collection.Dispose();
            return devices;
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description, string caption, string name)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
            this.Caption = caption;
            this.Name = name;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
        public string Caption { get; private set; }
        public string Name { get; private set; }
    }
}
