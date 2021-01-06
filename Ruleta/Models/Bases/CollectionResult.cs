using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ruleta.Models.Bases
{
    public class CollectionResult<T>
    {
        public int? total { get; set; }
        public List<T> rows { get; set; }
        public ServiceResult result { get; set; }
        public string stackError { get; set; }
    }

    public class CollectionResultTreeXml<T>
    {
        public int? total { get; set; }
        public T rows { get; set; }
        public ServiceResult result { get; set; }
        public string stackError { get; set; }
    }

    public class ServiceTransaction
    {
        public object data { get; set; }
        public ServiceResult result { get; set; }
        public string message { get; set; }
        public string stackError { get; set; }
    }

    public enum ServiceResult : int { Success = 1, FailLogin = 2, Error = 3, Validation = 4 };
}