﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
using PlanBetter.Domain.IRepositories;

namespace PlanBetter.Business.Services
{
    public sealed class TeacherService :ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;
        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public IEnumerable<Teacher> GetTeachers()
        {
            return _teacherRepository.ListAll();
        }
        public Teacher GetTeacher(int id)
        {
            return _teacherRepository.GetById(id);
        }
        public void DeleteTeacher(int id)
        {
            var teacher = _teacherRepository.GetById(id);
            if (teacher != null)
            {
                _teacherRepository.Delete(teacher);
            }
        }

        public int AddTeacher(AddTeacherModel teacher)
        {
            var newtecher = _teacherRepository.Add(_mapper.Map<Teacher>(teacher));
            return newtecher.Id;
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
    }
}
