Shader "Custom/MovingRingsDraw" {
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
			float val = abs(sin(dist*3.0-_Time*100));	//座標から_Timeを引くことで外側へ波が動いているように見せている
            //valが最大振幅付近の時に白色に着色する
			if( val > 0.98 ){
				o.Albedo = fixed4(1,1,1,1);
			} else {
				o.Albedo = fixed4(110/255.0, 87/255.0, 139/255.0, 1);
			}
		}
		ENDCG
	}
	FallBack "Diffuse"
}