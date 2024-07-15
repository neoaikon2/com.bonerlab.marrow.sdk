namespace Wave.OpenXR
{
	public struct XrRect2Di
	{
		public XrOffset2Di offset;

		public XrExtent2Di extent;

		public XrRect2Di(XrOffset2Di in_offset, XrExtent2Di in_extent)
		{
			offset = default(XrOffset2Di);
			extent = default(XrExtent2Di);
		}
	}
}
