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
    public class RunSummaryViewModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private int? totalItems;
        private string sLA;
        private int? sLAType;
        private string sLADescription;
        private double? totalMinutes;
        private double? rate;
        private int? errors;
        private int? totalProcessed;
        private int? totalSkipped;
        private double? instances;
        private double? cost;
        private double? savings;
        private double? savingsPercentage;
        private string status;
        private string runDate;
        private double? spot;
        private string previousRun;
        private string nextRun;
        private double? completionPercentage;
        private string endDate;
        private double? cPU;
        private JobTypeEnum? jobType;
        private string jobId;
        private double? spotHours;
        private double? onDemandHours;
        private double? instanceHours;
        private List<RunLogModel> logMessages;
        private string appName;
        private bool? isPrivateApp;

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
        [JsonProperty("TotalItems")]
        public int? TotalItems 
        { 
            get 
            {
                return this.totalItems; 
            } 
            set 
            {
                this.totalItems = value;
                onPropertyChanged("TotalItems");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SLA")]
        public string SLA 
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
        [JsonProperty("SLAType")]
        public int? SLAType 
        { 
            get 
            {
                return this.sLAType; 
            } 
            set 
            {
                this.sLAType = value;
                onPropertyChanged("SLAType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SLADescription")]
        public string SLADescription 
        { 
            get 
            {
                return this.sLADescription; 
            } 
            set 
            {
                this.sLADescription = value;
                onPropertyChanged("SLADescription");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TotalMinutes")]
        public double? TotalMinutes 
        { 
            get 
            {
                return this.totalMinutes; 
            } 
            set 
            {
                this.totalMinutes = value;
                onPropertyChanged("TotalMinutes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Rate")]
        public double? Rate 
        { 
            get 
            {
                return this.rate; 
            } 
            set 
            {
                this.rate = value;
                onPropertyChanged("Rate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Errors")]
        public int? Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            set 
            {
                this.errors = value;
                onPropertyChanged("Errors");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TotalProcessed")]
        public int? TotalProcessed 
        { 
            get 
            {
                return this.totalProcessed; 
            } 
            set 
            {
                this.totalProcessed = value;
                onPropertyChanged("TotalProcessed");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TotalSkipped")]
        public int? TotalSkipped 
        { 
            get 
            {
                return this.totalSkipped; 
            } 
            set 
            {
                this.totalSkipped = value;
                onPropertyChanged("TotalSkipped");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Instances")]
        public double? Instances 
        { 
            get 
            {
                return this.instances; 
            } 
            set 
            {
                this.instances = value;
                onPropertyChanged("Instances");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Cost")]
        public double? Cost 
        { 
            get 
            {
                return this.cost; 
            } 
            set 
            {
                this.cost = value;
                onPropertyChanged("Cost");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Savings")]
        public double? Savings 
        { 
            get 
            {
                return this.savings; 
            } 
            set 
            {
                this.savings = value;
                onPropertyChanged("Savings");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SavingsPercentage")]
        public double? SavingsPercentage 
        { 
            get 
            {
                return this.savingsPercentage; 
            } 
            set 
            {
                this.savingsPercentage = value;
                onPropertyChanged("SavingsPercentage");
            }
        }

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
        [JsonProperty("RunDate")]
        public string RunDate 
        { 
            get 
            {
                return this.runDate; 
            } 
            set 
            {
                this.runDate = value;
                onPropertyChanged("RunDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Spot")]
        public double? Spot 
        { 
            get 
            {
                return this.spot; 
            } 
            set 
            {
                this.spot = value;
                onPropertyChanged("Spot");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("PreviousRun")]
        public string PreviousRun 
        { 
            get 
            {
                return this.previousRun; 
            } 
            set 
            {
                this.previousRun = value;
                onPropertyChanged("PreviousRun");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("NextRun")]
        public string NextRun 
        { 
            get 
            {
                return this.nextRun; 
            } 
            set 
            {
                this.nextRun = value;
                onPropertyChanged("NextRun");
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
        [JsonProperty("EndDate")]
        public string EndDate 
        { 
            get 
            {
                return this.endDate; 
            } 
            set 
            {
                this.endDate = value;
                onPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CPU")]
        public double? CPU 
        { 
            get 
            {
                return this.cPU; 
            } 
            set 
            {
                this.cPU = value;
                onPropertyChanged("CPU");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("JobType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public JobTypeEnum? JobType 
        { 
            get 
            {
                return this.jobType; 
            } 
            set 
            {
                this.jobType = value;
                onPropertyChanged("JobType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId 
        { 
            get 
            {
                return this.jobId; 
            } 
            set 
            {
                this.jobId = value;
                onPropertyChanged("JobId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SpotHours")]
        public double? SpotHours 
        { 
            get 
            {
                return this.spotHours; 
            } 
            set 
            {
                this.spotHours = value;
                onPropertyChanged("SpotHours");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("OnDemandHours")]
        public double? OnDemandHours 
        { 
            get 
            {
                return this.onDemandHours; 
            } 
            set 
            {
                this.onDemandHours = value;
                onPropertyChanged("OnDemandHours");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("InstanceHours")]
        public double? InstanceHours 
        { 
            get 
            {
                return this.instanceHours; 
            } 
            set 
            {
                this.instanceHours = value;
                onPropertyChanged("InstanceHours");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("LogMessages")]
        public List<RunLogModel> LogMessages 
        { 
            get 
            {
                return this.logMessages; 
            } 
            set 
            {
                this.logMessages = value;
                onPropertyChanged("LogMessages");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName 
        { 
            get 
            {
                return this.appName; 
            } 
            set 
            {
                this.appName = value;
                onPropertyChanged("AppName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IsPrivateApp")]
        public bool? IsPrivateApp 
        { 
            get 
            {
                return this.isPrivateApp; 
            } 
            set 
            {
                this.isPrivateApp = value;
                onPropertyChanged("IsPrivateApp");
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