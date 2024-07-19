using System;
using System.Collections.Generic;
using UnityEngine;

public readonly struct OVRAnchor : IEquatable<OVRAnchor>, IDisposable
{
	private struct DeferredValue
	{
		public OVRTask<bool> Task;

		public bool EnabledDesired;

		public ulong RequestId;
	}

	private struct DeferredKey : IEquatable<DeferredKey>
	{
		public ulong Space;

		public OVRPlugin.SpaceComponentType ComponentType;

		public static DeferredKey FromEvent(OVRDeserialize.SpaceSetComponentStatusCompleteData eventData)
		{
			return default(DeferredKey);
		}

		public bool Equals(DeferredKey other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	public static readonly OVRAnchor Null;

	private static readonly Dictionary<DeferredKey, List<DeferredValue>> _deferredTasks;

	internal ulong Handle { get; }

	public Guid Uuid { get; }

	internal static OVRPlugin.SpaceQueryInfo GetQueryInfo(OVRPlugin.SpaceComponentType type, OVRSpace.StorageLocation location, int maxResults, double timeout)
	{
		return default(OVRPlugin.SpaceQueryInfo);
	}

	internal static OVRPlugin.SpaceQueryInfo GetQueryInfo(IEnumerable<Guid> uuids, OVRSpace.StorageLocation location, double timeout)
	{
		return default(OVRPlugin.SpaceQueryInfo);
	}

	internal static OVRTask<bool> FetchAnchorsAsync(OVRPlugin.SpaceComponentType type, IList<OVRAnchor> anchors, OVRSpace.StorageLocation location = OVRSpace.StorageLocation.Local, int maxResults = 1024, double timeout = 0.0)
	{
		return default(OVRTask<bool>);
	}

	public static OVRTask<bool> FetchAnchorsAsync<T>(IList<OVRAnchor> anchors, OVRSpace.StorageLocation location = OVRSpace.StorageLocation.Local, int maxResults = 1024, double timeout = 0.0) where T : struct, IOVRAnchorComponent<T>
	{
		return default(OVRTask<bool>);
	}

	public static OVRTask<bool> FetchAnchorsAsync(IEnumerable<Guid> uuids, IList<OVRAnchor> anchors, OVRSpace.StorageLocation location = OVRSpace.StorageLocation.Local, double timeout = 0.0)
	{
		return default(OVRTask<bool>);
	}

	private static OVRTask<bool> FetchAnchors(IList<OVRAnchor> anchors, OVRPlugin.SpaceQueryInfo queryInfo)
	{
		return default(OVRTask<bool>);
	}

	internal static void OnSpaceQueryCompleteData(OVRDeserialize.SpaceQueryCompleteData data)
	{
	}

	public static OVRTask<OVRAnchor> CreateSpatialAnchorAsync(Pose trackingSpacePose)
	{
		return default(OVRTask<OVRAnchor>);
	}

	public static OVRTask<OVRAnchor> CreateSpatialAnchorAsync(Transform transform, Camera centerEyeCamera)
	{
		return default(OVRTask<OVRAnchor>);
	}

	internal OVRAnchor(ulong handle, Guid uuid)
	{
		Handle = 0uL;
		Uuid = default(Guid);
	}

	public T GetComponent<T>() where T : struct, IOVRAnchorComponent<T>
	{
		return default(T);
	}

	public bool TryGetComponent<T>(out T component) where T : struct, IOVRAnchorComponent<T>
	{
		component = default(T);
		return false;
	}

	public bool SupportsComponent<T>() where T : struct, IOVRAnchorComponent<T>
	{
		return false;
	}

	public bool GetSupportedComponents(List<OVRPlugin.SpaceComponentType> components)
	{
		return false;
	}

	public bool Equals(OVRAnchor other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(OVRAnchor lhs, OVRAnchor rhs)
	{
		return false;
	}

	public static bool operator !=(OVRAnchor lhs, OVRAnchor rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public void Dispose()
	{
	}

	[RuntimeInitializeOnLoadMethod]
	internal static void Init()
	{
	}

	internal static OVRTask<bool> CreateDeferredSpaceComponentStatusTask(ulong space, OVRPlugin.SpaceComponentType componentType, bool enabledDesired)
	{
		return default(OVRTask<bool>);
	}

	internal static void OnSpaceSetComponentStatusComplete(OVRDeserialize.SpaceSetComponentStatusCompleteData eventData)
	{
	}
}
