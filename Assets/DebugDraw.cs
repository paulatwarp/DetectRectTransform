using UnityEngine;

public class DebugDraw : MonoBehaviour
{
	public static void DrawRectTransform(RectTransform rectTransform, string text, GUISkin skin)
	{
		Rect rect = rectTransform.rect;
		rect.center = rectTransform.position;
		DrawRect(rect, text, skin);
	}

	public static void DrawRect(Rect rect, string text, GUISkin skin)
	{
		GUI.skin = skin;
		GUI.Box(RectUtility.ToGUIRect(rect), text);
	}
}
