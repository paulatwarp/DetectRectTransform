using UnityEngine;

public static class RectUtility
{
	public static Rect ToGUIRect(Rect rect)
	{
		Rect flipRect = rect;
		Vector2 position = rect.center;
		position.y = Screen.height - position.y;
		flipRect.center = position;
		return flipRect;
	}

    public static Rect ShrinkRect(Rect parent, Rect child)
    {
        RectOffset offset = new RectOffset(
            (int)Mathf.Abs(child.xMin),
            (int)child.xMax,
            (int)Mathf.Abs(child.yMin),
            (int)child.yMax);
        return offset.Remove(parent);
    }
}
