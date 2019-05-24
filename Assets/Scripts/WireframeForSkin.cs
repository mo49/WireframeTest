using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireframeForSkin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();
        smr.sharedMesh.SetIndices(smr.sharedMesh.GetIndices(0), MeshTopology.LineStrip, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
