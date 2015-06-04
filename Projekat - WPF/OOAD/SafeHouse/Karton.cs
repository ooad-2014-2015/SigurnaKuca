using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHouse
{
   
    public class Karton
    {
        private List<String> psiholoskiStatus;
        private List<String> zdravstveniStatus;
        private List<String> ekonomskaPomoc;
        private List<String> pravnaPomoc;
        public List<String> PsiholoskiStatus
        {
            get { return psiholoskiStatus; }
            set { psiholoskiStatus = value; }
        }
        public List<String> ZdravstveniStatus
        {
            get { return zdravstveniStatus; }
            set { zdravstveniStatus = value; }
        }
        public List<String> EkonomskaPomoc
        {
            get { return ekonomskaPomoc; }
            set { ekonomskaPomoc = value; }
        }
        public List<String> PravnaPomoc
        {
            get { return pravnaPomoc; }
            set { pravnaPomoc = value; }
        }
        //metode
        public void UrediPsiholoskiStatus(String ps)
        {
            psiholoskiStatus.Add(ps);
        }
        public void UrediZdrStatus(String zs)
        {
            zdravstveniStatus.Add(zs);
        }
        public void UrediEkPomoc(String ep)
        {
            ekonomskaPomoc.Add(ep);
        }
        public void UrediPrPomoc(String pp)
        {
            pravnaPomoc.Add(pp);
        }
    }
}
