using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp.factory
{
    public class SettingFactory : FactoryForm
    {
        private Settings window;

        #region Singleton Implementation
        private static SettingFactory instance = null;
        private SettingFactory() { }
        public static SettingFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingFactory();
                }
                return instance;
            }
        }
        #endregion

        public Form CreateOrReturnForm()
        {
            if(window == null)
            {
                window = new Settings();
            }
            return window;
        }

        public void CloseForm()
        {
            window = null;
        }
    }
}
