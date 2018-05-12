using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selcuk.MerhabaOWIN
{
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class IsMantigi
    {
        private readonly AppFunc birSonrakiKatman;

        public IsMantigi(AppFunc birSonrakiKatman)
        {
            if (birSonrakiKatman == null)
            {
                throw new ArgumentNullException("birSonrakiKatman");
            }
            this.birSonrakiKatman = birSonrakiKatman;
        }
        public Task Invoke(IDictionary<string, object> environment)
        {
            System.Diagnostics.Trace.WriteLine("istek iş mantığınca işliyor.");
            return birSonrakiKatman(environment);
        }
    }
}
