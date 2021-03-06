﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atlass.Framework.ViewModels
{
    public class ResultAdaptDto
    {
        public ResultAdaptDto()
        {
            status = true;
            statusCode = 0;
            this.data = new Dictionary<string, object>();
        }

        public bool status { get; set; }
        /// <summary>
        /// 401-未授权，403-未登录
        /// </summary>
        public int statusCode { get; set; }
        public string message { get; set; }
        public Dictionary<string, object> data { get; set; }
        public void Add(string key,object val)
        {
            this.data[key] = val;
        }
    }
}
