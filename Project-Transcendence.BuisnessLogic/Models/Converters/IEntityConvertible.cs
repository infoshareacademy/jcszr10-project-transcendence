﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Transcendence.BuisnessLogic.Models.Converters
{
    public interface IEntityConvertible<T>
    {
        T ConvertToEntity();
    }
}