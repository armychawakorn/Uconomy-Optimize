using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fr34kyn01535.Uconomy
{
    public class UconomyConfiguration : IRocketPluginConfiguration
    {
        public string DatabaseAddress;
        public string DatabaseUsername;
        public string DatabasePassword;
        public string DatabaseName;
        public string DatabaseTableName;
        public int DatabasePort;

        public decimal InitialBalance;
        public string MoneySymbol;
        public string MoneyName;

        public void LoadDefaults()
        {
            DatabaseAddress = "localhost";
            DatabaseUsername = "root";
            DatabasePassword = "password";
            DatabaseName = "unturned";
            DatabaseTableName = "uconomy";
            DatabasePort = 3306;
            InitialBalance = 30;
            MoneySymbol = "$";
            MoneyName = "Credits";
        }
    }
}
