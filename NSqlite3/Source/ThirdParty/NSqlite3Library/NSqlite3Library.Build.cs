// Copyright 2024 ngcod, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class NSqlite3Library : ModuleRules
{
	public NSqlite3Library(ReadOnlyTargetRules Target) : base(Target)
	{
		Type = ModuleType.External;
		
		string PluginPath = ModuleDirectory;
		
		PublicIncludePaths.Add(Path.Combine(PluginPath, "inc"));
		if (Target.Platform == UnrealTargetPlatform.Win64)
		{
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Win64/sqlite3.lib"));
		}
		else if (Target.Platform == UnrealTargetPlatform.Android)
		{
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Android/ARM64/libsqlite3.a"));
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Android/ARMv7/libsqlite3.a"));
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Android/x64/libsqlite3.a"));
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Android/x86/libsqlite3.a"));
		}
		else if (Target.Platform == UnrealTargetPlatform.IOS)
		{
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/iOS/libSQLite3.a"));
		}
		else if (Target.Platform == UnrealTargetPlatform.Mac)
		{
			PublicAdditionalLibraries.Add(Path.Combine(PluginPath, "lib/Mac/libSqlite3Mac.a"));
		}
	}
}
