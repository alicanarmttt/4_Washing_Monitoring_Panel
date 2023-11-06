
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using SmartEye2.FromControls;

namespace SmartEye2.FromControls
{
    //Burada menuColorTable oluşturup MenurRenderer da kullanmıştık.
    //Şimdi gerekli sınıflarımız oluştuğu için menüyü oluşturmaya başlıyoruz.
    public class SEDropDownMenu : ContextMenuStrip
    {
        //fields for menu
        private bool isMainMenu;
        private int menuItemHeiht=25;
        private Color menuItemTextColor = Color.Black;
        private Color primaryColor = Color.FromArgb(213, 236, 252);

        private Bitmap menuItemHeaderSize; //resim eklemelerinde önemli

        //Constructor
        //Sonuç olarak, bu yapı, bileşenlerin doğru bir şekilde yönetilmesini ve
        //bellek sızıntılarının önlenmesini sağlar. Bu, Windows Forms uygulamalarında
        //bileşenlerin kullanılmasında önemli bir konsepttir.
        public SEDropDownMenu(IContainer container)
            : base(container)
        { 
        
        }
        //private method for header size and text color of the menu
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Gainsboro;

            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeiht);
            }
            foreach (ToolStripMenuItem menuItemL1 in this.Items.OfType<ToolStripMenuItem>())
            {
                menuItemL1.ForeColor = menuItemTextColor;
                menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
                if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;
                foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    menuItemL2.ForeColor = menuItemTextColor;
                    menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
                    if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;
                    foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems.OfType<ToolStripMenuItem>())
                    {
                        menuItemL3.ForeColor = menuItemTextColor;
                        menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
                        if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;
                    }
                }
            }
        }
            //şimdi yüksekliği birer birer değiştirebilmek için menü öğelerini bir döngüden geçirmem gerekiyor
            //Button simgelerini kaldırıyoruz. L1 L2 içni iç içe döngülerle yapıyoruz.
            //    foreach (ToolStripMenuItem menuItemL1 in this.Items)
            //    {
            //        menuItemL1.ForeColor = menuItemTextColor;
            //        menuItemL1.ImageScaling = ToolStripItemImageScaling.None;
            //        if (menuItemL1.Image == null) menuItemL1.Image = menuItemHeaderSize;
            //        foreach (ToolStripMenuItem menuItemL2 in menuItemL1.DropDownItems)
            //        {
            //            menuItemL2.ForeColor = menuItemTextColor;
            //            menuItemL2.ImageScaling = ToolStripItemImageScaling.None;
            //            if (menuItemL2.Image == null) menuItemL2.Image = menuItemHeaderSize;
            //            foreach (ToolStripMenuItem menuItemL3 in menuItemL2.DropDownItems)
            //            {
            //                menuItemL3.ForeColor = menuItemTextColor;
            //                menuItemL3.ImageScaling = ToolStripItemImageScaling.None;
            //                if (menuItemL3.Image == null) menuItemL3.Image = menuItemHeaderSize;
            //            }
            //        }




            //    }
            //}


            //Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if(this.DesignMode==false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
