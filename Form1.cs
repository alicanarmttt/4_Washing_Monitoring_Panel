
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartEye2
{

    public partial class SmartEye2 : Form
    {
        Form2OptinScale form2OptionScale = new Form2OptinScale();

        
        public Form2OptinScale form2OptinScale;
        Size formSize;
        private int BorderSize = 2;
        public bool isPanelMenuExpanded = true;
        public bool isSideMenuExpanded = true;
        static SmartEye2 _obj;

        public static void Panel1Control()
        {
            
        }
        public static SmartEye2 Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new SmartEye2();
                return _obj;
            }
        }
     
        public SmartEye2()
        {
            InitializeComponent();
            _obj = this;
            this.IsMdiContainer = true;
            this.Padding = new Padding(BorderSize);  //Bordersize
            this.BackColor = Color.LightSteelBlue; 
            //Border Color
            ////Menüye giren çıkan butonların default renklerini atadık.
            //Color backColor = Color.FromArgb(213, 236, 252); // Arka plan rengi 
            //Color foreColor = Color.Black; // Metin rengi 
            //Color mouseOverBackColor = Color.FromArgb(135, 208, 240); // Fare üzerine gelindiğindeki arka plan rengi 

            //foreach (Button btn in PanelMenu.Controls.OfType<Button>())
            //{
            //    btn.BackColor = backColor;
            //    btn.ForeColor = foreColor;
            //    btn.FlatAppearance.MouseOverBackColor = mouseOverBackColor;
            //}
            
        }
        public void panel1Uzunluk()
        {
            int panelGenislik = panel1.Width / 2;
            if (panel1.Width < panelGenislik) 
            {
                panel1.Height = +500;
            }


        }


        //Drag and move the title bar
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void BtnWindowExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnWindowLow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnWindowLow.Visible = false;
            BtnWindowMax.Visible = true;
        }

        private void BtnWindowHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnWindowMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnWindowMax.Visible = false;
            BtnWindowLow.Visible = true;
        }

        ////Overridden Methods
        ////Close the title bar but keep the drag to top for fullscreen ability"
        //protected override void WndProc(ref Message m)
        //{
        //    const int WM_NCCALCSIZE = 0x0083;
        //    if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    {
        //        return;
        //    }
        //    base.WndProc(ref m);
        //}

        //Pencere boyut değişikliğinde başlık çubuğunun boyutunu düzenler.
    
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != BorderSize)
                        this.Padding = new Padding(BorderSize);
                    break;
            }
        }
        private void BtnMenuKapa_Click(object sender, EventArgs e)
        {
            isSideMenuExpanded = !isSideMenuExpanded;
            BtnMenuKapa.Visible = false;
            BtnMenuAc.Visible = true;
            CollapseMenu();

        }
        //Menu Collapse and Extend method
        private void CollapseMenu()
        {
            if (this.PanelMenu.Width > 180)
            {
                isPanelMenuExpanded = false; //Sign with flag
                PanelMenu.Width = 100;
                PictureBoxTolkar.Visible = false;
                BtnMenuAc.Dock = DockStyle.Top;

                foreach (Button BtnMenu in PanelMenu.Controls.OfType<Button>())
                {
                    BtnMenu.Text = "";
                    BtnMenu.ImageAlign = ContentAlignment.MiddleCenter;
                    BtnMenu.Padding = new Padding(0);


                }
            }
            else
            {
                isPanelMenuExpanded = true; //Sign with flag
                PanelMenu.Width = 305;
                PictureBoxTolkar.Visible = true;
                BtnMenuAc.Dock = DockStyle.None;
                BtnMenuKapa.Dock = DockStyle.None;
                foreach (Button BtnMenu in PanelMenu.Controls.OfType<Button>())
                {
                    BtnMenu.Text = "   " + BtnMenu.Tag.ToString(); //3 space on text to put space between icons and button text when menu was visible 
                    BtnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                    BtnMenu.Padding = new Padding(10, 0, 0, 0);

                }
            }
        }

        private void PanelMenu_MouseEnter(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 100)
            {

                PanelMenu.Width = 305;
                BtnMenuKapa.Visible = true;
                BtnMenuKapa.Dock = DockStyle.None;
                BtnMenuAc.Visible = false;
                PictureBoxTolkar.Visible = true;
                foreach (Button BtnMenu in PanelMenu.Controls.OfType<Button>())
                {
                    BtnMenu.Text = "   " + BtnMenu.Tag.ToString(); //3 space on text to put space between icons and button text when menu was visible 
                    BtnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                    BtnMenu.Padding = new Padding(0, 0, 0, 0);


                }
            }

        }

        private async void PanelMenu_MouseLeave(object sender, EventArgs e) //Ertelenmiş bir şekilde collapse yapıyoruz.
        {
            if (!isPanelMenuExpanded) //bayrak kapalı=bar kapalı. Uygulama BAR açıkk başladığı için barın üzerinden ayrılınca kapanmasını engelliyor.
            {
                await Task.Delay(3000); // 3 saniye bekleyin
                PanelMenu.Width = 100;
                BtnMenuAc.Visible = true;
                //pictureBox1.Visible = false;
                BtnMenuKapa.Visible = false;
                BtnMenuAc.Dock = DockStyle.Top;

                PictureBoxTolkar.Visible = false;

                foreach (Button BtnMenu in PanelMenu.Controls.OfType<Button>())
                {
                    BtnMenu.Text = "";
                    BtnMenu.ImageAlign = ContentAlignment.MiddleCenter;
                    BtnMenu.Padding = new Padding(0, 0, 0, 0);
                }
            }
        }

        private void BtnMenuAc_Click(object sender, EventArgs e)
        {
            BtnMenuAc.Visible = false;
            BtnMenuKapa.Visible = true;
            CollapseMenu();
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }



        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WndProc();
            Form2OptinScale form2OptinScale = new Form2OptinScale();
            form2OptinScale.TopLevel = false;// Form2'nin bir ana pencere olmadığını belirtir
            form2OptinScale.FormBorderStyle = FormBorderStyle.None; // Sınırsız kenarlıksız form
            form2OptinScale.Dock = DockStyle.Fill; // Form2'nin Panel'i doldurmasını sağlar
            panel1.Controls.Clear();
            panel1.Controls.Add(form2OptinScale); // Panel kontrolüne Form2'yi ekler
            //form2OptionScale.Owner = this;
            form2OptinScale.Show(); // Form2'yi göster
           
        }



        private void BtnAyar_Click(object sender, EventArgs e)
        {
            FormOptions formOptions = new FormOptions();
            formOptions.TopLevel = false;// Form2'nin bir ana pencere olmadığını belirtir
            formOptions.FormBorderStyle = FormBorderStyle.None; // Sınırsız kenarlıksız form
            formOptions.Dock = DockStyle.Fill; // Form2'nin Panel'i doldurmasını sağlar
            panel1.Controls.Clear();
            panel1.Controls.Add(formOptions); // Panel kontrolüne Form2'yi ekler
            formOptions.Show(); // Form2'yi göster
         

        }

        private void BtnCanlı_Click(object sender, EventArgs e)
        {
            seDropDownMenu1.Show(BtnCanlı, BtnCanlı.Width, 0);
        }

       

        

        private void BtnArsiv_Click(object sender, EventArgs e)
        {

            Form2Option form2Option = new Form2Option();
            form2Option.TopLevel = false;// Form2'nin bir ana pencere olmadığını belirtir
            form2Option.FormBorderStyle = FormBorderStyle.None; // Sınırsız kenarlıksız form
            form2Option.Dock = DockStyle.Fill; // Form2'nin Panel'i doldurmasını sağlar
            panel1.Controls.Clear();
            panel1.Controls.Add(form2Option); // Panel kontrolüne Form2'yi ekler
            form2Option.Show(); // Form2'yi göster
        }

        private void BtnIs_Click(object sender, EventArgs e)
        {
            //form2OptionScale.TopLevel = false;// Form2'nin bir ana pencere olmadığını belirtir
            //form2OptionScale.FormBorderStyle = FormBorderStyle.None; // Sınırsız kenarlıksız form
            //form2OptionScale.Dock = DockStyle.Fill; // Form2'nin Panel'i doldurmasını sağlar
            //panel1.Controls.Clear();
            //panel1.Controls.Add(form2OptionScale); // Panel kontrolüne Form2'yi ekler
            ////form2OptionScale.Owner = this;
            //form2OptionScale.Show(); // Form2'yi göster
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (form2OptinScale == null)
            {
                Form2OptinScale form2OptinScale = new Form2OptinScale();
                form2OptinScale.TopLevel = false;// Form2'nin bir ana pencere olmadığını belirtir
                form2OptinScale.FormBorderStyle = FormBorderStyle.None; // Sınırsız kenarlıksız form
                form2OptinScale.Dock = DockStyle.Fill; // Form2'nin Panel'i doldurmasını sağlar
                panel1.Controls.Clear();
                panel1.Controls.Add(form2OptinScale); // Panel kontrolüne Form2'yi ekler                                        
                form2OptinScale.Show(); // Form2'yi göster
               
                //SmartEye2 frm = SmartEye2.Instance;
                //int minWidth = 700; // Minimum genişlik değerini ayarlayın
                //int minHeight = 700; // Minimum yükseklik değerini ayarlayın
                //frm.MinimumSize = new Size(minWidth, minHeight);
            }
            
        }

        private void PanelMenu_SizeChanged(object sender, EventArgs e)
        {
            //Tek panel gözüktüğünde, yan menü küçülürse formu daralt.
            if (PanelMenu.Width < 180)
            {
                this.MinimumSize = new Size(490, this.Height);
            }
            else if(PanelMenu.Width>300)
            {
                this.MinimumSize = new Size(675, 875);
            }
            //    //bool isExpandedNow = (PanelMenu.Width > 200); // Yan menü genişken true, dar iken false döner

            //    //if (PanelMenu.Width < 200)
            //    //{
            //        //isSideMenuExpanded = isExpandedNow; // Yan menü durumu güncelle
            //        form2OptionScale.UpdateForm2PanelVisibility(); // Form2'deki panelin görünürlüğünü güncelleyin
            //    //}
        }

    private void PanelTitleBar_Resize_1(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1Uzunluk();
            //Panel sürükle bırak yapıldığında title buttonların çalışması için.
            //(buttonlara click olmadan görünürlükleri değişmiyordu)
            if(this.WindowState==FormWindowState.Maximized)
            {
                BtnWindowMax.Visible= false;
                BtnWindowLow.Visible = true;
            }
            else if(this.WindowState==FormWindowState.Normal)
            {
                BtnWindowLow.Visible= false;
                BtnWindowMax.Visible= true;
            }
        }
       

        

    }
}


