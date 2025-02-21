//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity
{
	public AnyMixedEventAddedListenerComponent AnyMixedEventAddedListener { get { return (AnyMixedEventAddedListenerComponent)GetComponent(TestComponentsLookup.AnyMixedEventAddedListener); } }
	public bool HasAnyMixedEventAddedListener { get { return HasComponent(TestComponentsLookup.AnyMixedEventAddedListener); } }

	public void AddAnyMixedEventAddedListener(System.Collections.Generic.List<IAnyMixedEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.AnyMixedEventAddedListener;
		var component = (AnyMixedEventAddedListenerComponent)CreateComponent(index, typeof(AnyMixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceAnyMixedEventAddedListener(System.Collections.Generic.List<IAnyMixedEventAddedListener> newValue)
	{
		var index = TestComponentsLookup.AnyMixedEventAddedListener;
		var component = (AnyMixedEventAddedListenerComponent)CreateComponent(index, typeof(AnyMixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyAnyMixedEventAddedListenerTo(AnyMixedEventAddedListenerComponent copyComponent)
	{
		var index = TestComponentsLookup.AnyMixedEventAddedListener;
		var component = (AnyMixedEventAddedListenerComponent)CreateComponent(index, typeof(AnyMixedEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveAnyMixedEventAddedListener()
	{
		RemoveComponent(TestComponentsLookup.AnyMixedEventAddedListener);
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
public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherAnyMixedEventAddedListener;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> AnyMixedEventAddedListener
	{
		get
		{
			if (_matcherAnyMixedEventAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.AnyMixedEventAddedListener);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherAnyMixedEventAddedListener = matcher;
			}

			return _matcherAnyMixedEventAddedListener;
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
public partial class TestEntity
{
	public void AddAnyMixedEventAddedListener(IAnyMixedEventAddedListener value)
	{
		var listeners = HasAnyMixedEventAddedListener
			? AnyMixedEventAddedListener.value
			: new System.Collections.Generic.List<IAnyMixedEventAddedListener>();
		listeners.Add(value);
		ReplaceAnyMixedEventAddedListener(listeners);
	}

	public void RemoveAnyMixedEventAddedListener(IAnyMixedEventAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = AnyMixedEventAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveAnyMixedEventAddedListener();
		}
		else
		{
			ReplaceAnyMixedEventAddedListener(listeners);
		}
	}
}
