using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mitarbeiter
{
    public class mitarbeiter
    {
        public string name;
        public int nummer;
        public double stdlohn, arbeitszeit, brutto;

        public void addtime(double zeitplus)
        {
            this.arbeitszeit = this.arbeitszeit + zeitplus;
        }
        public double getbrutto()
        {
            this.brutto = this.stdlohn * this.arbeitszeit;
            return this.brutto;
        }
        public void editstdlohn(double prozent)
        {
            this.stdlohn = this.stdlohn + (this.stdlohn * (prozent / 100));
        }
        public void setname(string newname)
        {
            this.name = newname;
        }
        public string getname()
        {
            return this.name;
        }
        public void setnummer(int newnumber) 
        {
            this.nummer = newnumber;
        }
        public int getnumber()
        {
            return this.nummer;
        }
        public void setstdlohn(double newlohn)
        {
            this.stdlohn = newlohn;
        }
        public double getstdlohn()
        {
            return this.stdlohn;
        }
        

    }
}
