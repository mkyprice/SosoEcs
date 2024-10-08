﻿using System.Text;

namespace Soso.Ecs.SourceGen.Extensions.Core
{
	public static class FileInitalizer
	{
		/// <summary>
		/// Initialize a StringBuilder with default file comments
		/// </summary>
		/// <returns></returns>
		public static StringBuilder Init()
		{
			StringBuilder sb = new StringBuilder()
				.AppendTopComments();

			return sb;
		}
	}
}
