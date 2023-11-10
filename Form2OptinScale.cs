using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartEye2
{
    public partial class Form2OptinScale : Form
    {
        
        Size formSize;
        private int BorderSize = 2;
        int previousWidth;
        public bool expand = false;
        public Form2OptinScale()
        {
            InitializeComponent();
            previousWidth = this.Width;
        }

        private void Form2OptinScale_Load(object sender, EventArgs e)
        {
            //form2 Yüklendiğinde ana form tam ekran ise panelleri ortada tut. Değilse padding = 0.
            SmartEye2 frm = SmartEye2.Instance;
            if (frm.WindowState == FormWindowState.Maximized)
            {
                flowLayoutPanel1.Padding = new Padding(0, 0, 0, 0);
            }
            
            //SmartEye2 frm = SmartEye2.Instance;
            //int minWidth = 1400; // Minimum genişlik değerini ayarlayın
            //int minHeight = 800; // Minimum yükseklik değerini ayarlayın
            //frm.MinimumSize = new Size(minWidth, minHeight);
            //frm.MinimumSize = new Size(0, 0);
            //flowLayoutPanel1.Padding = new Padding(0, 0, 0, 0);
        }
        
        //[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.dll", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        //Pencere boyut değişikliğinde başlık çubuğunun boyutunu düzenler.
        //private void PanelTitleBar_Resize(object sender, EventArgs e)
        //{
        //    AdjustForm();
        //}
        //private void AdjustForm()
        //{
        //    switch (this.WindowState)
        //    {
        //        case FormWindowState.Maximized: //Maximized form (After)
        //            this.Padding = new Padding(8, 8, 8, 0);
        //            break;
        //        case FormWindowState.Normal: //Restored form (After)
        //            if (this.Padding.Top != BorderSize)
        //                this.Padding = new Padding(BorderSize);
        //            break;
        //    }
        //}
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCCALCSIZE = 0x0083;
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    {
        //        return;
        //    }
        //    base.WndProc(ref m);
        //}

        ////Overridden methods
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
        //    const int SC_RESTORE = 0xF120; //Restore form (Before)
        //    const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
        //    const int resizeAreaSize = 10;

        //    #region Form Resize
        //    // Resize/WM_NCHITTEST values
        //    const int HTCLIENT = 1; //Represents the client area of the window
        //    const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
        //    const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
        //    const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
        //    const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
        //    const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
        //    const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
        //    const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
        //    const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

        //    ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

        //    if (m.Msg == WM_NCHITTEST)
        //    { //If the windows m is WM_NCHITTEST
        //        base.WndProc(ref m);
        //        if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
        //        {
        //            if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
        //            {
        //                Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
        //                Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

        //                if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
        //                        m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
        //                        m.Result = (IntPtr)HTTOP; //Resize vertically up
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTTOPRIGHT;
        //                }
        //                else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
        //                        m.Result = (IntPtr)HTLEFT;
        //                    else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
        //                        m.Result = (IntPtr)HTRIGHT;
        //                }
        //                else
        //                {
        //                    if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
        //                        m.Result = (IntPtr)HTBOTTOMLEFT;
        //                    else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
        //                        m.Result = (IntPtr)HTBOTTOM;
        //                    else //Resize diagonally to the right
        //                        m.Result = (IntPtr)HTBOTTOMRIGHT;
        //                }
        //            }
        //        }
        //        return;
        //    }
        //    #endregion
        //    //Remove border and keep snap window
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    {
        //        return;
        //    }

        //    //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
        //    if (m.Msg == WM_SYSCOMMAND)
        //    {
        //        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
        //        /// Quote:
        //        /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
        //        /// are used internally by the system.To obtain the correct result when testing 
        //        /// the value of wParam, an application must combine the value 0xFFF0 with the 
        //        /// wParam value by using the bitwise AND operator.
        //        int wParam = (m.WParam.ToInt32() & 0xFFF0);

        //        if (wParam == SC_MINIMIZE)  //Before
        //            formSize = this.ClientSize;
        //        if (wParam == SC_RESTORE)// Restored form(Before)
        //            this.Size = formSize;
        //    }
        //    base.WndProc(ref m);
        //}
        private void PanelArasıBosluk()
        {
            SmartEye2 frm = SmartEye2.Instance;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int yarimGenislik = screenWidth / 2;
            int anaFormGenislik = frm.Width;


            //0 - 25 arası aralarını aç tek tek gözüksün.
            //if (yarimGenislik - (yarimGenislik / 2) > frm.Width && frm.Width>0)
            //{
            //    panel31.Margin = new Padding(panel31.Margin.Left + 5, panel31.Margin.Top, panel31.Margin.Right, panel31.Margin.Bottom);
            //    panelmain.Margin = new Padding(panelmain.Margin.Left + 5, panelmain.Margin.Top, panelmain.Margin.Right, panelmain.Margin.Bottom);
            //    panel21.Margin = new Padding(panel21.Margin.Left + 5, panel21.Margin.Top, panel21.Margin.Right, panel21.Margin.Bottom);
            //    panel11.Margin = new Padding(panel11.Margin.Left + 5, panel11.Margin.Top, panel11.Margin.Right, panel11.Margin.Bottom);
            //}



            //0.375'ten küçük olduğu durumlarda
            if (anaFormGenislik <= yarimGenislik * 0.75)
            {
                flowLayoutPanel1.Padding = new Padding(0, 0, 0, 0);
                foreach (Control control in flowLayoutPanel1.Controls)
                {

                    if (control is Panel)
                    {
                        Panel panel = (Panel)control;
                        // Top değerini 2'ye düşür
                        panel.Margin = new Padding(2, 120, 2, 2);

                    }

                }
            }
            // Ekran 0.375-0.500 arası ise bu şartlar
            //Padding yan menüye oranla sağa kaysın( tek panel boşluğu ortalıyor)
            
            if (anaFormGenislik >= yarimGenislik * 0.75 && anaFormGenislik < yarimGenislik)
            {
                flowLayoutPanel1.Padding = new Padding((flowLayoutPanel1.Padding.Left + (frm.PanelMenu.Width / 4)), 40, 0, 0);
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    
                    if (control is Panel)
                    {
                        Panel panel = (Panel)control;
                        // Top değerini 2'ye düşür
                        panel.Margin = new Padding(2, 0, 2, 2);
                        
                    }
                    
                }
                
            }
            
            
            // Ekran 50-75 arası
            if (((screenWidth - (yarimGenislik / 2)) >= anaFormGenislik && anaFormGenislik >= yarimGenislik))
            {  
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        Panel panel = (Panel)control;
                        // Eski margin değerlerini kullan
                        panel.Margin = new Padding(2, 40, 2, 2);

                    }
                }
            }

            // Ekran 75-100 arası
            else if (((yarimGenislik / 2) + yarimGenislik) <= anaFormGenislik && anaFormGenislik < screenWidth)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        Panel panel = (Panel)control;
                        // Eski margin değerlerini kullan
                        panel.Margin = new Padding(10, 40, 10, 2);
                        

                    }
                }
            }
        }

        private void Form2OptinScale_SizeChanged(object sender, EventArgs e)
        {
            SmartEye2 frm = SmartEye2.Instance;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int yarimGenislik = screenWidth / 2;
            int anaFormGenislik = frm.Width;
            //form büyüklüğüne göre içerideki panellerin yerleşimi için flow panelin paddinglerini ayarlıyoruz.
            

            if (frm.WindowState == FormWindowState.Normal)
            {

                flowLayoutPanel1.Padding = new Padding(0, 0, 0, 0);
                
            }
            else if(frm.WindowState == FormWindowState.Maximized && anaFormGenislik > yarimGenislik)
            {
                flowLayoutPanel1.Padding = new Padding(90, 80, 0, 0);
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        Panel panel = (Panel)control;
                        // Eski margin değerlerini kullan
                        panel.Margin = new Padding(10, 40, 10, 2);


                    }
                }
                if (frm.PanelMenu.Width < 200)
                {
                    flowLayoutPanel1.Padding = new Padding((flowLayoutPanel1.Padding.Left + (frm.PanelMenu.Width)),80,0,0);
                }
            }

            //UpdatePanelSize();
            PanelArasıBosluk();
        }
        //Panel köşeleri için siyah çizimler.
        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            

            if (panel31.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 5;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel31.ClientSize.Width - thickness,
                                                              panel31.ClientSize.Height - thickness));
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            if (panelmain.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 5;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panelmain.ClientSize.Width - thickness,
                                                              panelmain.ClientSize.Height - thickness));
                }
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

            if (panel11.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 5;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel11.ClientSize.Width - thickness,
                                                              panel11.ClientSize.Height - thickness));
                }
            }
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

            if (panel21.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 5;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel21.ClientSize.Width - thickness,
                                                              panel21.ClientSize.Height - thickness));
                }
            }
        }
        
        //public void UpdateForm2PanelVisibility()
        //{
        //    try
        //    {
        //        SmartEye2 frm = SmartEye2.Instance; //instance ile form1 i bağlamış olduk
        //        if (frm.WindowState == FormWindowState.Maximized && frm.PanelMenu.Width < 120)
        //        {
        //            // Form1 tam ekran durumundayken ve yan menü daraldığındas Form2'deki paneli görünür yapın
        //            panel41.Visible = true;
        //        }
        //        else
        //        {
        //            panel41.Visible = false; // Aksi takdirde Form2'deki paneli gizle
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }



        //}

        ////public void UpdatePanelSize()
        ////{
        ////    try
        ////    {
        ////        int FormWidth = this.Width;
        ////        int FormHeight = this.Height;
        ////        float ratioWidth = FormWidth / 1920;
        ////        float ratioHeith = FormHeight / 1080;
        ////        if (FormWidth> 1920)
        ////        {
        ////            foreach(Panel pnl in this.flowLayoutPanel1.Controls.OfType<Panel>())
        ////            {

        ////                pnl.Width = (int)(FormWidth * ratioWidth);
        ////                pnl.Height= (int)(FormHeight * ratioHeith);
        ////            }
        ////        }
        ////    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}
    }
}



