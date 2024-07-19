using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace OVR.Input
{
	public class UIButtonSquishHelper : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerEnterHandler
	{
		private const float _squishAmount = 1.1f;

		private const float _highlightAmount = 1.05f;

		private Vector3 _originalScale;

		private Button _button;

		private void Start()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
