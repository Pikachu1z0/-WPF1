using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AAA.ViewModel
{
    enum counter
    {
        q1,q2,q3,q4
    }

    public class MyViewModel : Model
    {
        public MyViewModel()
        {

        }
        counter www;
        internal counter zzz
        {
            get { return www; }
            set
            {
                if (www == value)
                   return;

               www = value;
                Changed("Result");
            }
        }

        public bool q1
        {
            get { return zzz == counter.q1; }
            set { zzz = value ? counter.q1 : zzz; }
        }

        public bool q2
        {
            get { return zzz == counter.q2; }
            set { zzz = value ? counter.q2 : zzz; }
        }

        public bool q3
        {
            get { return zzz == counter.q3; }
            set { zzz = value ? counter.q3 : zzz; }
        }
        public bool q4
        {
            get { return zzz == counter.q4; }
            set { zzz = value ? counter.q4 : zzz; }
        }

        public string Result
        {
            get
            {
                switch (zzz)
                {
                    case counter.q1:
                        return "1000";
                    case counter.q2:
                        return "500";
                    case counter.q3:
                        return "450";
                    case counter.q4:
                        return "800";
                }

                return "0";
            }
    }
}

}

