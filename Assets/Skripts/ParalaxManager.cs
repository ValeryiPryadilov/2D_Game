using UnityEngine;

public class ParalaxManager
{
    private const float _coef = 0.3f;

    private readonly Camera _camera;
    private readonly Transform _backTransform;
    //private readonly Transform _middlelTransform;
    private readonly Vector3 _backStartPosition;
    private readonly Vector3 _cameraStartPosition;
    //private readonly Vector3 _middleStartPosition;


    public ParalaxManager(Camera camera, Transform backTransform)
    {
        _camera = camera;
        _backTransform = backTransform;
        _backStartPosition = backTransform.position;
        //_middlelTransform = midlTransform;
        //_middleStartPosition = midlTransform.position;
        _cameraStartPosition = camera.transform.position;
  
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * _coef;
        //_middlelTransform.position = _middleStartPosition + (_camera.transform.position - _cameraStartPosition) * _coef;
    }
}
