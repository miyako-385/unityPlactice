using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        //メッシュの持つ頂点情報のトポロジをPointsに書き換えて再度保存
        meshFilter.mesh.SetIndices(meshFilter.mesh.GetIndices(0),MeshTopology.Points,0);
    }

}
