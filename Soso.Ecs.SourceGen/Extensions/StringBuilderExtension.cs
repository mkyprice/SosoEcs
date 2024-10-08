﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System.Text;

namespace Soso.Ecs.SourceGen.Extensions
{
	public static class StringBuilderExtension
	{
		public static string ParseCs(this StringBuilder sb)
		{
			return CSharpSyntaxTree.ParseText(sb.ToString()).GetRoot().NormalizeWhitespace().ToFullString();
		}
	}
}
