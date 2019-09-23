﻿using Minutes.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Minutes
{
   
        public interface INoteEntryStore
        {
            Task<NoteEntry> GetByIdAsync(string id);
            Task<IEnumerable<NoteEntry>> GetAllAsync();
            Task AddAsync(NoteEntry entry);
            Task UpdateAsync(NoteEntry entry);
            Task DeleteAsync(NoteEntry entry);
        }
    
}
