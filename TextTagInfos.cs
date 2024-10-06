using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextTagInfos
{
    #region Editor
#if UNITY_EDITOR

    public static string TagsProperty => nameof(tags);
    public static string TextProperty => nameof(text);

#endif
    #endregion


    [SerializeReference]
    public List<TagData> tags = new();
    [TextArea(2,4)]
    public string text = string.Empty;
}
