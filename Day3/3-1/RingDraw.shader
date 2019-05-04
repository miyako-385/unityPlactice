Shader "Custom/RingDraw" {
	SubShader {
		Tags { "RenderType"="Opaque" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Standard 
		#pragma target 3.0

		struct Input {
			float3 worldPos;    //ワールド座標を受け取れるようにworldPosを宣言
		};

		void surf (Input IN, inout SurfaceOutputStandard o) {
			float dist = distance( fixed3(0,0,0), IN.worldPos );
			float radius = 2;
            //原点ーワールド座標間の距離が2.0～2.2の範囲の色を白に範囲外を紫に着色
			if(  radius < dist && dist < radius + 0.2){
				o.Albedo = fixed4(1,1,1,1);
			} else {
				o.Albedo = fixed4(110/255.0, 87/255.0, 139/255.0, 1);
			}
		}
		ENDCG
	}
	FallBack "Diffuse"
}