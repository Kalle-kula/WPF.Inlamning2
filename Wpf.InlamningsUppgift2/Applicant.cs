using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wpf.InlamningsUppgift2
{
    //[Table("Applicant")]
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string CustomerType { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool NewsLetter { get; set; }
        public string Notes { get; set; }
        //private int _applicantId;
        //private string _customerType;
        //private string _company;
        //private string _firstName;
        //private string _surName;
        //private DateTime _birthdate;
        //private string _address;
        //private int _zip;
        //private string _town;
        //private string _phone;
        //private string _email;
        //private bool newsLetter_;
        //private string _notes;

        //public string CustomerType
        //{
        //    get { return _customerType; }
        //    set
        //    {
        //        _customerType = value;
        //        NotifyPropertyChanged("RadioBtn");
        //    }
        //}

        //public string Company
        //{
        //    get { return _company; }
        //    set
        //    {
        //        _company = value;
        //        NotifyPropertyChanged("TxtBoxComp");
        //    }
        //}

    }

    //public enum Customer
    //{
    //    Privat,
    //    Företag
    //};
}
