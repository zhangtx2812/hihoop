using Sardf;

namespace HiHoop
{
    public class HiHoopContext : AppContext
    {
        private static HiHoopContext current = new HiHoopContext();

        static HiHoopContext() { }

        protected HiHoopContext() { }

        public new static HiHoopContext Current
        {
            get
            {
                current.User = AppContext.Current.User;
                return current;
            }
        }
         
    }
}