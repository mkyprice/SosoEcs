﻿using System.Text;

namespace SosoEcs.SourceGen.Extensions.Systems
{
	public static class ISystemExtension
	{
		public const string SYSTEMS_NAMESPACE = "namespace SosoEcs.Systems;";
		
		public static StringBuilder CreateSystems(this StringBuilder sb, int amount)
		{
			string interfaceGenerics = string.Empty;
			string updateGenerics = string.Empty;
			sb.AppendLine(SYSTEMS_NAMESPACE);
			for (int i = 0; i < amount; i++)
			{
				string generic = "T" + i;
				if (i > 0)
				{
					interfaceGenerics += ", ";
					updateGenerics += ", ";
				}
				interfaceGenerics += generic;
				sb.AppendLine($"public interface ISystem<{interfaceGenerics}>");
				sb.AppendLine("{");
				sb.AppendLine($"	public void Update({updateGenerics}ref {generic} t{i});");
				sb.AppendLine("}");
				updateGenerics += $"ref {generic} t{i}";
			}
			return sb;
		}
	}
}