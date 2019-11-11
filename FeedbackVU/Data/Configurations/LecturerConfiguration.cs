using FeedbackVU.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedbackVU.Data.Configurations
{
    public class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
    {
        public void Configure(EntityTypeBuilder<Lecturer> builder)
        {
            throw new NotImplementedException();
        }
    }
}
