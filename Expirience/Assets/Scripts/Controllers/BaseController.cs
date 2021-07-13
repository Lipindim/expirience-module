using UnityEngine;


public abstract class BaseController<T>
{
    protected abstract string _viewPath { get; }
    protected T _view;

    protected void LoadView(Transform placeForUi)
    {
        var prefab = Resources.Load<GameObject>(_viewPath);
        var gameObject = GameObject.Instantiate(prefab, placeForUi);
        _view = gameObject.GetComponent<T>();

    }
}
