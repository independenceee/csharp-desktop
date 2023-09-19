using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_LON.src.DataTransferObjects
{
    public class Voucher { 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Voucher()
        {

        }
       
        public int Id { get; set; }
        public string Code { get; set; }
        public string VoucherReleaseId { get; set; }
        public string Status { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int ParValue { get; set; }
        public string VoucherInfoStr { get; set; }
        public bool EnableMerge { get; set; }
        public string ObjectType { get; set; }
        private bool _IsChecked;

        public bool IsChecked
        {
            get { return _IsChecked; }
            set { _IsChecked = value; OnPropertyChanged(); }
        }
        public Nullable<System.DateTime> UsedAt { get; set; }
        public Nullable<System.DateTime> ReleaseAt { get; set; }
    }
}
