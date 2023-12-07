using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class TransferCompletedEventArgs : EventArgs
    {
        public string TransferDetails { get; }

        public TransferCompletedEventArgs(string transferDetails)
        {
            TransferDetails = transferDetails;
        }
    }
}
