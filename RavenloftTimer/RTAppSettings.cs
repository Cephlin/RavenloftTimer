using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenloftClock
{
    public class RTAppSettings
    {
        private readonly int _setting_hour;
        private readonly int _setting_day;
        private readonly int _setting_month;

        internal RTAppSettings()
        {

            _setting_hour = int.Parse(ConfigurationManager.AppSettings["setting_hour"]);
            _setting_day = int.Parse(ConfigurationManager.AppSettings["setting_day"]);
            _setting_month = int.Parse(ConfigurationManager.AppSettings["setting_month"]);
        }

        public int Setting_Hour => _setting_hour;
        public int Setting_Day => _setting_day;
        public int Setting_Month => _setting_month;
    }

}
