using UnityEngine;

public class RaycastObject : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _newColor;

    private Material _material;
    private void Awake()
    {
        _material = _meshRenderer.material;
    }

    public void ChageColor()
    {
        _material.color = _newColor;
    }

    public void ResetColor()
    {
        _material.color = Color.white;
    }
}