using FED_Ass1.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FED_Ass1.Data
{
	internal class Database
	{
		private readonly SQLiteAsyncConnection _connection;

		public Database()
		{
			var dataDir = FileSystem.AppDataDirectory;
			var databasePath = Path.Combine(dataDir, "MauiDebtBook.db");

			string _dbEncryptionKey = SecureStorage.GetAsync("dbKey").Result;

			if (string.IsNullOrEmpty(_dbEncryptionKey))
			{
				Guid g = new Guid();
				_dbEncryptionKey = g.ToString();
				SecureStorage.SetAsync("dbKey", _dbEncryptionKey);
			}

			var dbOptions = new SQLiteConnectionString(databasePath, true, key: _dbEncryptionKey);

			_connection = new SQLiteAsyncConnection(dbOptions);

			_ = Initialise();
		}

		private async Task Initialise()
		{
			await _connection.CreateTableAsync<DebtBook>();
		}

		public async Task<List<DebtBook>> GetDebtBooks()
		{
			return await _connection.Table<DebtBook>().ToListAsync();
		}

		public async Task<DebtBook> GetDebtBook(int id)
		{
			var query = _connection.Table<DebtBook>().Where(t => t.Id == id);

			return await query.FirstOrDefaultAsync();
		}

		public async Task<int> AddDebtBook(DebtBook item)
		{
			return await _connection.InsertAsync(item);
		}

		public async Task<int> DeleteDebtBook(DebtBook item)
		{
			return await _connection.DeleteAsync(item);
		}

		public async Task<int> UpdateDebtBook(DebtBook item)
		{
			return await _connection.UpdateAsync(item);
		}
	}
}
