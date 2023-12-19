using System.Collections.Generic;
using UnityEngine;

public class Recoloring : MonoBehaviour
{
    [SerializeField] private float _recoloringDuration = 2f;
    [SerializeField] private float _delayDuration = 1f;

    private List<Renderer> _renderers;
    private List<Color> _startColors;
    private Color _nextColor;
    private float _recoloringTime;

    private void Awake()
    {
        _renderers = new List<Renderer>();
        _startColors = new List<Color>();

        GetChildRenderers();
        GenerateNextColor();
    }

    private void GetChildRenderers()
    {
        var childRenderers = GetComponentsInChildren<Renderer>();

        foreach (var renderer in childRenderers)
        {
            _renderers.Add(renderer);
            _startColors.Add(renderer.material.color);
        }
    }

    private void GenerateNextColor()
    {
        _nextColor = Random.ColorHSV(0f, 1f, 0.8f, 1f, 1f, 1f);
    }

    private void Update()
    {
        _recoloringTime += Time.deltaTime;

        var progress = _recoloringTime / _recoloringDuration;
        var currentColor = Color.Lerp(_startColors[0], _nextColor, progress);

        foreach (var renderer in _renderers)
        {
            renderer.material.color = currentColor;
        }

        if (_recoloringTime >= _recoloringDuration + _delayDuration)
        {
            _recoloringTime = 0;
            GenerateNextColor();
        }
    }
}