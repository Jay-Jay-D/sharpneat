﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharpNeatGUI.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharpNeatGUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to NEAT is Neuro-Evolution of Augmenting Topologies - Evolution of Neural Networks.
        ///
        ///SharpNEAT is an implementation of NEAT created by Colin Green. SharpNEAT is written in C# and targetting the .Net framework. For more information visit http://sharpneat.sourceforge.net/
        ///
        ///The NEAT method was devised by Kenneth Stanley, currently of the University of Central Florida School of Electrical Engineering and Computer Science. Visit http://www.cs.ucf.edu/~kstanley/ for more info on NEAT including research papers, softw [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string About {
            get {
                return ResourceManager.GetString("About", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to                     GNU GENERAL PUBLIC LICENSE
        ///                       Version 3, 29 June 2007
        ///
        /// Copyright (C) 2007 Free Software Foundation, Inc. &lt;http://fsf.org/&gt;
        /// Everyone is permitted to copy and distribute verbatim copies
        /// of this license document, but changing it is not allowed.
        ///
        ///                            Preamble
        ///
        ///  The GNU General Public License is a free, copyleft license for
        ///software and other kinds of works.
        ///
        ///  The licenses for most software and other practical works are designed
        ///to take away yo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licensing {
            get {
                return ResourceManager.GetString("Licensing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sharpneat_banner {
            get {
                object obj = ResourceManager.GetObject("sharpneat_banner", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
