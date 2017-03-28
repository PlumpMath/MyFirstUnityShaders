using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PostEffectScript : MonoBehaviour {

    public Material mat;


	void OnRenderImage( RenderTexture src, RenderTexture dest ) {

        // src is the rendered scene 
        // dest is out outgoing texture to the GPU

	    Graphics.Blit( src, dest, mat);
	}
}
