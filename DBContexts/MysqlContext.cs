using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using TaskManager.Models;


namespace TaskManager.DBContexts
{

    public class MysqlContext(DbContextOptions<MysqlContext> options) : DbContext(options)
    {
        public DbSet<TaskModel> Task_ { get; set; }
    }

}