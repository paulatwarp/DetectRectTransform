using UnityEngine;

public class DebugDraw : MonoBehaviour
{
	RectTransform rectTransform;
	public GUISkin skin;

	void Start()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	public static void Box(Rect rect, string text)
	{
		// GUI coordinates are y flipped
		Rect guiRect = rect;
		Vector2 position = rect.center;
		position.y = Screen.height - position.y;
		guiRect.center = position;
		GUI.Box(guiRect, text);
	}

	void OnGUI()
	{
		GUI.skin = skin;
		Rect rect = rectTransform.rect;
		rect.center = rectTransform.position;
		DebugDraw.Box(rect, $"{rect}");
	}
}
