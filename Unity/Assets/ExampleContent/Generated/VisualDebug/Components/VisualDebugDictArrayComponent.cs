//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity {

    public ExampleContent.VisualDebugging.DictArrayComponent DictArray { get { return (ExampleContent.VisualDebugging.DictArrayComponent)GetComponent(VisualDebugComponentsLookup.DictArray); } }
    public bool HasDictArray { get { return HasComponent(VisualDebugComponentsLookup.DictArray); } }

    public void AddDictArray(System.Collections.Generic.Dictionary<int, string[]> newDict, System.Collections.Generic.Dictionary<int, string[]>[] newDictArray) {
        var index = VisualDebugComponentsLookup.DictArray;
        var component = (ExampleContent.VisualDebugging.DictArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictArrayComponent));
        component.dict = newDict;
        component.dictArray = newDictArray;
        AddComponent(index, component);
    }

    public void ReplaceDictArray(System.Collections.Generic.Dictionary<int, string[]> newDict, System.Collections.Generic.Dictionary<int, string[]>[] newDictArray) {
        var index = VisualDebugComponentsLookup.DictArray;
        var component = (ExampleContent.VisualDebugging.DictArrayComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictArrayComponent));
        component.dict = newDict;
        component.dictArray = newDictArray;
        ReplaceComponent(index, component);
    }

    public void RemoveDictArray() {
        RemoveComponent(VisualDebugComponentsLookup.DictArray);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher {

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherDictArray;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> DictArray {
        get {
            if (_matcherDictArray == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.DictArray);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherDictArray = matcher;
            }

            return _matcherDictArray;
        }
    }
}
