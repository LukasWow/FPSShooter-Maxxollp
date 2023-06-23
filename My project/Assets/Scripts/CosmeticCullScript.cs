using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticCullScript : MonoBehaviour
{
    public MeshRenderer[] cull;

    private void OnEnable()
    {
        foreach(MeshRenderer i in cull)
        {
            i.enabled = false;
        }
    }
}
