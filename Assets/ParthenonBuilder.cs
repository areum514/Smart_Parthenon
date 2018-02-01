using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParthenonBuilder : MonoBehaviour {

    public GameObject cubePrefab;//멤버변수추가 
    public GameObject cylinderPrefab;//멤버변수추가  

    public float floorWidth = 5.0f, floorDepth = 10.0f, floorHeight=0.25f;
    public float pillarRadius =0.2f, pillarHeight =2, pillarCountWidth =6, pillarCountDepth =10;
    public int roofHeight = 1;
    public Material floorMaterial, pillarMaterial , roofMaterial;
    
    [ContextMenu("Budil Parthenon")]
    void Build()
    {
        DestoryAllChildren();

        var floor1 = Instantiate(cubePrefab, transform);
        floor1.transform.localPosition = new Vector3(0, 0, 0);
        floor1.transform.localScale = new Vector3(floorWidth, floorHeight, floorDepth);

        var floor2 = Instantiate(cubePrefab, transform);
        floor2.transform.localPosition = new Vector3(0, floorHeight, 0);
        floor2.transform.localScale = new Vector3(floorWidth * 0.9f, floorHeight, floorDepth * 0.9f);


        var floor3 = Instantiate(cubePrefab, transform);
        floor3.transform.localPosition = new Vector3(0, floorHeight * 2, 0);
        floor3.transform.localScale = new Vector3(floorWidth * 0.9f * 0.9f, floorHeight, floorDepth * 0.9f * 0.9f);

     



    }

    [ContextMenu("Destory All")]
    void DestoryAllChildren()
    {
        foreach (Transform t in transform.Cast<Transform>().ToArray())
        {
            DestroyImmediate(t.gameObject);  }

    }

}
