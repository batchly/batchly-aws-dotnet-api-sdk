/*
 * Batchly.Api
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Batchly.Api;

namespace Batchly.Api.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum OpeartingSystemEnum
    {
        NONE, //TODO: Write general description for this method
        WINDOWS, //TODO: Write general description for this method
        UBUNTU, //TODO: Write general description for this method
        CENTOS, //TODO: Write general description for this method
        RHEL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type OpeartingSystemEnum
    /// </summary>
    public static class OpeartingSystemEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "None", "Windows", "Ubuntu", "CentOS", "RHEL" };

        /// <summary>
        /// Converts a OpeartingSystemEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The OpeartingSystemEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(OpeartingSystemEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case OpeartingSystemEnum.NONE:
                case OpeartingSystemEnum.WINDOWS:
                case OpeartingSystemEnum.UBUNTU:
                case OpeartingSystemEnum.CENTOS:
                case OpeartingSystemEnum.RHEL:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of OpeartingSystemEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of OpeartingSystemEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<OpeartingSystemEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into OpeartingSystemEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed OpeartingSystemEnum value</returns>
        public static OpeartingSystemEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type OpeartingSystemEnum", value));

            return (OpeartingSystemEnum) index;
        }
    }
} 