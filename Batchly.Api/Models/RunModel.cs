/*
 * Batchly.Api
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/19/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Batchly.Api;

namespace Batchly.Api.Models
{
    public class RunModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string status;
        private string startTime;
        private string region;
        private double? sLA;
        private double? completionPercentage;
        private EngineEnum? engine;
        private string id;
        private string name;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime 
        { 
            get 
            {
                return this.startTime; 
            } 
            set 
            {
                this.startTime = value;
                onPropertyChanged("StartTime");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Region")]
        public string Region 
        { 
            get 
            {
                return this.region; 
            } 
            set 
            {
                this.region = value;
                onPropertyChanged("Region");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SLA")]
        public double? SLA 
        { 
            get 
            {
                return this.sLA; 
            } 
            set 
            {
                this.sLA = value;
                onPropertyChanged("SLA");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CompletionPercentage")]
        public double? CompletionPercentage 
        { 
            get 
            {
                return this.completionPercentage; 
            } 
            set 
            {
                this.completionPercentage = value;
                onPropertyChanged("CompletionPercentage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Engine", ItemConverterType = typeof(StringValuedEnumConverter))]
        public EngineEnum? Engine 
        { 
            get 
            {
                return this.engine; 
            } 
            set 
            {
                this.engine = value;
                onPropertyChanged("Engine");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 