using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    public class ServiceResult<T> 
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
        public ServiceResult(bool isSuccess, T data, string message)
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
        }
    }
    public class ServiceError
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
    }
}