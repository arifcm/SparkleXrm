﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SparkleXrm.Tasks.Tests {
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
    internal class TestCode {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestCode() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SparkleXrm.Tasks.Tests.TestCode", typeof(TestCode).Assembly);
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
        ///   Looks up a localized string similar to namespace TestPlugins
        ///{
        ///	using System.Collections.Generic;
        ///    using System;
        ///
        ///    /// &lt;summary&gt;
        ///    /// TestPlugin
        ///    /// &lt;/summary&gt;    
        ///    [CrmPluginRegistration(&quot;Disassociate&quot;, 
        ///    &quot;none&quot;, StageEnum.PostOperation, ExecutionModeEnum.Synchronous,
        ///    &quot;&quot;,&quot;GlobalAssociatePlugin&quot;, 1, 
        ///    IsolationModeEnum.Sandbox  
        ///    )]
        ///    public class Testplugin : Plugin
        ///    {
        ///        /// &lt;summary&gt;
        ///        /// Test
        ///        /// &lt;/summary&gt;
        ///        private readonly string postImageAlias = &quot;PostImage&quot;;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CodeSnipToRemoveAdd {
            get {
                return ResourceManager.GetString("CodeSnipToRemoveAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///using System;
        ///using System.ServiceModel;
        ///using Microsoft.Xrm.Sdk;
        ///
        ///namespace Tests
        ///{
        ///
        ///    public class CustomWorkflowclass : WorkFlowActivityBase
        ///    {
        ///        /// &lt;summary&gt;
        ///        /// Initializes a new instance...
        ///        /// &lt;/summary&gt;
        ///        public CustomWorkflowclass()
        ///		{
        ///		}
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string CustomBaseClass {
            get {
                return ResourceManager.GetString("CustomBaseClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // &lt;copyright file=&quot;PreValidateaccountUpdate.cs&quot; company=&quot;&quot;&gt;
        ///// Copyright (c) 2017 All Rights Reserved
        ///// &lt;/copyright&gt;
        ///// &lt;author&gt;&lt;/author&gt;
        ///// &lt;date&gt;4/13/2017 1:10:43 PM&lt;/date&gt;
        ///// &lt;summary&gt;Implements the PreValidateaccountUpdate Plugin.&lt;/summary&gt;
        ///// &lt;auto-generated&gt;
        /////     This code was generated by a tool.
        /////     Runtime Version:4.0.30319.1
        ///// &lt;/auto-generated&gt;
        ///
        ///using System;
        ///using System.ServiceModel;
        ///using Microsoft.Xrm.Sdk;
        ///
        ///namespace TestPlugin.Plugins
        ///{
        ///
        ///    /// &lt;summary&gt;
        ///    /// Pr [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DecoratedPlugin {
            get {
                return ResourceManager.GetString("DecoratedPlugin", resourceCulture);
            }
        }
    }
}
