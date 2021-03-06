﻿namespace forCrowd.Backbone.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;

    public enum EnvironmentType
    {
        Local,
        Test,
        Live
    }

    public static class AppSettings
    {
        /// <summary>
        /// Email service etc. settings vary on based on environment type
        /// Local | Test | Live
        /// </summary>
        public static EnvironmentType EnvironmentType => (EnvironmentType)Enum.Parse(typeof(EnvironmentType), ConfigurationManager.AppSettings["Environment"]);

        /// <summary>
        /// Allowed origins in CORS policy
        /// </summary>
        public static string DefaultClientOrigin => ConfigurationManager.AppSettings["DefaultClientOrigin"];

        /// <summary>
        /// Determines whether SSL connection required for api & odata calls & email service
        /// </summary>
        public static bool EnableSsl => bool.Parse(ConfigurationManager.AppSettings["EnableSsl"]);

        /// <summary>
        /// User related emails will be from this address
        /// </summary>
        public static string FromEmailAddress => ConfigurationManager.AppSettings["FromEmailAddress"];

        public static string FromEmailAddressDisplayName => ConfigurationManager.AppSettings["FromEmailAddressDisplayName"];

        /// <summary>
        /// Notification emails will be send to this address
        /// </summary>
        public static string NotificationEmailAddress => ConfigurationManager.AppSettings["NotificationEmailAddress"];

        /// <summary>
        /// Google Analytics Tracking ID
        /// </summary>
        public static string GoogleAnalyticsTrackingID => ConfigurationManager.AppSettings["GoogleAnalyticsTrackingID"];
    }
}
