using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SmartEye2.FromControls
{
    public class MenuColorTable : ProfessionalColorTable

    {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        //Constructor
        //In constructor we define parameters for understanding if the choosen one is main menu
        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            if (isMainMenu)
            {
                backColor = Color.FromArgb(213, 236, 252);
                leftColumnColor = Color.FromArgb(213, 236, 252);
                borderColor = Color.FromArgb(213, 236, 252);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = Color.FromArgb(135, 208, 240);
            }
            else
            {
                backColor = Color.FromArgb(213, 236, 252);
                leftColumnColor = Color.FromArgb(213, 236, 252);
                borderColor = Color.FromArgb(213, 236, 252);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = Color.FromArgb(135, 208, 240);
            }
        }
        //Overrides
        //Bacground Color will be overrided
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return base.MenuBorder;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }
        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectedColor;
            }

        }
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }

        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }

    }
