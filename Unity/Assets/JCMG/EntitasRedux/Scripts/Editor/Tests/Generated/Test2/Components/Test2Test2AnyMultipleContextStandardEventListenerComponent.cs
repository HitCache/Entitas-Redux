//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public Test2AnyMultipleContextStandardEventListenerComponent Test2AnyMultipleContextStandardEventListener { get { return (Test2AnyMultipleContextStandardEventListenerComponent)GetComponent(Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener); } }
    public bool HasTest2AnyMultipleContextStandardEventListener { get { return HasComponent(Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener); } }

    public void AddTest2AnyMultipleContextStandardEventListener(System.Collections.Generic.List<ITest2AnyMultipleContextStandardEventListener> newValue) {
        var index = Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener;
        var component = (Test2AnyMultipleContextStandardEventListenerComponent)CreateComponent(index, typeof(Test2AnyMultipleContextStandardEventListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTest2AnyMultipleContextStandardEventListener(System.Collections.Generic.List<ITest2AnyMultipleContextStandardEventListener> newValue) {
        var index = Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener;
        var component = (Test2AnyMultipleContextStandardEventListenerComponent)CreateComponent(index, typeof(Test2AnyMultipleContextStandardEventListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTest2AnyMultipleContextStandardEventListener() {
        RemoveComponent(Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener);
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
public sealed partial class Test2Matcher {

    static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherTest2AnyMultipleContextStandardEventListener;

    public static JCMG.EntitasRedux.IMatcher<Test2Entity> Test2AnyMultipleContextStandardEventListener {
        get {
            if (_matcherTest2AnyMultipleContextStandardEventListener == null) {
                var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.Test2AnyMultipleContextStandardEventListener);
                matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
                _matcherTest2AnyMultipleContextStandardEventListener = matcher;
            }

            return _matcherTest2AnyMultipleContextStandardEventListener;
        }
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
public partial class Test2Entity {

    public void AddTest2AnyMultipleContextStandardEventListener(ITest2AnyMultipleContextStandardEventListener value) {
        var listeners = HasTest2AnyMultipleContextStandardEventListener
            ? Test2AnyMultipleContextStandardEventListener.value
            : new System.Collections.Generic.List<ITest2AnyMultipleContextStandardEventListener>();
        listeners.Add(value);
        ReplaceTest2AnyMultipleContextStandardEventListener(listeners);
    }

    public void RemoveTest2AnyMultipleContextStandardEventListener(ITest2AnyMultipleContextStandardEventListener value, bool removeComponentWhenEmpty = true) {
        var listeners = Test2AnyMultipleContextStandardEventListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveTest2AnyMultipleContextStandardEventListener();
        } else {
            ReplaceTest2AnyMultipleContextStandardEventListener(listeners);
        }
    }
}
