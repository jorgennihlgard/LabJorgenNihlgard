using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Mouse
    {
        private int buttons;
        private string color;

        public void setButtons(int buttons)
        {
            this.buttons = buttons;
        }
        public int GetButtons()
        {
            return buttons;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }
    }
}
