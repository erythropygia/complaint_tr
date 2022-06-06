using System.ComponentModel.DataAnnotations;
using complaint_tr.Areas.Identity.Data;

namespace complaint_tr.Models
{
    public class Petition
    {
        public int Id { get; set; }
        public string type { get; set; } = String.Empty;
        public string definition { get; set; } = String.Empty;
        public DateTime posting_date { get; set; } = DateTime.Now;
        public User ? posted_by { get; set; } = null!;
    }
}