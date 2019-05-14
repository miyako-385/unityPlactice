using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WipeCircle : MonoBehaviour {

	public Material wipeCircle;

	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Graphics.Blit (src, dest, wipeCircle);
	}
}
