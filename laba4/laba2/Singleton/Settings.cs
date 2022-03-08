using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class Settings
    {
        private static Settings settings;
        private Settings(Form1 form)
        {
            form.BackColor = System.Drawing.Color.Beige;
            form.Text = "Its a Form";
            form.Icon = new System.Drawing.Icon(@"D:\University\4\oop\laba4\laba2\Blackvariant-Button-Ui-System-Folders-Drives-Developer.ico");
        }
        public static Settings GetSettings(Form1 form)
        {
            if (settings == null)
            {
                settings = new Settings(form);
            }
            return settings;
        }
    }
}
