using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IncentivoPro.Modelos.Connection
{
    public class DatabaseConnection {
        public static AppDbContext CreateDbContext() {
            var connectionString = postgresql://postgres:[felipwz_0204]@db.wtdoiengvkbmptiqtdup.supabase.co:5432/postgres
        }
    }
}
