// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestHelper.cs">
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

namespace Aspose.Cells.Dev.SDK.Tests
{
    using Aspose.Cells.Dev.SDK.Model;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal static class TestHelper
    {
        internal static string DownloadFolder = Environment.GetEnvironmentVariable("CellsDevSDKTestDownloadFolder");
        internal static string CellsDevHost = Environment.GetEnvironmentVariable("CellsDevSDKTestHost");
        internal static string CellsDevVersion = "v1.0";
        internal static  RequestFile ToRequestFileFromFile(string fileName)
        {
            RequestFile requestFile = new RequestFile();
            requestFile.Name = fileName;
            requestFile.Data = Convert.ToBase64String(ReadFromFile(fileName).ToArray());
            return requestFile;
        }

        internal static MemoryStream ReadFromFile(string fileName)
        {
            var root = GetTestDataPath();
            var filePath = Path.Combine(root, fileName);
            try
            {
                var file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                var stream = new MemoryStream();
                file.CopyTo(stream);
                stream.Seek(0, SeekOrigin.Begin);
                return stream;
            }
            catch (Exception)
            {
                return null;
            }
        }
        internal static string GetTestDataPath()
        {
            string folder = Environment.GetEnvironmentVariable("CellsDevSDKTestDataPath");
            return string.IsNullOrEmpty(folder)?  Path.GetFullPath(@"..\..\..\..\testdata\Cells"): folder;
        }

        internal static void Download(dynamic response, string prefix)
        {
            foreach (var file in response.Files)
            {
                string v = file.FileContent;
                string filename = file.Filename;
                byte[] workbookData = Convert.FromBase64String(v);
                MemoryStream memoryStream = new MemoryStream(workbookData, 0, workbookData.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);
                Download(memoryStream, prefix + filename);
            }
        }

        internal static bool Download(Stream stream, string filename)
        {
            if (Directory.Exists(DownloadFolder))
            {
                using (FileStream fileStream = File.Create(Path.Combine(DownloadFolder , filename)))
                {
                    fileStream.Position = 0;
                    stream.CopyTo(fileStream);
                    fileStream.Close();
                }
            }
            return true;
        }
    }
}