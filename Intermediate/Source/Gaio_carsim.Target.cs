using UnrealBuildTool;

public class Gaio_carsimTarget : TargetRules
{
	public Gaio_carsimTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Gaio_carsim");
	}
}
