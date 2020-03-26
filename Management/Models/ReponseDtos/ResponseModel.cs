using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities.Entity;

namespace Management.Models.ReponseDtos
{
    public class ResponseModel<T>
    {
        public ResponseStatus Status { get; set; }
        public T Data { get; set; }
        private string message;
        public string Message
        {
            set
            {
                if (value == null)
                {
                    message = Status.GetEnumDescription();
                }
                else
                {
                    message = value;
                }
            }
            get
            {
                if (message == null)
                {
                    message = Status.GetEnumDescription();
                }
                return message;
            }
        }
        //{
        //    set { Message = value; }
        //    get
        //    {
        //        if (string.IsNullOrEmpty(Message))
        //        {
        //            return Status.GetEnumDescription();
        //        }
        //        else
        //        {
        //            return Message;
        //        }
        //    }
        //}
        public ResponseModel()
        {
        }
        public ResponseModel(ResponseStatus status, T data) : this(status, data, status.GetEnumDescription())
        {
        }

        public ResponseModel(ResponseStatus status, T data, string message)
        {
            Status = status;
            Data = data;
            Message = message;
        }


    }
}
