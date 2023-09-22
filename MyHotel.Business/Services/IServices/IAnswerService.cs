﻿using PlanBetter.Business.Models;
using PlanBetter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanBetter.Business.Services.IServices
{
    public interface IAnswerService
    {
        public IEnumerable<Answer> GetAns();

        public Answer GetAns(int id);

        public int AddAns(AnswerModel ans);

        public void UpdateAns(Answer ans);

        public void DeleteAns(int id);
    }
}
