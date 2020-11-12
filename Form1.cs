using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgw_compito2
{
    public partial class frmMain : Form
    {
        BackgroundWorker bgw1, bgw2;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtAvvia2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAvvia100_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAvvia2_Click(object sender, EventArgs e)
        {
            bgw1 = new BackgroundWorker();
            bgw1.WorkerReportsProgress = true;
            bgw1.WorkerSupportsCancellation = true;
            bgw1.DoWork += bgw_DoWork;
            bgw1.ProgressChanged += bgw_ProgressChanged;
            bgw1.RunWorkerCompleted += bgw_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += bgw_DoWork;
            bgw2.ProgressChanged += bgw_ProgressChanged;
            bgw2.RunWorkerCompleted += bgw_RunWorkerCompleted;

            bgw1.RunWorkerAsync(txtAvvia2);
            bgw2.RunWorkerAsync(txtAvvia2);
        }

        BackgroundWorker[] arr = new BackgroundWorker[100]; 
        private void btnAvvia100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.WorkerReportsProgress = true;
                bgw1.WorkerSupportsCancellation = true;
                bgw1.DoWork += bgw_DoWork;
                bgw1.ProgressChanged += bgw_ProgressChanged;
                bgw1.RunWorkerCompleted += bgw_RunWorkerCompleted;
                arr[i] = bgw1;
            }
            foreach (var bgw in arr)
            {
                bgw.RunWorkerAsync(txtAvvia100);
            }
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            bgw1.CancelAsync();
            bgw2.CancelAsync();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(100);
                bgw.ReportProgress(i, tb);
                if (bgw.CancellationPending)
                {
                    e.Result = (false, tb);return;
                }
                e.Result = (true, tb);
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox;
            tb.Text = e.ProgressPercentage + Environment.NewLine + tb.Text;
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var(completo,tb) = (ValueTuple <bool,TextBox>)e.Result;
            tb.Text = completo ? "Concluso" + Environment.NewLine + tb.Text : "Cancelled" + Environment.NewLine + tb.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAvvia2.Clear();
            txtAvvia100.Clear();
        }

        private void btnStop100_Click(object sender, EventArgs e)
        {
            foreach (var bgw in arr)
            {
                bgw.CancelAsync();
            }
        }
    }
}
