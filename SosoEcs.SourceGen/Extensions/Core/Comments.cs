﻿using System.Text;

namespace SosoEcs.SourceGen.Extensions.Core
{
	public static class Comments
	{
		public static StringBuilder AppendTopComments(this StringBuilder sb)
		{
			sb.AppendLine("// <auto-generated/>");

			return sb;
		}
	}
}