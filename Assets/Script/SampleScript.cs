using DG.Tweening;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    //Computer Programming

    //Variable / Paramater

    private SpriteRenderer parentRenderer;
    private SpriteRenderer childRenderer;
    [SerializeField] private Color parentColor;
    [SerializeField] private Color childColor;
    private Color disableColor;

    //Methods
    private async Task Start()
    {
        parentRenderer = GetComponent<SpriteRenderer>();
        childRenderer = transform.parent.GetChild(0).GetComponent<SpriteRenderer>();

        parentRenderer.color = parentColor;
        childRenderer.color = childColor;
    }

    private void Awake()
    {
        Debug.Log("This code is awake");
    }

    private async Task OnEnable()
    {
        parentRenderer.color = Color.purple;
        childRenderer.color = parentRenderer.color;
        await Awaitable.WaitForSecondsAsync(0.25f);
        parentRenderer.color = parentColor;
        childRenderer.color = childColor;
        Debug.Log("This code is active!");
    }

    private async Task OnDisable()
    {
        parentRenderer.color = Color.purple;
        childRenderer.color = parentRenderer.color;
        await Awaitable.WaitForSecondsAsync(0.25f);
        parentRenderer.color = disableColor;
        childRenderer.color = parentRenderer.color;
        Debug.Log("This code is inactive");
    }

}
