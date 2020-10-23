using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        void SpinDisc();
        void ReadData();
    }

}
