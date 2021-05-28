using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInside : MonoBehaviour
{
    public RectTransform container;
	public GUISkin skin;
    RectTransform rectTransform;
    Rect containingRect;
    bool inside = false;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
		Rect rect = rectTransform.rect;
        rect.center = rectTransform.position;
        containingRect = container.rect;
        RectOffset offset = new RectOffset(
            (int)(rect.size.x * 0.5f),
            (int)(rect.size.x * 0.5f),
            (int)(rect.size.y * 0.5f),
            (int)(rect.size.y * 0.5f));
        containingRect = offset.Remove(containingRect);
        containingRect.center = container.position;
        inside = containingRect.Contains(rect.center, false);
    }

    void DrawRectTransform(RectTransform rectTransform, string text)
    {
        GUI.skin = skin;
		Rect rect = rectTransform.rect;
		rect.center = rectTransform.position;
		DrawRect(rect, text);
    }

    void DrawRect(Rect rect, string text)
    {
        GUI.skin = skin;
		DebugDraw.Box(rect, text);
    }

    void OnGUI()
    {
        DrawRectTransform(rectTransform, $"{inside}");
        DrawRect(containingRect, $"{containingRect}");
    }
}
