using UnityEngine;

public class Start_Point : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _backgraund;

    

    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationsConfig _spriteAnimationConfig;

    private ParalaxManager _paralaxManager;
    
    private SpriteAnimator _spriteAnimator;


    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _backgraund.transform);
        

        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.walk, true, 10);
    }

    private void Update()
    {
        _paralaxManager.Update();
        
        _spriteAnimator.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
