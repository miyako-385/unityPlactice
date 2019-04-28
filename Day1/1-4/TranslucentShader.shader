Shader "Custom/Translucent" {
	SubShader {
		Tags { "Queue" = "Transparent" }    //描画の優先度
		LOD 200

		CGPROGRAM
		#pragma surface surf Standard alpha:fade //alpha:fadeを指定することで、オブジェクトを半透明で書くことができるようになる
		#pragma target 3.0

		struct Input {
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutputStandard o) {
			o.Albedo = fixed4(0.6f, 0.7f, 0.4f, 1);
			o.Alpha = 0.6;  //透明度を指定
		}
		ENDCG
	}
	FallBack "Diffuse"
}