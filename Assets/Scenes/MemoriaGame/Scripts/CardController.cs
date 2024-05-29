using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardController : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;

    public int MaxCardType => prefabs.Count;
    public UnityEvent<CardController> OnClicked;

     
    public int CardType = -1;
    public float Cardsize = 2f;
    private Animator _animator;

    private void Awake()
    {
       _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // Nota: Usa el reveal para mostrar las cartas unos segundos antes de ocultarlas todas :) 
        if (CardType < 0)
        {
            CardType = UnityEngine.Random.Range(0, prefabs.Count);
        }
        Instantiate(prefabs[CardType], transform.position, Quaternion.identity, transform);

    }

    private void OnMouseUpAsButton()
    {
        OnClicked.Invoke(this);
    }

    public void testAnimation()
    {
        IEnumerator AnimationCoroutine()
        {
            reveal();
            yield return new WaitForSeconds(2);
            Hide ();
        }
        StartCoroutine(AnimationCoroutine());
    }

    public void reveal()
    {
        _animator.SetBool("revealed", true);
    }
    public void Hide()
    {
        _animator.SetBool("revealed", false);
    }
}