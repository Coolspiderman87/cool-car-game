using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadsMaterialSwitch : MonoBehaviour
{
    // Reference to the sphere object.
   
    // The material that is to be selected.
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public Material Material4;
    public Material Material5;
    public Material Material6;
    public Material Material7;
    public Material Material8;
    public Material Material9;
    public Material Material10;
    public Material Material11;
    
    
    [SerializeField]
    private Renderer planeRenderer;
    [SerializeField]
    private Renderer plane2Renderer;
    [SerializeField]
    private Renderer plane3Renderer;
    [SerializeField]
    private Renderer plane4Renderer;
    
    public void Texture1() {
        planeRenderer.sharedMaterial = Material1;
        plane2Renderer.sharedMaterial = Material1;
        plane3Renderer.sharedMaterial = Material1;
        plane4Renderer.sharedMaterial = Material1;
    }
    public void Texture2() {
        planeRenderer.sharedMaterial = Material2;
        plane2Renderer.sharedMaterial = Material2;
        plane3Renderer.sharedMaterial = Material2;
        plane4Renderer.sharedMaterial = Material2;
    }
    public void Texture3() {
        planeRenderer.sharedMaterial = Material3;
        plane2Renderer.sharedMaterial = Material3;
        plane3Renderer.sharedMaterial = Material3;
        plane4Renderer.sharedMaterial = Material3;
    }
    public void Texture4() {
        planeRenderer.sharedMaterial = Material4;
        plane2Renderer.sharedMaterial = Material4;
        plane3Renderer.sharedMaterial = Material4;
        plane4Renderer.sharedMaterial = Material4;
    }
    public void Texture5() {
        planeRenderer.sharedMaterial = Material5;
        plane2Renderer.sharedMaterial = Material5;
        plane3Renderer.sharedMaterial = Material5;
        plane4Renderer.sharedMaterial = Material5;
    }
    public void Texture6() {
        planeRenderer.sharedMaterial = Material6;
        plane2Renderer.sharedMaterial = Material6;
        plane3Renderer.sharedMaterial = Material6;
        plane4Renderer.sharedMaterial = Material6;
    }
    public void Texture7() {
        planeRenderer.sharedMaterial = Material7;
        plane2Renderer.sharedMaterial = Material7;
        plane3Renderer.sharedMaterial = Material7;
        plane4Renderer.sharedMaterial = Material7;
    }
    public void Texture8() {
        planeRenderer.sharedMaterial = Material8;
        plane2Renderer.sharedMaterial = Material8;
        plane3Renderer.sharedMaterial = Material8;
        plane4Renderer.sharedMaterial = Material8;
    }
    public void Texture9() {
        planeRenderer.sharedMaterial = Material9;
        plane2Renderer.sharedMaterial = Material9;
        plane3Renderer.sharedMaterial = Material9;
        plane4Renderer.sharedMaterial = Material9;
    }
    public void Texture10() {
        planeRenderer.sharedMaterial = Material10;
        plane2Renderer.sharedMaterial = Material10;
        plane3Renderer.sharedMaterial = Material10;
        plane4Renderer.sharedMaterial = Material10;
    }
    public void Texture11() {
        planeRenderer.sharedMaterial = Material11;
        plane2Renderer.sharedMaterial = Material11;
        plane3Renderer.sharedMaterial = Material11;
        plane4Renderer.sharedMaterial = Material11;
    }
    
    
    public void LowQuality() {
        QualitySettings.SetQualityLevel(0, true);
        QualitySettings.globalTextureMipmapLimit = 3;
    }
    public void MedQuality() {
        QualitySettings.SetQualityLevel(2, true);
        QualitySettings.globalTextureMipmapLimit = 2;
    }
    public void HighQuality() {
        QualitySettings.SetQualityLevel(4, true);
        QualitySettings.globalTextureMipmapLimit = 1;
    }
    public void UltraQuality() {
        QualitySettings.SetQualityLevel(5, true);
        QualitySettings.globalTextureMipmapLimit = 0;
    }
   
}

