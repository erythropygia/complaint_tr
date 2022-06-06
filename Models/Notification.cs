using System.ComponentModel.DataAnnotations;
using complaint_tr.Areas.Identity.Data;

namespace complaint_tr.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string type { get; set; } = String.Empty;
        public string message { get; set; } = String.Empty;
        public string  province { get; set; } = String.Empty;
        public string  district { get; set; } = String.Empty;
        public DateTime posting_date { get; set; } = DateTime.Now;
        public User ? posted_by { get; set; } = null!;
    }
}