using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class XMethods{

	public static float distSqrd2D (this Transform tr, Transform to)
	{
		return (Mathf.Abs((tr.position.x*tr.position.x-to.position.x*to.position.x)+(tr.position.y*tr.position.y-to.position.y*to.position.y)));
	}
}
