﻿using BusinessObject.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FamilyMemberRepository : IRepository<FamilyMember>
    {
        private readonly PRN231FamilyTreeContext _context;

        public FamilyMemberRepository(PRN231FamilyTreeContext context)
        {
            _context = context;
        }
        public IEnumerable<FamilyMember> List()
        {
            var list = _context.FamilyMembers.ToList();
            return list;
        }
        public FamilyMember Find(int Id)
        {
            var member = _context.FamilyMembers.Find(Id);
            return member;
        }
        public FamilyMember Add(FamilyMember _object)
        {
            _context.FamilyMembers.Add(_object);
            return null;
        }
        public int Update(int id, FamilyMember _object)
        {
            _context.Entry(_object).State = EntityState.Modified;
            return 1;
        }
        public int Delete(FamilyMember _object)
        {
            _context.FamilyMembers.Remove(_object);
            return 1;
        }

        public bool Exists(int id)
        {
            var isExist = _context.FamilyMembers.Any(e => e.Id == id);
            return isExist;
        }

        public int SaveChanges()
        {
            var numOfChanges = _context.SaveChanges();
            return numOfChanges;
        }

        
    }
}
