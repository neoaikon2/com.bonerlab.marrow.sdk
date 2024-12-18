namespace Wave.OpenXR
{
	public enum XrObjectType
	{
		XR_OBJECT_TYPE_UNKNOWN = 0,
		XR_OBJECT_TYPE_INSTANCE = 1,
		XR_OBJECT_TYPE_SESSION = 2,
		XR_OBJECT_TYPE_SWAPCHAIN = 3,
		XR_OBJECT_TYPE_SPACE = 4,
		XR_OBJECT_TYPE_ACTION_SET = 5,
		XR_OBJECT_TYPE_ACTION = 6,
		XR_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000019000,
		XR_OBJECT_TYPE_SPATIAL_ANCHOR_MSFT = 1000039000,
		XR_OBJECT_TYPE_HAND_TRACKER_EXT = 1000051000,
		XR_OBJECT_TYPE_SCENE_OBSERVER_MSFT = 1000097000,
		XR_OBJECT_TYPE_SCENE_MSFT = 1000097001,
		XR_OBJECT_TYPE_FACIAL_TRACKER_HTC = 1000104000,
		XR_OBJECT_TYPE_FOVEATION_PROFILE_FB = 1000114000,
		XR_OBJECT_TYPE_TRIANGLE_MESH_FB = 1000117000,
		XR_OBJECT_TYPE_PASSTHROUGH_FB = 1000118000,
		XR_OBJECT_TYPE_PASSTHROUGH_LAYER_FB = 1000118002,
		XR_OBJECT_TYPE_GEOMETRY_INSTANCE_FB = 1000118004,
		XR_OBJECT_TYPE_SPATIAL_ANCHOR_STORE_CONNECTION_MSFT = 1000142000,
		XR_OBJECT_TYPE_MAX_ENUM = int.MaxValue
	}
}
