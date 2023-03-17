using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class AppUser
    {
        public int Id { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Mobile { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
        public byte Admin { get; set; }
        public DateTime RegisterDate { get; set; }
	}
}
