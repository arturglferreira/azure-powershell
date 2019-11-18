﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.EventHub {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.EventHub.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adding a new Consumer Group {0} under Eventhub {1}.
        /// </summary>
        internal static string CreateConsumerGroup {
            get {
                return ResourceManager.GetString("CreateConsumerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new EventHub:{0} under Namespace:{1}.
        /// </summary>
        internal static string CreateEventHub {
            get {
                return ResourceManager.GetString("CreateEventHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new AuthorizationRule named:{0} for EventHub: {1}.
        /// </summary>
        internal static string CreateEventHubAuthorizationrule {
            get {
                return ResourceManager.GetString("CreateEventHubAuthorizationrule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new EvetntHub-Namespace:{0} under Resource Group:{1}.
        /// </summary>
        internal static string CreateNamespace {
            get {
                return ResourceManager.GetString("CreateNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new AuthorizationRule named:{0} for Namespace: {1}.
        /// </summary>
        internal static string CreateNamespaceAuthorizationrule {
            get {
                return ResourceManager.GetString("CreateNamespaceAuthorizationrule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling the Disaster Recovery and stops replicating changes from primary namespace {0} to secondary namespace {1}.
        /// </summary>
        internal static string DRBreakPairing {
            get {
                return ResourceManager.GetString("DRBreakPairing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoking Geo DR failover and reconfigure the alias - {0} to point to the secondary namespace - {1}.
        /// </summary>
        internal static string DRFailOver {
            get {
                return ResourceManager.GetString("DRFailOver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new Alias :{0} under Namespace:{1}.
        /// </summary>
        internal static string DRNew {
            get {
                return ResourceManager.GetString("DRNew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting Alias: {0} of Namespace{1}.
        /// </summary>
        internal static string DRRemoveAlias {
            get {
                return ResourceManager.GetString("DRRemoveAlias", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} does not exist.
        /// </summary>
        internal static string FileDoesNotExist {
            get {
                return ResourceManager.GetString("FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating PrimaryKey/SecondaryKey for AuthorizationRule: {0} of EventHub: {1}.
        /// </summary>
        internal static string RegenerateKeyEventHub {
            get {
                return ResourceManager.GetString("RegenerateKeyEventHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating PrimaryKey/SecondaryKey for AuthorizationRule: {0} of Namespace:{1}.
        /// </summary>
        internal static string RegenerateKeyNamesapce {
            get {
                return ResourceManager.GetString("RegenerateKeyNamesapce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting ConsumerGrop:{0} from Eventhub:{1}.
        /// </summary>
        internal static string RemoveConsumerGroup {
            get {
                return ResourceManager.GetString("RemoveConsumerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removeing AtuhorizationRule:{0} from EventHub:{1} of Namespace: {2}.
        /// </summary>
        internal static string RemoveEventHubAuthorizationRule {
            get {
                return ResourceManager.GetString("RemoveEventHubAuthorizationRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing AtuhorizationRule:{0} of Namespace: {1}.
        /// </summary>
        internal static string RemoveNamespaceAuthorizationRule {
            get {
                return ResourceManager.GetString("RemoveNamespaceAuthorizationRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete NameSpace:{0} from ResourceGroup:{1}.
        /// </summary>
        internal static string RemoveNamespaces {
            get {
                return ResourceManager.GetString("RemoveNamespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting EventHub: {0} of Namespace{1}.
        /// </summary>
        internal static string RemovingEventHub {
            get {
                return ResourceManager.GetString("RemovingEventHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove AtuhorizationRule:{0} from EventHub: {1} of Namespace: {2}.
        /// </summary>
        internal static string RemovingEventHubAuthorizationRule {
            get {
                return ResourceManager.GetString("RemovingEventHubAuthorizationRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete  AtuhorizationRule:{0} of Namespace: {1}.
        /// </summary>
        internal static string RemovingNamespaceAuthorizationRule {
            get {
                return ResourceManager.GetString("RemovingNamespaceAuthorizationRule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating ConsumerGroup: {0} for the Eventhub:{1}.
        /// </summary>
        internal static string UpdateConsumerGroup {
            get {
                return ResourceManager.GetString("UpdateConsumerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating EventHub:{0} of Namespace:{1}.
        /// </summary>
        internal static string UpdateEventHub {
            get {
                return ResourceManager.GetString("UpdateEventHub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating AuthorizationRule named:{0} for EventHub: {1}.
        /// </summary>
        internal static string UpdateEventHubAuthorizationrule {
            get {
                return ResourceManager.GetString("UpdateEventHubAuthorizationrule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Namespace:{0} from ResourceGroup:{1}.
        /// </summary>
        internal static string UpdateNamespace {
            get {
                return ResourceManager.GetString("UpdateNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating  AuthorizationRule named:{0} for Namespace: {1}.
        /// </summary>
        internal static string UpdateNamespaceAuthorizationrule {
            get {
                return ResourceManager.GetString("UpdateNamespaceAuthorizationrule", resourceCulture);
            }
        }
    }
}