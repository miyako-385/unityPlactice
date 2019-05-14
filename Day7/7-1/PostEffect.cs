using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffect : MonoBehaviour {

	public Material monoTone;

	void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Graphics.Blit (src, dest, monoTone);//src画像に第三引数で指定したポストエフェクトをかけてdestに書き込み
	}
}