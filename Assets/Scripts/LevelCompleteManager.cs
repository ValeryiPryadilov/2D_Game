using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class LevelCompleteManager : IDisposable

{
    
    private List<LevelObjectView> _levelObjectViews;

    public LevelCompleteManager(List<LevelObjectView> levelObjectViews)
    {
        _levelObjectViews = levelObjectViews;

        foreach (var levelObjectView in _levelObjectViews)
        {
            levelObjectView.OnLevelObjectContact += OnLevelObjectContact;
        }
    }
    private void OnLevelObjectContact(LevelObjectView contactView)
    {
        if (_levelObjectViews.Contains(contactView))
            Object.Destroy(contactView.gameObject);
    }
    public void Dispose()
    {
        foreach (var levelObjectView in _levelObjectViews)
            levelObjectView.OnLevelObjectContact -= OnLevelObjectContact;
    }
}

