// Copyright 2018 Full Send Studios, LLC. All Rights Reserved.

using UnrealBuildTool;

public class TheGather : ModuleRules
{
	public TheGather(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
		
		PrivateDependencyModuleNames.Add("OnlineSubsystem");
 
	}
}
