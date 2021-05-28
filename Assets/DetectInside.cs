using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInside : MonoBehaviour
{
	public RectTransform container;
	public GUISkin skin;
	RectTransform rectTransform;
	Rect rect;
	string inside;

	void Start()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	void Update()
	{
		rect = RectUtility.ShrinkRect(container.rect, rectTransform.rect);
		rect.center = container.position;
		inside = rect.Contains(rectTransform.position, false)?
			"Inside" : "Outside";
	}

	void OnGUI()
	{
		DebugDraw.DrawRectTransform(rectTransform, $"{inside}", skin);
		DebugDraw.DrawRect(rect, "Container", skin);
	}
}
