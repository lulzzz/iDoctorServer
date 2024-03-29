﻿using AN.Core.Resources.Enums;
using System.ComponentModel;
using System.Linq;

namespace AN.Core.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName<T>(this T inputObject)
        {
            var genericEnumType = inputObject.GetType();
            var memberInfo = genericEnumType.GetMember(inputObject.ToString());
            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(DisplayNameAttribute), false);
                if ((attribs != null && attribs.Count() > 0))
                {
                    return ((DisplayNameAttribute)attribs.ElementAt(0)).DisplayName;
                }
            }
            return inputObject.ToString().ToLower();
        }

        /// <summary>
        /// This method localized enum display name and get it from resources
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputObject"></param>
        /// <returns></returns>
        public static string GetLocalizedDisplayName<T>(this T inputObject)
        {
            var genericEnumType = inputObject.GetType();

            var memberInfo = genericEnumType.GetMember(inputObject.ToString());

            if ((memberInfo != null && memberInfo.Length > 0))
            {
                var attribs = memberInfo[0].GetCustomAttributes(typeof(DisplayNameAttribute), false);

                if ((attribs != null && attribs.Count() > 0))
                {
                    var displayNameString = ((DisplayNameAttribute)attribs.ElementAt(0)).DisplayName;

                    return EnumResource.ResourceManager.GetString(displayNameString);
                }
            }

            return inputObject.ToString().ToLower();
        }
    }
}
