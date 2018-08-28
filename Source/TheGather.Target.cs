// Copyright 2018 Full Send Studios, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TheGatherTarget : TargetRules
{
	public TheGatherTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TheGather" } );
	}
}
