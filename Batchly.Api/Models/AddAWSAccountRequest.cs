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
    public class AddAWSAccountRequest : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string accessKey;
        private string secretKey;
        private string baseRegion;

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
        [JsonProperty("AccessKey")]
        public string AccessKey 
        { 
            get 
            {
                return this.accessKey; 
            } 
            set 
            {
                this.accessKey = value;
                onPropertyChanged("AccessKey");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey 
        { 
            get 
            {
                return this.secretKey; 
            } 
            set 
            {
                this.secretKey = value;
                onPropertyChanged("SecretKey");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BaseRegion")]
        public string BaseRegion 
        { 
            get 
            {
                return this.baseRegion; 
            } 
            set 
            {
                this.baseRegion = value;
                onPropertyChanged("BaseRegion");
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