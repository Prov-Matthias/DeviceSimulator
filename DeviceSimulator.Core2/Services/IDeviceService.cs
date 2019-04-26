﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSimulator.Core
{   public interface IDeviceService
    {
        Task ConnectToDevice(string connectionString);

        Task DisconnectFromDevice();

        Task SendRequest(string messge);

        string Status { get; }
        bool IsConnected { get; }
    }
}
