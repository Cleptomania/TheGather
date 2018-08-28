// Copyright 2018 Full Send Studios, LLC. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TheGatherEditorTarget : TargetRules
{
	public TheGatherEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TheGather" } );
	}
}
