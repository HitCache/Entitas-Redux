//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity
{
	public Test2AnyMultipleEventsStandardEventAddedListenerComponent Test2AnyMultipleEventsStandardEventAddedListener { get { return (Test2AnyMultipleEventsStandardEventAddedListenerComponent)GetComponent(Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener); } }
	public bool HasTest2AnyMultipleEventsStandardEventAddedListener { get { return HasComponent(Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener); } }

	public void AddTest2AnyMultipleEventsStandardEventAddedListener(System.Collections.Generic.List<ITest2AnyMultipleEventsStandardEventAddedListener> newValue)
	{
		var index = Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener;
		var component = (Test2AnyMultipleEventsStandardEventAddedListenerComponent)CreateComponent(index, typeof(Test2AnyMultipleEventsStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTest2AnyMultipleEventsStandardEventAddedListener(System.Collections.Generic.List<ITest2AnyMultipleEventsStandardEventAddedListener> newValue)
	{
		var index = Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener;
		var component = (Test2AnyMultipleEventsStandardEventAddedListenerComponent)CreateComponent(index, typeof(Test2AnyMultipleEventsStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTest2AnyMultipleEventsStandardEventAddedListenerTo(Test2AnyMultipleEventsStandardEventAddedListenerComponent copyComponent)
	{
		var index = Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener;
		var component = (Test2AnyMultipleEventsStandardEventAddedListenerComponent)CreateComponent(index, typeof(Test2AnyMultipleEventsStandardEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTest2AnyMultipleEventsStandardEventAddedListener()
	{
		RemoveComponent(Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher
{
	static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherTest2AnyMultipleEventsStandardEventAddedListener;

	public static JCMG.EntitasRedux.IMatcher<Test2Entity> Test2AnyMultipleEventsStandardEventAddedListener
	{
		get
		{
			if (_matcherTest2AnyMultipleEventsStandardEventAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.Test2AnyMultipleEventsStandardEventAddedListener);
				matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
				_matcherTest2AnyMultipleEventsStandardEventAddedListener = matcher;
			}

			return _matcherTest2AnyMultipleEventsStandardEventAddedListener;
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity
{
	public void AddTest2AnyMultipleEventsStandardEventAddedListener(ITest2AnyMultipleEventsStandardEventAddedListener value)
	{
		var listeners = HasTest2AnyMultipleEventsStandardEventAddedListener
			? Test2AnyMultipleEventsStandardEventAddedListener.value
			: new System.Collections.Generic.List<ITest2AnyMultipleEventsStandardEventAddedListener>();
		listeners.Add(value);
		ReplaceTest2AnyMultipleEventsStandardEventAddedListener(listeners);
	}

	public void RemoveTest2AnyMultipleEventsStandardEventAddedListener(ITest2AnyMultipleEventsStandardEventAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = Test2AnyMultipleEventsStandardEventAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveTest2AnyMultipleEventsStandardEventAddedListener();
		}
		else
		{
			ReplaceTest2AnyMultipleEventsStandardEventAddedListener(listeners);
		}
	}
}
