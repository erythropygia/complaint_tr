using System.ComponentModel.DataAnnotations;
using complaint_tr.Areas.Identity.Data;

namespace complaint_tr.Models
{
    public class Complaint
    {
        public int Id { get; set; }
        public string type { get; set; } = String.Empty;
        public string definition { get; set; } = String.Empty;
        public string  province { get; set; } = String.Empty;
        public string  district { get; set; } = String.Empty;
        public string  neighbourhood { get; set; } = String.Empty;
        public string  second_line { get; set; } = String.Empty;
        public bool is_approved {get; set; } = false; 
        public DateTime posting_date { get; set; } = DateTime.Now;
        public User ? posted_by { get; set; } = null!;
    }
}