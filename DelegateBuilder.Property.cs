﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace xDM.xReflection
{
    partial class DelegateBuilder
    {
        public static Delegate GetGetterDelegate(this PropertyInfo property)
        {
            return GetMethodDelegate(property.GetMethod);
        }
        public static TFunc GetGetterDelegate<TFunc>(this PropertyInfo property) where TFunc : class
        {
            return GetMethodDelegate(property.GetMethod) as TFunc;
        }

        public static Delegate GetSetterDelegate(this PropertyInfo property)
        {
            return GetMethodDelegate(property.SetMethod);
        }
        public static TFunc GetSetterDelegate<TFunc>(this PropertyInfo property) where TFunc : class
        {
            return GetMethodDelegate(property.SetMethod) as TFunc;
        }
    }
}
