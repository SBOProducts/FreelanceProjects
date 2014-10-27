using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZillowSpider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string _urlFormat = "http://www.zillow.com/search/GetResults.htm?spt=homes&status=001000&lt=000000&ht=100000&pr=120587,163147&mp=451,611&bd=0%2C&ba=1.0%2C&sf=1315,1779&lot=,&yr=,&pho=0&pets=0&parking=0&laundry=0&pnd=0&red=0&zso=0&days=12m&ds=all&pmf=0&pf=0&zoom=12&rect=-81481218,28316471,-81258059,28376902&p={0}&sort=days&search=list&disp=1&listright=true&responsivemode=defaultList&isMapSearch=false&zoom=12";
        string _folder;
        int _page = 1;


        private void Download_Click(object sender, EventArgs e)
        {
            //_url = StartUrl.Text;
        }


        private void Download()
        {
            
        }





    }



}
