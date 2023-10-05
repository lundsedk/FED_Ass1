using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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

		//add either
		    //a list of transactions - kind of against the db idea
			//another table of transactions, redo the manytoone stuff, etc.
			    //possible without foreignkey, etc...
    }

    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int DebtorId { get; set; }
        public int Amount { get; set; }
    }

}
