using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public static class VL
	{
		private static NodeState _badState;

		[MethodImpl(256)]
		public static void AddNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void RemoveNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void EnableNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void DisableNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void UpdateConnection(InputPortReference to, OutputPortReference from)
		{
		}

		[MethodImpl(256)]
		public static void UpdateConnection(IVoidLogicSink sink, uint inputIndex, OutputPortReference from)
		{
		}

		public static bool TryGetValue(this OutputPortReference portReference, out float value)
		{
			value = default(float);
			return false;
		}

		public static float GetValue(this OutputPortReference portReference, float defaultValue = 0f)
		{
			return 0f;
		}

		[MethodImpl(256)]
		public static OutputPortReference GetInputAtIndex(this IVoidLogicSink sink, uint index)
		{
			return default(OutputPortReference);
		}

		/*
		public unsafe static ref NodeState State(MonoBehaviour sourceMb)
		{
			return ref *(NodeState*)null;
		}

		public unsafe static ref NodeState State(this IVoidLogicSource source)
		{
			return ref *(NodeState*)null;
		}
		*/

		[Obsolete("Get rid of this after all nodes have been migrated to use OutputPortReference")]
		public static void MigratePreviousToConnections(ref MonoBehaviour[] previous, ref OutputPortReference[] connections)
		{
		}

		[Obsolete("Get rid of this after all nodes have been migrated to use OutputPortReference")]
		public static void MigratePreviousToConnection(ref MonoBehaviour previous, ref OutputPortReference connection)
		{
		}
	}
}
