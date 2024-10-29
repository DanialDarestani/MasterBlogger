using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Contracts.Comment
{
    public class CommentViewModel
    {
        public int Id { get; init; }
        public string UserName { get; init; }
        public string Email { get; init; }
        public string Message { get; init; }
        public string CreationDate { get; init; }
        public int Status { get; set; }
        public string Article { get; init; }
    }
}
