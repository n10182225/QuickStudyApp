using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using PCLStorage;
using SQLite;
using QuickStudyApp.Models;
namespace QuickStudyApp.Services
{

    public class AssignmentDueData 
    {
        readonly SQLiteAsyncConnection _database;

        public AssignmentDueData(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Due>().Wait();
        }

        public Task<List<Due>> GetNotesAsync()
        {
            return _database.Table<Due>().ToListAsync();
        }

        public Task<Due> GetNoteAsync(int id)
        {
            return _database.Table<Due>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Due note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Due note)
        {
            return _database.DeleteAsync(note);
        }
    }
}