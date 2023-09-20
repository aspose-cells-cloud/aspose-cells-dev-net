namespace Aspose.Cells.Dev.SDK
{
	using Model;
	using System;
	using System.IO;
	/// <summary>
	/// 
	/// </summary>
	public class CellsDevHelper
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		/// <exception cref="ApplicationException"></exception>
		public static RequestFile ToRequestFileFromFile(string path)
		{
			if(File.Exists(path))
			{
				RequestFile requestFile = new RequestFile();
				System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
				requestFile.Name = fileInfo.Name;
				requestFile.Data = Convert.ToBase64String(File.ReadAllBytes(path));
				return requestFile;
			}
			throw new ApplicationException(string.Format("{0} no exists.",path));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="responseFiles"></param>
		/// <param name="path"></param>
		public static void SaveTo( ResponseFiles responseFiles , string path = null)
		{

			foreach(ResponseFile responseFile in responseFiles.Files)
			{
				FileInfo fileInfo = new FileInfo(responseFile.Filename);
				string file = string.IsNullOrEmpty(path) ? fileInfo.Name : Path.Combine(path, fileInfo.Name);
				using (var stream = File.Create(file))
				{
					byte[] data = Convert.FromBase64String(responseFile.FileContent);
					stream.Write(data,0,data.Length);
					stream.Close();
				}
			}
		}
	}
}
