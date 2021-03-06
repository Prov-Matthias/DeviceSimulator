﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MessagePublisher.Core
{
    public class DeviceSetting : BaseSetting
    {
        public string ConnectionString
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }

        public IList<DirectMethodSetting> DirectMethodSettings
        {
            get;
            set;
        }
    }
}
