using System;

namespace DAL.Models
{
	public class User
	{
		public Guid Id { set; get;}
		
		public string Name { set; get;}
		
		public DateTime DOB { set; get;}
		
		// true - male; false - female
		public bool Sex { set; get;}
		
		public string Complaints { set; get;}
	}
}