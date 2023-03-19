using UnityEngine;

public class HideShowMenu : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private bool _isOpen;

    void Start()
    {
        _isOpen = true;
    }

    public void Switch()
    { 
        _isOpen = !_isOpen;

        if (_isOpen)
            _animator.SetTrigger("Show");
        else
            _animator.SetTrigger("Hide");

    }
}
