using UnityEngine;

public class DebugDraw : MonoBehaviour
{
	RectTransform rectTransform;
	RectTransform parentRectTransform;
	public GUISkin skin;

	void Start()
	{
		rectTransform = GetComponent<RectTransform>();
		parentRectTransform = transform.parent.GetComponent<RectTransform>();
	}

	void OnGUI()
	{
		GUI.skin = skin;
		Rect rect = rectTransform.rect;
		rect.center = rectTransform.position;
		Rect parentRect = parentRectTransform.rect;
		parentRect.center = parentRectTransform.position;
		bool inside = rect.Overlaps(parentRect);
		GUI.Box(rect, $"{rect} {inside}");
	}
}
