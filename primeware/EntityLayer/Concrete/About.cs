using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class About
	{
		[Key]
		public int Id { get; set; }
		public string AboutTitle { get; set; }
		public string AboutDescription { get; set; }
		public string VisionTitle { get; set; }
		public string VisionDescription { get; set; }
		public string MissionTitle { get; set; }
		public string MissionDescription { get; set; }
	}


}
