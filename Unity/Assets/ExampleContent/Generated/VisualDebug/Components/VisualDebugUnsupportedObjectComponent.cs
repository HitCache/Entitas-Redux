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

    public ExampleContent.VisualDebugging.UnsupportedObjectComponent UnsupportedObject { get { return (ExampleContent.VisualDebugging.UnsupportedObjectComponent)GetComponent(VisualDebugComponentsLookup.UnsupportedObject); } }
    public bool HasUnsupportedObject { get { return HasComponent(VisualDebugComponentsLookup.UnsupportedObject); } }

    public void AddUnsupportedObject(ExampleContent.VisualDebugging.UnsupportedObject newUnsupportedObject) {
        var index = VisualDebugComponentsLookup.UnsupportedObject;
        var component = (ExampleContent.VisualDebugging.UnsupportedObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnsupportedObjectComponent));
        component.unsupportedObject = newUnsupportedObject;
        AddComponent(index, component);
    }

    public void ReplaceUnsupportedObject(ExampleContent.VisualDebugging.UnsupportedObject newUnsupportedObject) {
        var index = VisualDebugComponentsLookup.UnsupportedObject;
        var component = (ExampleContent.VisualDebugging.UnsupportedObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnsupportedObjectComponent));
        component.unsupportedObject = newUnsupportedObject;
        ReplaceComponent(index, component);
    }

    public void RemoveUnsupportedObject() {
        RemoveComponent(VisualDebugComponentsLookup.UnsupportedObject);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherUnsupportedObject;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> UnsupportedObject {
        get {
            if (_matcherUnsupportedObject == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.UnsupportedObject);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherUnsupportedObject = matcher;
            }

            return _matcherUnsupportedObject;
        }
    }
}
