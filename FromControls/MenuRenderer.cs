using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace SmartEye2.FromControls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        //fields
        private Color primaryColor; 
        private Color textColor;
        private int arrowThickness;

        //Constructor
        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor) 

            : base(new MenuColorTable(isMainMenu, primaryColor))
        {
            this.primaryColor = primaryColor;
            this.textColor = textColor;
            if (isMainMenu)
            {
                arrowThickness = 3;
            }
            else
            {
                arrowThickness = 2;
            }
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.Black : textColor;

        }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) //For customize arrow if we can define these fields.
        {
            base.OnRenderArrow(e);
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height)/2,arrowSize.Width,arrowSize.Height);

            //Açılır alt menüler genellikle bir üst menü öğesine tıkladığınızda açılır ve
            //ek seçenekleri içerir. Bu seçenekleri çizmek ve stilini ayarlamak için 
            //Bir diktörtgen içerisinde sağı gösteren üçgen çizildi.
            using ( GraphicsPath path = new GraphicsPath() )
            using (Pen pen= new Pen(arrowColor,arrowThickness) )
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top,rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left,rect.Top);
                graph.DrawPath(pen,path);
            }
        }
    }
}
