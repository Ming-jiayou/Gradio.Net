﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Gradio.Net
{
    public class HTML:Component
    {

        internal HTML()
        { 
        }
          

        protected override Dictionary<string, object> GetApiInfo()
        {
            return new Dictionary<string, object>() { { "type", "string" } };
        }
        internal override object PreProcess(object data)
        {
            string result = null;
            if (data == null)
            {
                return result;
            }

            result = data.ToString();
            return result;
        }

        internal override object PostProcess(string rootUrl, object data)
        {
            if (data == null)
            {
                return null;
            }

            return data.ToString();
        }
    }
}
