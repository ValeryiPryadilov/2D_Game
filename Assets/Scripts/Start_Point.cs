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

    private MainHeroWalker _mainHeroWalker;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _backgraund.transform);
        

        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
    }

    private void Update()
    {
        _paralaxManager.Update();
        
        _spriteAnimator.Update();

        _mainHeroWalker.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
