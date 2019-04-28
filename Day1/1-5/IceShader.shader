Shader "Custom/Ice" {
	SubShader {
		Tags { "Queue"="Transparent" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Standard alpha:fade
		#pragma target 3.0

		struct Input {
			float3 worldNormal;
      			float3 viewDir;
		};

		void surf (Input IN, inout SurfaceOutputStandard o) {
			o.Albedo = fixed4(1, 1, 1, 1);
			float alpha = 1 - (abs(dot(IN.viewDir, IN.worldNormal)));//法線ベクトルと視線ベクトルの内積によって透明度が変動
     			o.Alpha =  alpha*1.5f;
		}
		ENDCG
	}
	FallBack "Diffuse"
}