﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Shared
{
    public class ResultService<T> where T : class
    {
        private List<ErrorItem> _errors;
        public IEnumerable<ErrorItem> Errors => _errors;

        public bool HasError => Errors.Any();
        public T Data { get; set; }

        public ResultService()
        {
            _errors = new List<ErrorItem>();
        }

        public void AddError(ErrorType errorType, string errorMessage)
        {
            _errors.Add(new ErrorItem { ErrorType = errorType, ErrorMessage = errorMessage });
        }
    }
}
