using System;

namespace Models.Dto
{
	public class UserDto
	{
		public string Id { set; get;}
		
		public string Name { set; get;}
		
		public DateTime DOB { set; get;}
		
		public string Sex { set; get;}
		
		public string Complaints { set; get;}

		private readonly int _foo;
		public int Foo
		{
			get { return _foo; }
		}

        public double Age
        {
            get
            {
                return  (DateTime.Now.Year - DOB.Year - 1) +
						(((DateTime.Now.Month > DOB.Month) ||
						((DateTime.Now.Month == DOB.Month)
						&& (DateTime.Now.Day >= DOB.Day))) ? 1 : 0);
            }
        }
    }
}