using MaitlandCodes.OSRS.GEItemAPI.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaitlandCodes.OSRS.GEItemAPI
{
    internal class ItemCategoryAsIntParameterFormatter : IUrlParameterFormatter
    {
        public string Format(object value, ICustomAttributeProvider attributeProvider, Type type)
        {
            if (value is null)
                return null;

            if (type == typeof(ItemCategory))
                return ((int)value).ToString();

            return value?.ToString();
        }
    }

}
