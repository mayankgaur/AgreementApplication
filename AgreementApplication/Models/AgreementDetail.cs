using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgreementApplication.Models
{
    public class AgreementDetail
    {


        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Value is Required")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Number")]
        public int Value { get; set; }

        [Required(ErrorMessage = "Status is Required")]
        public string Status { get; set; }
    }
}