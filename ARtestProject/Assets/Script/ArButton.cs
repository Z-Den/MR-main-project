using Microsoft.MixedReality.Toolkit.UI;
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ArButton : MonoBehaviour
{
    public event Action OnButtonClicked;
    [SerializeField] private TextMeshPro _title;
    [SerializeField] private Interactable interactable;
    [SerializeField] private ButtonConfigHelper _buttonConfigHelper;

    private GameObject _prefab;

    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _prefab = config.Prefab;
        _buttonConfigHelper.SetSpriteIcon(config.Icon);

        interactable.OnClick.AddListener(ProcessClick);
    }
    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
    }
}
