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
    public class CreatePrivateAppJobRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string projectId;
        private string appId;
        private SourceTypeEnum sourceType;
        private DestinationTypeEnum destinationType;
        private string sourceLocation;
        private string destinationLocation;
        private string region;
        private double timeLimit;
        private object parameters;

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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId 
        { 
            get 
            {
                return this.projectId; 
            } 
            set 
            {
                this.projectId = value;
                onPropertyChanged("ProjectId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId 
        { 
            get 
            {
                return this.appId; 
            } 
            set 
            {
                this.appId = value;
                onPropertyChanged("AppId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SourceType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public SourceTypeEnum SourceType 
        { 
            get 
            {
                return this.sourceType; 
            } 
            set 
            {
                this.sourceType = value;
                onPropertyChanged("SourceType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DestinationType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public DestinationTypeEnum DestinationType 
        { 
            get 
            {
                return this.destinationType; 
            } 
            set 
            {
                this.destinationType = value;
                onPropertyChanged("DestinationType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SourceLocation")]
        public string SourceLocation 
        { 
            get 
            {
                return this.sourceLocation; 
            } 
            set 
            {
                this.sourceLocation = value;
                onPropertyChanged("SourceLocation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("DestinationLocation")]
        public string DestinationLocation 
        { 
            get 
            {
                return this.destinationLocation; 
            } 
            set 
            {
                this.destinationLocation = value;
                onPropertyChanged("DestinationLocation");
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
        [JsonProperty("TimeLimit")]
        public double TimeLimit 
        { 
            get 
            {
                return this.timeLimit; 
            } 
            set 
            {
                this.timeLimit = value;
                onPropertyChanged("TimeLimit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Parameters")]
        public object Parameters 
        { 
            get 
            {
                return this.parameters; 
            } 
            set 
            {
                this.parameters = value;
                onPropertyChanged("Parameters");
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