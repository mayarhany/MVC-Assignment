using Company.Data.Contexts;
using Company.Data.Entities;
using Company.Repositiry.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repositiry.Repositires
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        //private readonly CompanyDbContext _context;
        public DepartmentRepository(CompanyDbContext context) : base(context)
        {
            //_context = context;
        }
    }
}
