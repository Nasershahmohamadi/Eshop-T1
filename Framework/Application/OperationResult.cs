using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Application
{
  public  class OperationResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public OperationResult()
        {
            IsSuccess = false;
        }

      public  OperationResult Success(string message = "عملیات با موفقیت انجام شد.")
        {
            Message = message;
            IsSuccess = true;
            return this;
        }
         public OperationResult Failed(string message = "عملیات با با خطا مواجه شد.")
        {
            Message = message;
            IsSuccess = false;
            return this;
        }
    }
}
