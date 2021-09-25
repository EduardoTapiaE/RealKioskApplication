using DeviceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealKioskApplication.Helpers
{
    public class DeviceSimulator
    {
        private static DeviceLibrary.DeviceLibrary _deviceLibrary = null;

        public DeviceSimulator()
        {

        }

        public static DeviceLibrary.DeviceLibrary instantiate
        {
            get {
                if (_deviceLibrary == null)
                {
                    _deviceLibrary = new DeviceLibrary.DeviceLibrary();
                }

                return _deviceLibrary;
            }
        }

    }
}
