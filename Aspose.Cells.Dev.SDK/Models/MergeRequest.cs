// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MergeRequest.cs">
//   Copyright (c) 2022 Aspose.Cells Dev
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Cells.Dev.SDK.Model
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Drawing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MergeRequest.
    /// </summary>
    public class MergeRequest
    {
        /// <summary>
        /// Gets or sets Format.
        /// </summary>
        public virtual string Format { get; set; }

        /// <summary>
        /// Gets or sets InOneSheet.
        /// </summary>
        public virtual bool? InOneSheet { get; set; }

        /// <summary>
        /// Gets or sets Files.
        /// </summary>
        public virtual IList<RequestFile> Files { get; set; }

        /// <summary>
        /// Gets or sets LoadExtensionParameters.
        /// </summary>
        public virtual IList<RequestParameter> LoadExtensionParameters { get; set; }

        /// <summary>
        /// Gets or sets SaveExtensionParameters.
        /// </summary>
        public virtual IList<RequestParameter> SaveExtensionParameters { get; set; }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequest {\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  InOneSheet: ").Append(this.InOneSheet).Append("\n");
            sb.Append("  Files: ").Append(this.Files).Append("\n");
            sb.Append("  LoadExtensionParameters: ").Append(this.LoadExtensionParameters).Append("\n");
            sb.Append("  SaveExtensionParameters: ").Append(this.SaveExtensionParameters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
