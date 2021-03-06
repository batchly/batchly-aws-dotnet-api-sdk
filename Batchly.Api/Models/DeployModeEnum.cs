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
    public enum DeployModeEnum
    {
        NONE, //TODO: Write general description for this method
        CLUSTER, //TODO: Write general description for this method
        CLIENT, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type DeployModeEnum
    /// </summary>
    public static class DeployModeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "None", "Cluster", "Client" };

        /// <summary>
        /// Converts a DeployModeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DeployModeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DeployModeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DeployModeEnum.NONE:
                case DeployModeEnum.CLUSTER:
                case DeployModeEnum.CLIENT:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DeployModeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DeployModeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DeployModeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into DeployModeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DeployModeEnum value</returns>
        public static DeployModeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type DeployModeEnum", value));

            return (DeployModeEnum) index;
        }
    }
} 