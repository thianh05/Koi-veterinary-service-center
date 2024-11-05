using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebKoi6.DAL.Models;

public partial class Faq
{
    public int Faqid { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập câu hỏi")]
    public string? CauHoi { get; set; }
    [Required(ErrorMessage = "Vui lòng nhập câu trả lời")]
    public string? CauTraLoi { get; set; }
    [NotMapped]
    public int TotalRows { get; set; }
}
