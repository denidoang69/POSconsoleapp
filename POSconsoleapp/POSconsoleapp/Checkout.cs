using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSconsoleapp
{
    class Checkout
    {
        public int TransactionHeaderId { get; set; }
        public DateTime CheckoutDate { get; set; }
        public List<string> TransactionDetails { get; set; }
    }