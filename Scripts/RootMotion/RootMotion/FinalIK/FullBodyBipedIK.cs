using UnityEngine;

namespace RootMotion.FinalIK
{
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		public BipedReferences references;

		public IKSolverFullBodyBiped solver;

		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		public override IKSolver GetIKSolver()
		{
			return null;
		}

		public bool ReferencesError(ref string errorMessage)
		{
			return false;
		}

		public bool ReferencesWarning(ref string warningMessage)
		{
			return false;
		}

		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}
	}
}
