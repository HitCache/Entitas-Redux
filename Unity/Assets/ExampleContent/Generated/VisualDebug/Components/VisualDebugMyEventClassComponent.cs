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

    public MyEventClassComponent MyEventClass { get { return (MyEventClassComponent)GetComponent(VisualDebugComponentsLookup.MyEventClass); } }
    public bool HasMyEventClass { get { return HasComponent(VisualDebugComponentsLookup.MyEventClass); } }

    public void AddMyEventClass(ExampleContent.VisualDebugging.MyEventClass newValue) {
        var index = VisualDebugComponentsLookup.MyEventClass;
        var component = (MyEventClassComponent)CreateComponent(index, typeof(MyEventClassComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyEventClass(ExampleContent.VisualDebugging.MyEventClass newValue) {
        var index = VisualDebugComponentsLookup.MyEventClass;
        var component = (MyEventClassComponent)CreateComponent(index, typeof(MyEventClassComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyEventClass() {
        RemoveComponent(VisualDebugComponentsLookup.MyEventClass);
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

    static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyEventClass;

    public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyEventClass {
        get {
            if (_matcherMyEventClass == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyEventClass);
                matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
                _matcherMyEventClass = matcher;
            }

            return _matcherMyEventClass;
        }
    }
}
