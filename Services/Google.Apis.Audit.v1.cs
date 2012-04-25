//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Audit.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Activities : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Activity> _items;
        
        private string _kind;
        
        private string _next;
        
        private Google.Apis.Requests.RequestError _Error;
        
        private string _ETag;
        
        /// <summary>Each record in read response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Activity> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>Kind of list response this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Next page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("next")]
        public virtual string Next {
            get {
                return this._next;
            }
            set {
                this._next = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this._Error;
            }
            set {
                this._Error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
    
    public class Activity {
        
        private Activity.ActorData _actor;
        
        private System.Collections.Generic.IList<Activity.EventsData> _events;
        
        private Activity.IdData _id;
        
        private string _ipAddress;
        
        private string _kind;
        
        private string _ownerDomain;
        
        /// <summary>User doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Activity.ActorData Actor {
            get {
                return this._actor;
            }
            set {
                this._actor = value;
            }
        }
        
        /// <summary>Activity events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<Activity.EventsData> Events {
            get {
                return this._events;
            }
            set {
                this._events = value;
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual Activity.IdData Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        /// <summary>IP Address of the user doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress {
            get {
                return this._ipAddress;
            }
            set {
                this._ipAddress = value;
            }
        }
        
        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Domain of source customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDomain")]
        public virtual string OwnerDomain {
            get {
                return this._ownerDomain;
            }
            set {
                this._ownerDomain = value;
            }
        }
        
        /// <summary>User doing the action.</summary>
        public class ActorData {
            
            private string _applicationId;
            
            private string _callerType;
            
            private string _email;
            
            private string _key;
            
            /// <summary>ID of application which interacted on behalf of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
                set {
                    this._applicationId = value;
                }
            }
            
            /// <summary>User or OAuth 2LO request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callerType")]
            public virtual string CallerType {
                get {
                    return this._callerType;
                }
                set {
                    this._callerType = value;
                }
            }
            
            /// <summary>Email address of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email {
                get {
                    return this._email;
                }
                set {
                    this._email = value;
                }
            }
            
            /// <summary>For OAuth 2LO API requests, consumer_key of the requestor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("key")]
            public virtual string Key {
                get {
                    return this._key;
                }
                set {
                    this._key = value;
                }
            }
        }
        
        public class EventsData {
            
            private string _eventType;
            
            private string _name;
            
            private System.Collections.Generic.IList<EventsData.ParametersData> _parameters;
            
            /// <summary>Type of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
            public virtual string EventType {
                get {
                    return this._eventType;
                }
                set {
                    this._eventType = value;
                }
            }
            
            /// <summary>Name of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this._name;
                }
                set {
                    this._name = value;
                }
            }
            
            /// <summary>Event parameters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
            public virtual System.Collections.Generic.IList<EventsData.ParametersData> Parameters {
                get {
                    return this._parameters;
                }
                set {
                    this._parameters = value;
                }
            }
            
            public class ParametersData {
                
                private string _name;
                
                private string _value;
                
                /// <summary>Name of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name {
                    get {
                        return this._name;
                    }
                    set {
                        this._name = value;
                    }
                }
                
                /// <summary>Value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value {
                    get {
                        return this._value;
                    }
                    set {
                        this._value = value;
                    }
                }
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        public class IdData {
            
            private string _applicationId;
            
            private string _customerId;
            
            private string _time;
            
            private string _uniqQualifier;
            
            /// <summary>Application ID of the source application.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
                set {
                    this._applicationId = value;
                }
            }
            
            /// <summary>Obfuscated customer ID of the source customer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this._customerId;
                }
                set {
                    this._customerId = value;
                }
            }
            
            /// <summary>Time of occurrence of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string Time {
                get {
                    return this._time;
                }
                set {
                    this._time = value;
                }
            }
            
            /// <summary>Unique qualifier if multiple events have the same time.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniqQualifier")]
            public virtual string UniqQualifier {
                get {
                    return this._uniqQualifier;
                }
                set {
                    this._uniqQualifier = value;
                }
            }
        }
    }
}
namespace Google.Apis.Audit.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class AuditService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"audit:v1\",\"name" +
            "\":\"audit\",\"version\":\"v1\",\"revision\":\"20111110\",\"title\":\"Enterprise Audit API\",\"d" +
            "escription\":\"Lets you access user activities in your enterprise made through var" +
            "ious applications.\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/product/s" +
            "earch-16.gif\",\"x32\":\"http://www.google.com/images/icons/product/search-32.gif\"}," +
            "\"documentationLink\":\"http://code.google.com/googleapps/domain/audit_admin/v1/get" +
            "ting_started.html\",\"protocol\":\"rest\",\"baseUrl\":\"https://www.googleapis.com/apps/" +
            "reporting/audit/v1/\",\"basePath\":\"/apps/reporting/audit/v1/\",\"rootUrl\":\"https://w" +
            "ww.googleapis.com/\",\"servicePath\":\"apps/reporting/audit/v1/\",\"batchPath\":\"batch\"" +
            ",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the respons" +
            "e.\",\"default\":\"json\",\"enum\":[\"atom\",\"json\"],\"enumDescriptions\":[\"Responses with " +
            "Content-Type of application/atom+xml\",\"Responses with Content-Type of applicatio" +
            "n/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector s" +
            "pecifying which fields to include in a partial response.\",\"location\":\"query\"},\"k" +
            "ey\":{\"type\":\"string\",\"description\":\"API key. Your API key identifies your projec" +
            "t and provides you with API access, quota, and reports. Required unless you prov" +
            "ide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"des" +
            "cription\":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPri" +
            "nt\":{\"type\":\"boolean\",\"description\":\"Returns response with indentations and line" +
            " breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"des" +
            "cription\":\"Available to use for quota purposes for server-side applications. Can" +
            " be any arbitrary string assigned to a user, but should not exceed 40 characters" +
            ". Overrides userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"" +
            "string\",\"description\":\"IP address of the site where the request originates. Use " +
            "this if you want to enforce per-user limits.\",\"location\":\"query\"}},\"schemas\":{\"A" +
            "ctivities\":{\"id\":\"Activities\",\"type\":\"object\",\"properties\":{\"items\":{\"type\":\"arr" +
            "ay\",\"description\":\"Each record in read response.\",\"items\":{\"$ref\":\"Activity\"}},\"" +
            "kind\":{\"type\":\"string\",\"description\":\"Kind of list response this is.\",\"default\":" +
            "\"audit#activities\"},\"next\":{\"type\":\"string\",\"description\":\"Next page URL.\"}}},\"A" +
            "ctivity\":{\"id\":\"Activity\",\"type\":\"object\",\"properties\":{\"actor\":{\"type\":\"object\"" +
            ",\"description\":\"User doing the action.\",\"properties\":{\"applicationId\":{\"type\":\"s" +
            "tring\",\"description\":\"ID of application which interacted on behalf of the user.\"" +
            ",\"format\":\"int64\"},\"callerType\":{\"type\":\"string\",\"description\":\"User or OAuth 2L" +
            "O request.\"},\"email\":{\"type\":\"string\",\"description\":\"Email address of the user.\"" +
            "},\"key\":{\"type\":\"string\",\"description\":\"For OAuth 2LO API requests, consumer_key" +
            " of the requestor.\"}}},\"events\":{\"type\":\"array\",\"description\":\"Activity events.\"" +
            ",\"items\":{\"type\":\"object\",\"properties\":{\"eventType\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Type of event.\"},\"name\":{\"type\":\"string\",\"description\":\"Name of event.\"},\"pa" +
            "rameters\":{\"type\":\"array\",\"description\":\"Event parameters.\",\"items\":{\"type\":\"obj" +
            "ect\",\"properties\":{\"name\":{\"type\":\"string\",\"description\":\"Name of the parameter." +
            "\"},\"value\":{\"type\":\"string\",\"description\":\"Value of the parameter.\"}}}}}}},\"id\":" +
            "{\"type\":\"object\",\"description\":\"Unique identifier for each activity record.\",\"pr" +
            "operties\":{\"applicationId\":{\"type\":\"string\",\"description\":\"Application ID of the" +
            " source application.\",\"format\":\"int64\"},\"customerId\":{\"type\":\"string\",\"descripti" +
            "on\":\"Obfuscated customer ID of the source customer.\"},\"time\":{\"type\":\"string\",\"d" +
            "escription\":\"Time of occurrence of the activity.\",\"format\":\"date-time\"},\"uniqQua" +
            "lifier\":{\"type\":\"string\",\"description\":\"Unique qualifier if multiple events have" +
            " the same time.\",\"format\":\"int64\"}}},\"ipAddress\":{\"type\":\"string\",\"description\":" +
            "\"IP Address of the user doing the action.\"},\"kind\":{\"type\":\"string\",\"description" +
            "\":\"Kind of resource this is.\",\"default\":\"audit#activity\"},\"ownerDomain\":{\"type\":" +
            "\"string\",\"description\":\"Domain of source customer.\"}}}},\"resources\":{\"activities" +
            "\":{\"methods\":{\"list\":{\"id\":\"audit.activities.list\",\"path\":\"{customerId}/{applica" +
            "tionId}\",\"httpMethod\":\"GET\",\"description\":\"Retrieves a list of activities for a " +
            "specific customer and application.\",\"parameters\":{\"actorApplicationId\":{\"type\":\"" +
            "string\",\"description\":\"Application ID of the application which interacted on beh" +
            "alf of the user while performing the event.\",\"format\":\"int64\",\"location\":\"query\"" +
            "},\"actorEmail\":{\"type\":\"string\",\"description\":\"Email address of the user who per" +
            "formed the action.\",\"location\":\"query\"},\"actorIpAddress\":{\"type\":\"string\",\"descr" +
            "iption\":\"IP Address of host where the event was performed. Supports both IPv4 an" +
            "d IPv6 addresses.\",\"location\":\"query\"},\"applicationId\":{\"type\":\"string\",\"descrip" +
            "tion\":\"Application ID of the application on which the event was performed.\",\"req" +
            "uired\":true,\"format\":\"int64\",\"location\":\"path\"},\"caller\":{\"type\":\"string\",\"descr" +
            "iption\":\"Type of the caller.\",\"enum\":[\"application_owner\",\"customer\"],\"enumDescr" +
            "iptions\":[\"Caller is an application owner.\",\"Caller is a customer.\"],\"location\":" +
            "\"query\"},\"continuationToken\":{\"type\":\"string\",\"description\":\"Next page URL.\",\"lo" +
            "cation\":\"query\"},\"customerId\":{\"type\":\"string\",\"description\":\"Represents the cus" +
            "tomer who is the owner of target object on which action was performed.\",\"require" +
            "d\":true,\"pattern\":\"C.+\",\"location\":\"path\"},\"endTime\":{\"type\":\"string\",\"descripti" +
            "on\":\"Return events which occured at or before this time.\",\"location\":\"query\"},\"e" +
            "ventName\":{\"type\":\"string\",\"description\":\"Name of the event being queried.\",\"loc" +
            "ation\":\"query\"},\"maxResults\":{\"type\":\"integer\",\"description\":\"Number of activity" +
            " records to be shown in each page.\",\"format\":\"int32\",\"minimum\":\"1\",\"maximum\":\"10" +
            "00\",\"location\":\"query\"},\"parameters\":{\"type\":\"string\",\"description\":\"Event param" +
            "eters in the form [parameter1 name]:[parameter1 value],[parameter2 name]:[parame" +
            "ter2 value],...\",\"location\":\"query\"},\"startTime\":{\"type\":\"string\",\"description\":" +
            "\"Return events which occured at or after this time.\",\"location\":\"query\"}},\"param" +
            "eterOrder\":[\"customerId\",\"applicationId\"],\"response\":{\"$ref\":\"Activities\"}}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "audit";
        
        private const string BaseUri = "https://www.googleapis.com/apps/reporting/audit/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected AuditService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this._activities = new ActivitiesResource(this);
        }
        
        public AuditService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public AuditService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(AuditService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri(AuditService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class ActivitiesResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "activities";
        
        public ActivitiesResource(AuditService service) {
            this.service = service;
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Application ID of the application on which the event was performed.</param>
        public virtual ListRequest List(string customerId, string applicationId) {
            return new ListRequest(service, customerId, applicationId);
        }
        
        /// <summary>Type of the caller.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Caller {
            
            /// <summary>Caller is an application owner.</summary>
            [Google.Apis.Util.StringValueAttribute("application_owner")]
            Application_owner,
            
            /// <summary>Caller is a customer.</summary>
            [Google.Apis.Util.StringValueAttribute("customer")]
            Customer,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Audit.v1.Data.Activities> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _actorApplicationId;
            
            private string _actorEmail;
            
            private string _actorIpAddress;
            
            private string _applicationId;
            
            private System.Nullable<Caller> _caller;
            
            private string _continuationToken;
            
            private string _customerId;
            
            private string _endTime;
            
            private string _eventName;
            
            private System.Nullable<long> _maxResults;
            
            private string _parameters;
            
            private string _startTime;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, string customerId, string applicationId) : 
                    base(service) {
                this._customerId = customerId;
                this._applicationId = applicationId;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>Application ID of the application which interacted on behalf of the user while performing the event.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorApplicationId")]
            public virtual string ActorApplicationId {
                get {
                    return this._actorApplicationId;
                }
                set {
                    this._actorApplicationId = value;
                }
            }
            
            /// <summary>Email address of the user who performed the action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorEmail")]
            public virtual string ActorEmail {
                get {
                    return this._actorEmail;
                }
                set {
                    this._actorEmail = value;
                }
            }
            
            /// <summary>IP Address of host where the event was performed. Supports both IPv4 and IPv6 addresses.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorIpAddress")]
            public virtual string ActorIpAddress {
                get {
                    return this._actorIpAddress;
                }
                set {
                    this._actorIpAddress = value;
                }
            }
            
            /// <summary>Application ID of the application on which the event was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this._applicationId;
                }
            }
            
            /// <summary>Type of the caller.</summary>
            [Google.Apis.Util.RequestParameterAttribute("caller")]
            public virtual System.Nullable<Caller> Caller {
                get {
                    return this._caller;
                }
                set {
                    this._caller = value;
                }
            }
            
            /// <summary>Next page URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("continuationToken")]
            public virtual string ContinuationToken {
                get {
                    return this._continuationToken;
                }
                set {
                    this._continuationToken = value;
                }
            }
            
            /// <summary>Represents the customer who is the owner of target object on which action was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this._customerId;
                }
            }
            
            /// <summary>Return events which occured at or before this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime")]
            public virtual string EndTime {
                get {
                    return this._endTime;
                }
                set {
                    this._endTime = value;
                }
            }
            
            /// <summary>Name of the event being queried.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName")]
            public virtual string EventName {
                get {
                    return this._eventName;
                }
                set {
                    this._eventName = value;
                }
            }
            
            /// <summary>Number of activity records to be shown in each page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults")]
            public virtual System.Nullable<long> MaxResults {
                get {
                    return this._maxResults;
                }
                set {
                    this._maxResults = value;
                }
            }
            
            /// <summary>Event parameters in the form [parameter1 name]:[parameter1 value],[parameter2 name]:[parameter2 value],...</summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters")]
            public virtual string Parameters {
                get {
                    return this._parameters;
                }
                set {
                    this._parameters = value;
                }
            }
            
            /// <summary>Return events which occured at or after this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime")]
            public virtual string StartTime {
                get {
                    return this._startTime;
                }
                set {
                    this._startTime = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "activities";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class AuditService {
        
        private const string Resource = "";
        
        private ActivitiesResource _activities;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual ActivitiesResource Activities {
            get {
                return this._activities;
            }
        }
    }
}
