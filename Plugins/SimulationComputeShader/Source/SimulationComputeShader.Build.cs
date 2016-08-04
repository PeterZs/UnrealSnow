namespace UnrealBuildTool.Rules
{
	public class SimulationComputeShader : ModuleRules
	{
		public SimulationComputeShader(TargetInfo Target)
        {
            PrivateIncludePaths.AddRange(
                new string[] {
					"SimulationComputeShader/Private",
                    "ShaderUtility/Public"
                }
                );

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Engine",
                    "RenderCore",
                    "ShaderCore",
                    "RHI",
                    "ShaderUtility"
				}
				);
		}
	}
}