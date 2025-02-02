﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ZeroFormatter.CodeGenerator
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class EnumGenerator : EnumGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("#pragma warning disable 618\r\n#pragma warning disable 612\r\n#pragma warning disable" +
                    " 414\r\n#pragma warning disable 168\r\nnamespace ");
            
            #line 10 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using global::System;\r\n    using global::System.Collections.Generic;\r\n  " +
                    "  using global::ZeroFormatter.Formatters;\r\n    using global::ZeroFormatter.Inter" +
                    "nal;\r\n    using global::ZeroFormatter.Segments;\r\n\r\n");
            
            #line 18 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"

   var resolverName = (ForceDefaultResolver) ? "ZeroFormatter.Formatters.DefaultResolver" : "TTypeResolver";
   var resolverNameGenericArg = (ForceDefaultResolver) ? "" : "<TTypeResolver>";

            
            #line default
            #line hidden
            
            #line 22 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 foreach(var t in Types) {  
            
            #line default
            #line hidden
            this.Write("\r\n    public class ");
            
            #line 24 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("Formatter");
            
            #line 24 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverNameGenericArg));
            
            #line default
            #line hidden
            this.Write(" : Formatter<");
            
            #line 24 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 24 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n");
            
            #line 25 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 if(!ForceDefaultResolver) { 
            
            #line default
            #line hidden
            this.Write("        where ");
            
            #line 26 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverName));
            
            #line default
            #line hidden
            this.Write(" : ITypeResolver, new()\r\n");
            
            #line 27 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    {\r\n        public override int? GetLength()\r\n        {\r\n            return ");
            
            #line 31 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length));
            
            #line default
            #line hidden
            this.Write(";\r\n        }\r\n\r\n        public override int Serialize(ref byte[] bytes, int offse" +
                    "t, ");
            
            #line 34 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(" value)\r\n        {\r\n            return BinaryUtil.Write");
            
            #line 36 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write("(ref bytes, offset, (");
            
            #line 36 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")value);\r\n        }\r\n\r\n        public override ");
            
            #line 39 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(" Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tra" +
                    "cker, out int byteSize)\r\n        {\r\n            byteSize = ");
            
            #line 41 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length));
            
            #line default
            #line hidden
            this.Write(";\r\n            return (");
            
            #line 42 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(")BinaryUtil.Read");
            
            #line 42 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write("(ref bytes, offset);\r\n        }\r\n    }\r\n\r\n");
            
            #line 46 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 if (t.IncludeNullable) { 
            
            #line default
            #line hidden
            this.Write("\r\n    public class Nullable");
            
            #line 48 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("Formatter");
            
            #line 48 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverNameGenericArg));
            
            #line default
            #line hidden
            this.Write(" : Formatter<");
            
            #line 48 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverName));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 48 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write("?>\r\n");
            
            #line 49 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 if(!ForceDefaultResolver) { 
            
            #line default
            #line hidden
            this.Write("        where ");
            
            #line 50 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(resolverName));
            
            #line default
            #line hidden
            this.Write(" : ITypeResolver, new()\r\n");
            
            #line 51 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    {\r\n        public override int? GetLength()\r\n        {\r\n            return ");
            
            #line 55 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n        }\r\n\r\n        public override int Serialize(ref byte[] bytes, int offse" +
                    "t, ");
            
            #line 58 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write("? value)\r\n        {\r\n            BinaryUtil.WriteBoolean(ref bytes, offset, value" +
                    ".HasValue);\r\n            if (value.HasValue)\r\n            {\r\n                Bin" +
                    "aryUtil.Write");
            
            #line 63 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write("(ref bytes, offset + 1, (");
            
            #line 63 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")value.Value);\r\n            }\r\n            else\r\n            {\r\n                B" +
                    "inaryUtil.EnsureCapacity(ref bytes, offset, offset + ");
            
            #line 67 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length + 1));
            
            #line default
            #line hidden
            this.Write(");\r\n            }\r\n\r\n            return ");
            
            #line 70 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n        }\r\n\r\n        public override ");
            
            #line 73 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write("? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tr" +
                    "acker, out int byteSize)\r\n        {\r\n            byteSize = ");
            
            #line 75 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Length + 1));
            
            #line default
            #line hidden
            this.Write(";\r\n            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);\r\n       " +
                    "     if (!hasValue) return null;\r\n\r\n            return (");
            
            #line 79 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(")BinaryUtil.Read");
            
            #line 79 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write("(ref bytes, offset + 1);\r\n        }\r\n    }\r\n\r\n");
            
            #line 83 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 85 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 if(t.IsGenerateEqualityComparer) { 
            
            #line default
            #line hidden
            this.Write("\r\n    public class ");
            
            #line 87 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.Name));
            
            #line default
            #line hidden
            this.Write("EqualityComparer : IEqualityComparer<");
            
            #line 87 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(">\r\n    {\r\n        public bool Equals(");
            
            #line 89 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(" x, ");
            
            #line 89 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(" y)\r\n        {\r\n            return (");
            
            #line 91 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")x == (");
            
            #line 91 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.UnderlyingType));
            
            #line default
            #line hidden
            this.Write(")y;\r\n        }\r\n\r\n        public int GetHashCode(");
            
            #line 94 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(t.FullName));
            
            #line default
            #line hidden
            this.Write(" x)\r\n        {\r\n");
            
            #line 96 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 if(t.UnderlyingType == "Byte") { 
            
            #line default
            #line hidden
            this.Write("            return (int)(Byte)x;\r\n");
            
            #line 98 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "SByte") { 
            
            #line default
            #line hidden
            this.Write("             return (int)(SByte)x ^ (int)(SByte)x << 8; \r\n");
            
            #line 100 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "Int16") { 
            
            #line default
            #line hidden
            this.Write("            return (int)((Int16)x) | (int)(Int16)x << 16;\r\n");
            
            #line 102 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "UInt16") { 
            
            #line default
            #line hidden
            this.Write("            return (int)(UInt16)x;\r\n");
            
            #line 104 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "UInt32") { 
            
            #line default
            #line hidden
            this.Write("            return (int)(UInt32)x;\r\n");
            
            #line 106 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "UInt64") { 
            
            #line default
            #line hidden
            this.Write("            return (int)(UInt64)x ^ (int)((UInt64)x >> 32);\r\n");
            
            #line 108 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else if(t.UnderlyingType == "Int64") { 
            
            #line default
            #line hidden
            this.Write("            return (int)(Int64)x ^ (int)((Int64)x >> 32);\r\n");
            
            #line 110 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("            return (int)x;\r\n");
            
            #line 112 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n    }\r\n\r\n");
            
            #line 116 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 118 "Z:\lib\CS\ZeroFormatter-Serializer\src\ZeroFormatter.CodeGenerator\EnumGenerator.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n}\r\n#pragma warning restore 168\r\n#pragma warning restore 414\r\n#pragma warning re" +
                    "store 618\r\n#pragma warning restore 612");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class EnumGeneratorBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
