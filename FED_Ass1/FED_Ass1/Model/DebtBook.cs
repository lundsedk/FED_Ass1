using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FED_Ass1.Model
{
	public class DebtBook
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Name { get; set; }
		public int Balance { get; set; }

		//tilføj evt. flere attributer her
	}
}
