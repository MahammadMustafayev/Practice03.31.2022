﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_.Models
{
    class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {

        }
    }
}
