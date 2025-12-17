// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CarnivalGames : ModuleRules
{
	public CarnivalGames(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"CarnivalGames",
			"CarnivalGames/Variant_Horror",
			"CarnivalGames/Variant_Horror/UI",
			"CarnivalGames/Variant_Shooter",
			"CarnivalGames/Variant_Shooter/AI",
			"CarnivalGames/Variant_Shooter/UI",
			"CarnivalGames/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
