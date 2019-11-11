using FeedbackVU.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackVU.Data.Repositories
{
    public class LecturerRepository
    {
        private readonly FeedbackContext _context;

        public LecturerRepository(FeedbackContext context)
        {
            _context = context;
        }

        public List<Lecturer> GetLecturers()
        {
            return _context.Lecturers.ToList();
        }
    }
}
